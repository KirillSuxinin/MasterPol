using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterPolApp
{
    public partial class MainHandlerForm : Form
    {
        public MainHandlerForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Upd()
        {
            if (Properties.Settings.Default.IsAdmin)
            {
                //Массив форм для администратора
                typeF = new Form[]
                {
            new Lenta.AccessLogsForm(),
            new Lenta.EmployeesForm(),
            new Lenta.EmployeeSkillsForm(),
            new Lenta.ManagersForm(),
            new Lenta.MaterialsForm(),
            new Lenta.MaterialStockHistoryForm(),
            new Lenta.OrderItemsForm(),
            new Lenta.OrdersForm(),
            new Lenta.PartnerRatingHistoryForm(),
            new Lenta.PartnersForm(),
            new Lenta.PartnerSalesLocationsForm(),
            new Lenta.ProductMaterialsForm(),
            new Lenta.ProductMinPriceHistoryForm(),
            new Lenta.ProductsForm(),
            new Lenta.ProductWarehouseStockForm(),
            new Lenta.SalesHistoryForm(),
            new Lenta.SuppliersForm(),
            new Lenta.SupplyHistoryForm(),
            new Lenta.UsersForm(),
            new Lenta.WarehousesForm(),
            new Lenta.WarehouseStockForm()
                };
            }
            else
            {
                //массив форм для пользователя
                typeF = new Form[]
{
            new Lenta.ManagersForm(),
            new Lenta.MaterialsForm(),
            new Lenta.OrdersForm(),
            new Lenta.PartnersForm(),
            new Lenta.PartnerSalesLocationsForm(),

            new Lenta.ProductsForm(),
            new Lenta.ProductWarehouseStockForm(),
            new Lenta.SuppliersForm(),

            new Lenta.WarehousesForm(),
            new Lenta.WarehouseStockForm()
};

            }
        }
        Form[] typeF;

        private void MainHandlerForm_Load(object sender, EventArgs e)
        {

            Upd();
            ListBoxForms.Items.Clear();
            for (int i = 0; i < typeF.Length; i++)
            {
                ListBoxForms.Items.Add(typeF[i].Text);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (ListBoxForms.SelectedIndex != -1)
            {
                var createI = typeF[ListBoxForms.SelectedIndex];
                Upd();
                createI.Show();
            }
        }
    }
}
