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
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.suppliersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Suppliers". При необходимости она может быть перемещена или удалена.
                this.suppliersTableAdapter.Fill(this.masterPolDataSet.Suppliers);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Materials". При необходимости она может быть перемещена или удалена.
                this.materialsTableAdapter.Fill(this.masterPolDataSet.Materials);
                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("Materials", materialsBindingNavigatorSaveItem_Click, materialsBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }

        private void UpdateImage()
        {
            if (string.IsNullOrWhiteSpace(imageTextBox.Text))
                return;

            var img = Program.GetImage(imageTextBox.Text);
            if (img != null)
            {
                picImage.Image = img;
            }
            else
            {
                picImage.Image = null;
            }
        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateImage();
        }
    }
}
