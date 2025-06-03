using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolApp
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
            Properties.Settings.Default.IsAdmin = false;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Обработчик события клика на кнопку "Выход"
        /// </summary>
        /// <param name="sender">Объект вызова</param>
        /// <param name="e">Аргументы</param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Закрываем форму
            this.Close();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            AuthForm authF = new AuthForm();
            if(authF.ShowDialog(this) == DialogResult.OK)
            {
                MainHandlerForm mainform = new MainHandlerForm();
                this.Hide();
                mainform.ShowDialog(this);
                this.Show();
            }
        }

        private void Title_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.masterPolDataSet.Products);
            if(productsBindingSource.Count <= 0)
            {
                tbPageProduct.Controls.Clear();
                Label lab = new Label();
                lab.AutoSize = true;
                lab.Text = "Внимание!\nТовары отсутствуют!";
                tbPageProduct.Controls.Add(lab);
            }
            var GoodCompany = Program.Connection.CreateCommand();
            //Запрос на выборку 1 записи по макс. рейтингу
            GoodCompany.CommandText = "SELECT TOP(1) CompanyName,LegalAddress,Rating From Partners ORDER BY Rating DESC";
            using(var reader = GoodCompany.ExecuteReader())
            {
                var tb = new DataTable();
                tb.Load(reader);
                if(tb.Rows.Count > 0)
                {
                    labCompanyName.Text = "Наименование: " + tb.Rows[0].Field<string>("CompanyName");
                    labLegalAddress.Text = "Адрес: " + tb.Rows[0].Field<string>("LegalAddress");
                    labRating.Text = "Рейтинг: " + tb.Rows[0].Field<int>("Rating").ToString();
                }
                else
                {
                    //Скрываем группу "Лучших партнеров"
                    gBGoodsPartner.Visible = false;
                }
            }
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterPolDataSet);

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.MoveFirst();

            }catch(Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.MovePrevious();

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.MoveNext();

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                productsBindingSource.MoveLast();

            }
            catch (Exception g)
            {
                MessageBox.Show(this, g.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            //Загружаем изображение в ином случае берем из ресурсов
            var img = Program.GetImage(imageTextBox.Text);
            if(img != null)
            {
                picImage.Image = img;
            }
            else
            {
                picImage.Image = null;
            }
        }
    }
}
