using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolApp.Lenta
{
    public partial class AccessLogsForm : Form
    {
        public AccessLogsForm()
        {
            InitializeComponent();
        }

        private void accessLogsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.accessLogsBindingSource.EndEdit();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this,"Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AccessLogsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Employees". При необходимости она может быть перемещена или удалена.
                this.employeesTableAdapter.Fill(this.masterPolDataSet.Employees);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.AccessLogs". При необходимости она может быть перемещена или удалена.
                this.accessLogsTableAdapter.Fill(this.masterPolDataSet.AccessLogs);

                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("AccessLogs", accessLogsBindingNavigatorSaveItem_Click, accessLogsBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch(Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
