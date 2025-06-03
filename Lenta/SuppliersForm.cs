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
    public partial class SuppliersForm : Form
    {
        public SuppliersForm()
        {
            InitializeComponent();
        }

        private void suppliersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.suppliersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
                this.suppliersTableAdapter.Fill(this.masterPolDataSet.Suppliers);

                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("Suppliers", suppliersBindingNavigatorSaveItem_Click, suppliersBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
