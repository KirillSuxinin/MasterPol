using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Устанавливаем состояние отмены (Это состояние возвращается в ShowDialog())
            this.DialogResult = DialogResult.Cancel;
            //Закрываем форму
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.White;
            txtPassword.BackColor = Color.White;
            //Проверка данных
            if(string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show(this, "Введите логин!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.BackColor = Color.Red;
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(this, "Введите пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.BackColor = Color.Red;
                return;
            }
            //Запрос на авторизацию с логином и паролем
            var com = Program.Connection.CreateCommand();
            com.CommandText = $"SELECT * FROM [Users] WHERE [Login] = \'{txtLogin.Text}\' AND [Password] = \'{txtPassword.Text}\'";
            using(var reader = com.ExecuteReader())
            {
                var rd = new DataTable();
                rd.Load(reader);
                if(rd.Rows.Count > 0)
                {
                    if (rd.Rows[0].Field<string>("Role").ToUpper() == "admin".ToUpper())
                    {
                        Properties.Settings.Default.IsAdmin = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.IsAdmin = false;
                        Properties.Settings.Default.Save();
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "Неправильный логин или пароль!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogin.Focus();
                btnOk?.PerformClick();
            }
        }
    }
}
