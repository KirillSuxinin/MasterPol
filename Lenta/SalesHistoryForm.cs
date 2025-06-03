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
    public partial class SalesHistoryForm : Form
    {
        public SalesHistoryForm()
        {
            InitializeComponent();
        }

        private void salesHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.salesHistoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SalesHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.SalesHistory". При необходимости она может быть перемещена или удалена.
                this.salesHistoryTableAdapter.Fill(this.masterPolDataSet.SalesHistory);
                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("SalesHistory", salesHistoryBindingNavigatorSaveItem_Click, salesHistoryBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
