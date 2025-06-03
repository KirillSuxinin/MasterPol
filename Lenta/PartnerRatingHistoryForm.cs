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
    public partial class PartnerRatingHistoryForm : Form
    {
        public PartnerRatingHistoryForm()
        {
            InitializeComponent();
        }

        private void partnerRatingHistoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.partnerRatingHistoryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PartnerRatingHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.PartnerRatingHistory". При необходимости она может быть перемещена или удалена.
                this.partnerRatingHistoryTableAdapter.Fill(this.masterPolDataSet.PartnerRatingHistory);
                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("PartnerRatingHistory", partnerRatingHistoryBindingNavigatorSaveItem_Click, partnerRatingHistoryBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
