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
    public partial class ManagersForm : Form
    {
        public ManagersForm()
        {
            InitializeComponent();
        }

        private void managersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.managersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManagersForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Managers". При необходимости она может быть перемещена или удалена.
                this.managersTableAdapter.Fill(this.masterPolDataSet.Managers);
                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("Managers", managersBindingNavigatorSaveItem_Click, managersBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
