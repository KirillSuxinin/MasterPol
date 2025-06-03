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
    public partial class EmployeeSkillsForm : Form
    {
        public EmployeeSkillsForm()
        {
            InitializeComponent();
        }

        private void employeeSkillsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.employeeSkillsBindingSource.EndEdit();
                this.employeesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.masterPolDataSet);
                MessageBox.Show(this, "Данные успешно сохранены!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EmployeeSkillsForm_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.Employees". При необходимости она может быть перемещена или удалена.
                this.employeesTableAdapter.Fill(this.masterPolDataSet.Employees);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "masterPolDataSet.EmployeeSkills". При необходимости она может быть перемещена или удалена.
                this.employeeSkillsTableAdapter.Fill(this.masterPolDataSet.EmployeeSkills);

                //Данный код биндит событие на кнопки которые прописаны в Common.LentaHandlerClass
                Common.LentaHandlerClass.Handler("EmployeeSkills", employeeSkillsBindingNavigatorSaveItem_Click, employeeSkillsBindingSource, btnBack, btnFirst, btnPrev, btnNext, btnLast, btnSave, btnAdd, btnRemove, btnCancel, btnSort, bindingNavigatorDeleteItem, bindingNavigatorAddNewItem);
            }
            catch (Exception g)
            {
                MessageBox.Show(this, g + "", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
