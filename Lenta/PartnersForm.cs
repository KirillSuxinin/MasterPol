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
    public partial class PartnersForm : Form
    {
        public PartnersForm()
        {
            InitializeComponent();
        }

        private void partnersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.partnersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PartnersForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Partners". При необходимости она может быть перемещена или удалена.
                this.partnersTableAdapter.Fill(this.masterPolDataSet.Partners);
                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("Partners", partnersBindingNavigatorSaveItem_Click, partnersBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateImage()
        {
            if (string.IsNullOrWhiteSpace(logoTextBox.Text))
                return;

            var img = Program.GetImage(logoTextBox.Text);
            if (img != null)
            {
                picImage.Image = img;
            }
            else
            {
                picImage.Image = null;
            }
        }

        private void logoTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void partnersBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }
    }
}
