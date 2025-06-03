using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ThreadState = System.Threading.ThreadState;

namespace MasterPolApp
{
    internal static class Program
    {

        internal static JSON.Rootobject_Translater Translater;
        /// <summary>
        /// Объект подключения к Базе данных (Храним в Common.DbConnection если поставщик данных изменится)
        /// </summary>
        internal static System.Data.Common.DbConnection Connection = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.MasterPolConnectionString);

        /// <summary>
        /// Этот лист нужен если закрываем приложение то подпотоки закрываем принудительно
        /// </summary>
        internal static List<Thread> ThreadForDispose = new List<Thread>();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                //Загрузка переводчика
                if (System.IO.File.Exists($"{Application.StartupPath}\\rus.json"))
                {
                    Translater = JsonConvert.DeserializeObject<JSON.Rootobject_Translater>(System.IO.File.ReadAllText($"{Application.StartupPath}\\rus.json", System.Text.Encoding.UTF8));
                    if (Translater == null || Translater.Rus == null || Translater.Rus.Count <= 0)
                        Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };

                    foreach (var ele in Translater.Rus)
                    {
                        if (ele == null)
                        {
                            Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                            throw new Exception("Ошибка синтаксиса перевода!\nГлавный элемент не найден!");
                        }
                        if (ele.NameTable == null)
                        {
                            Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                            throw new Exception("Ошибка синтаксиса перевода!\nНазвание таблицы перевода не найдено!");
                        }
                        if (ele.HeaderTable == null)
                        {
                            Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                            throw new Exception("Ошибка синтаксиса перевода!\nПеревод элемента не найден!");
                        }
                        foreach (var proper in ele.Property)
                        {
                            if (proper == null)
                            {
                                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                                throw new Exception("Ошибка синтаксиса перевода!\nГлавный элемент свойства не найден! (Proper)");
                            }
                            if (proper.HeaderProperty == null)
                            {
                                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                                throw new Exception("Ошибка синтаксиса перевода!\nПеревод элемента таблицы не найден! (HeaderProperty)");
                            }
                            if (proper.NameProperty == null)
                            {
                                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
                                throw new Exception("Ошибка синтаксиса перевода!\nПеревод элемента свойства не найден! (NameProperty)");
                            }
                        }
                    }

                }
                else
                    Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
            }
            catch (Exception g)
            {
                MessageBox.Show("Program.cs [Translater initializator]\n" + g.Message, "PROGRAMM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("В инициализаторе перевода возникла ошибка!\nДальнейшей перевод не возможен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //При полном отсутствие или неполноценности данных инициализуем пустой экземпляр (в ином случае будет NullRefrences везде где используется этот экземпляр, по другому говоря это заглушка)
                Translater = new JSON.Rootobject_Translater() { Rus = new List<JSON.Tables>() };
            }
            OpenConnect();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Запуск формы вступления
            Application.Run(new Title());
            //Отсюда любой код выполниться в момент закрытия последней формы (Кроме Environment.Exit()) поэтому используем Application.Exit()
            //Сбрасываем состояние
            Properties.Settings.Default.IsAdmin = false;
            Properties.Settings.Default.Save();
            //Перед выходом закрываем подключение
            Connection.Close();

            //Также если будут потоки тут мы их закрываем (В ином случае потоки и подпотоки будут работать и держать процесс даже если окна закрыты)
            foreach (Thread thExit in ThreadForDispose)
            {
                if(thExit.ThreadState != ThreadState.Stopped)
                {
                    Debugger.Log(0, "Debug", $"Закрытие: {thExit.Name} -> {thExit.ThreadState}\n\n");
                    thExit.Abort();
                }
            }
        }

        internal static Bitmap GetImage(string CURL)
        {
            try
            {
                WebClient web = new WebClient();
                byte[] data = web.DownloadData(CURL);
                return (Bitmap)Image.FromStream(new MemoryStream(data));
            }
            catch(Exception g)
            {
                return null;
            }
        }

        static async void OpenConnect()
        {
            try
            {
                await Connection.OpenAsync().ContinueWith(t =>
                {
                    //Выводим сообщение о подключение
                    //ОТКАЗ ОТ СООБЩЕНИЯ
                });
            }
            catch(Exception g)
            {
                Debugger.Log(0, "Debug", g.Message + "\n" + g + "\n");
            }
        }
    }
}
