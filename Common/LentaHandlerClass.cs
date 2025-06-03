using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolApp.Common
{
    internal class LentaHandlerClass
    {
        /// <summary>
        /// Метод обработки элементов ленточной формы относительно прав администратора
        /// </summary>
        /// <param name="vs">Элемент</param>
        private static void HandlerAdminRules(Control vs)
        {
            //Ставим ReadOnly для TextBox если не админ
            if (vs is TextBox)
            {
                (vs as TextBox).ReadOnly = true;
            }
            //Ставим Enable для элемента который показывает время т.к. там нет свойства отвечающие за редактирование
            if (vs is DateTimePicker)
            {
                (vs as DateTimePicker).Enabled = false;
            }
            //Тоже самое что и для DateTimePicker
            if (vs is ComboBox)
            {
                (vs as ComboBox).Enabled = false;
            }
        }

        /// <summary>
        /// Метод для создания обработки ленточной формы
        /// С помощью этого метода добавляется базовая логика взаимодействия с привязкой
        /// </summary>
        /// <param name="NameTableForSort">Наименование для таблицы</param>
        /// <param name="binder">Сам биндер</param>
        /// <param name="cancel">Кнопка выхода из формы</param>
        /// <param name="first">Кнопка первая запись</param>
        /// <param name="prev">Кнопка пред запись</param>
        /// <param name="next">Кнопка след запись</param>
        /// <param name="last">Кнопка послед запись</param>
        /// <param name="save">Кнопка сохранения</param>
        /// <param name="add">Кнопка добавления</param>
        /// <param name="delete">Кнопка удаления</param>
        /// <param name="cancelEdit">Кнопка отмены редактирования</param>
        /// <param name="sorted">Кнопка сортировки</param>
        public static void Handler(string NameTableForSort, EventHandler saveHandler, BindingSource binder, Button cancel, Button first, Button prev, Button next, Button last, Button save, Button add, Button delete, Button cancelEdit, Button sorted, ToolStripButton deleteHandler,ToolStripButton addedF)
        {
            //Если пользователь не админ то делаем неактивные кнопки на изменения и обновления
            if (!Properties.Settings.Default.IsAdmin)
            {
                //Получаем форму обработки
                Form handlerform = (cancel.FindForm());
                //Проходим по каждым элементам
                foreach (Control vs in handlerform.Controls)
                {
                    HandlerAdminRules(vs);
                    //Не забываем что элементы внутри группы/панели не будут находится в коллекции Controls
                    if(vs is GroupBox)
                    {
                        //Проходим все элементы в панели/группе
                        foreach(Control vs2 in (vs as GroupBox).Controls)
                        {
                            HandlerAdminRules(vs2);
                        }
                    }
                }
                //Скрываем кнопки управления
                cancelEdit.Enabled = false;
                save.Enabled = false;
                delete.Enabled = false;
                add.Enabled = false;
            }
            //Передаём экземпляр бинда (нужно чтобы каждая кнопка хранила в себе привязку, т.к. если использовать замыкание то объект привязки будет нестабильный из-за множества форм
            cancel.Tag = binder;
            first.Tag = binder;
            prev.Tag = binder;
            next.Tag = binder;
            last.Tag = binder;
            cancelEdit.Tag = binder;

            //Привязываем событие
            cancel.Click -= Handle_Cancel;
            cancel.Click += Handle_Cancel;

            first.Click -= Handle_First;
            first.Click += Handle_First;

            prev.Click -= Handle_Prev;
            prev.Click += Handle_Prev;

            next.Click -= Handle_Next;
            next.Click += Handle_Next;

            last.Click -= Handle_Last;
            last.Click += Handle_Last;

            //Привязка к администратору
            save.Click -= saveHandler;
            save.Click += saveHandler;
            delete.Click += (sender, e) =>
            {
                try
                {
                    if (MessageBox.Show((sender as Button).FindForm(), "Вы уверены что хотите удалить эту запись?" , "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteHandler?.PerformClick();
                    }
                }
                catch (Exception g)
                {
                    if (MessageBox.Show((sender as Button).FindForm(), g.Message + "\nПоказать больше?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        MessageBox.Show((sender as Button).FindForm(), g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };
            add.Click += (sender, e) =>
            {
                addedF?.PerformClick();
            };

            sorted.Tag = NameTableForSort;
            sorted.Click -= Handle_Sort;
            sorted.Click += Handle_Sort;

            cancelEdit.Click -= Handle_CancelEdit;
            cancelEdit.Click += Handle_CancelEdit;
        }

        #region Кнопка выхода
        /// <summary>
        /// Обработчик событие по закрытию формы
        /// </summary>
        /// <param name="sender">Объект вызова</param>
        /// <param name="e">Аргумент</param>
        private static void Handle_Cancel(object sender,EventArgs e)
        {
            //Закрываем форму
            (sender as Button).FindForm().Close();
        }
        #endregion

        #region Кнопка первая запись

        /// <summary>
        /// Обработчик событие перехода на первую запись
        /// </summary>
        /// <param name="sender">Объект вызова</param>
        /// <param name="e">Аргумент</param>
        private static void Handle_First(object sender,EventArgs e)
        {
            try
            {
                //Берём sender преобразуем её в кнопку
                //у кнопки берём свойство Tag (Который установили ещё в Handler)
                //Свойство Tag преобразуем в BindingSource
                //Это нужно т.к. если передавать BindingSource как свойство класса будет перепутано т.к. класс у нас статичный
                ((sender as Button).Tag as BindingSource).MoveFirst();

            }catch(Exception g)
            {
                //Берём наш sender (тот кто вызвал событие в нашем случае кнопка "<" и ищем его форму FindForm() и относительно неё показываем MessageBox)
                if(MessageBox.Show((sender as Button).FindForm(), g.Message + "\nПоказать больше?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show((sender as Button).FindForm(), g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Кнопка Предыдущая запись
        /// <summary>
        /// Обработчик события
        /// </summary>
        /// <param name="sender">Объект вызова</param>
        /// <param name="e">Аргументы</param>
        private static void Handle_Prev(object sender,EventArgs e)
        {
            try
            {
                //Берём sender преобразуем её в кнопку
                //у кнопки берём свойство Tag (Который установили ещё в Handler)
                //Свойство Tag преобразуем в BindingSource
                //Это нужно т.к. если передавать BindingSource как свойство класса будет перепутано т.к. класс у нас статичный
                ((sender as Button).Tag as BindingSource).MovePrevious();

            }
            catch (Exception g)
            {
                //Берём наш sender (тот кто вызвал событие в нашем случае кнопка "<<" и ищем его форму FindForm() и относительно неё показываем MessageBox)
                if (MessageBox.Show((sender as Button).FindForm(), g.Message + "\nПоказать больше?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show((sender as Button).FindForm(), g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Кнопка Следующая запись
        /// <summary>
        /// Обработчик события
        /// </summary>
        /// <param name="sender">Объект вызова события</param>
        /// <param name="e">Аргументы</param>
        private static void Handle_Next(object sender,EventArgs e)
        {
            try
            {
                //Берём sender преобразуем её в кнопку
                //у кнопки берём свойство Tag (Который установили ещё в Handler)
                //Свойство Tag преобразуем в BindingSource
                //Это нужно т.к. если передавать BindingSource как свойство класса будет перепутано т.к. класс у нас статичный
                ((sender as Button).Tag as BindingSource).MoveNext();

            }
            catch (Exception g)
            {
                //Берём наш sender (тот кто вызвал событие в нашем случае кнопка ">" и ищем его форму FindForm() и относительно неё показываем MessageBox)
                if (MessageBox.Show((sender as Button).FindForm(), g.Message + "\nПоказать больше?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show((sender as Button).FindForm(), g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Кнопка последняя запись
        /// <summary>
        /// Обработчик события
        /// </summary>
        /// <param name="sender">Объект вызова события</param>
        /// <param name="e">Аргументы</param>
        private static void Handle_Last(object sender, EventArgs e)
        {
            try
            {
                //Берём sender преобразуем её в кнопку
                //у кнопки берём свойство Tag (Который установили ещё в Handler)
                //Свойство Tag преобразуем в BindingSource
                //Это нужно т.к. если передавать BindingSource как свойство класса будет перепутано т.к. класс у нас статичный
                ((sender as Button).Tag as BindingSource).MoveLast();

            }
            catch (Exception g)
            {
                //Берём наш sender (тот кто вызвал событие в нашем случае кнопка ">" и ищем его форму FindForm() и относительно неё показываем MessageBox)
                if (MessageBox.Show((sender as Button).FindForm(), g.Message + "\nПоказать больше?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show((sender as Button).FindForm(), g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Кнопка Отмена редактирования
        private static void Handle_CancelEdit(object sender,EventArgs e)
        {
            try
            {
                ((sender as Button).Tag as BindingSource).CancelEdit();
            }
            catch (Exception g)
            {
                if (MessageBox.Show((sender as Button).FindForm(), g.Message + "\nПоказать больше?", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    MessageBox.Show((sender as Button).FindForm(), g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion


        #region Кнопка сортировки
        private static void Handle_Sort(object sender,EventArgs e)
        {
            Tables.CommonHandlerTablesForm co = new Tables.CommonHandlerTablesForm((sender as Button).Tag.ToString());
            co.Show();
        }
        #endregion

    }
}
