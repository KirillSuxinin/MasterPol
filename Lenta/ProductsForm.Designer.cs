namespace MasterPolApp.Lenta
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label productTypeLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label minPriceForPartnerLabel;
            System.Windows.Forms.Label packageLengthLabel;
            System.Windows.Forms.Label packageWidthLabel;
            System.Windows.Forms.Label packageHeightLabel;
            System.Windows.Forms.Label weightWithoutPackageLabel;
            System.Windows.Forms.Label weightWithPackageLabel;
            System.Windows.Forms.Label qualityCertificateLabel;
            System.Windows.Forms.Label standardNumberLabel;
            System.Windows.Forms.Label productionTimeLabel;
            System.Windows.Forms.Label productionCostLabel;
            System.Windows.Forms.Label workshopNumberLabel;
            System.Windows.Forms.Label productionWorkersLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.masterPolDataSet = new MasterPolApp.MasterPolDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new MasterPolApp.MasterPolDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new MasterPolApp.MasterPolDataSetTableAdapters.TableAdapterManager();
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.productTypeTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.minPriceForPartnerTextBox = new System.Windows.Forms.TextBox();
            this.packageLengthTextBox = new System.Windows.Forms.TextBox();
            this.packageWidthTextBox = new System.Windows.Forms.TextBox();
            this.packageHeightTextBox = new System.Windows.Forms.TextBox();
            this.weightWithoutPackageTextBox = new System.Windows.Forms.TextBox();
            this.weightWithPackageTextBox = new System.Windows.Forms.TextBox();
            this.qualityCertificateTextBox = new System.Windows.Forms.TextBox();
            this.standardNumberTextBox = new System.Windows.Forms.TextBox();
            this.productionTimeTextBox = new System.Windows.Forms.TextBox();
            this.productionCostTextBox = new System.Windows.Forms.TextBox();
            this.workshopNumberTextBox = new System.Windows.Forms.TextBox();
            this.productionWorkersTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            productIDLabel = new System.Windows.Forms.Label();
            articleLabel = new System.Windows.Forms.Label();
            productTypeLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            minPriceForPartnerLabel = new System.Windows.Forms.Label();
            packageLengthLabel = new System.Windows.Forms.Label();
            packageWidthLabel = new System.Windows.Forms.Label();
            packageHeightLabel = new System.Windows.Forms.Label();
            weightWithoutPackageLabel = new System.Windows.Forms.Label();
            weightWithPackageLabel = new System.Windows.Forms.Label();
            qualityCertificateLabel = new System.Windows.Forms.Label();
            standardNumberLabel = new System.Windows.Forms.Label();
            productionTimeLabel = new System.Windows.Forms.Label();
            productionCostLabel = new System.Windows.Forms.Label();
            workshopNumberLabel = new System.Windows.Forms.Label();
            productionWorkersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPolDataSet
            // 
            this.masterPolDataSet.DataSetName = "MasterPolDataSet";
            this.masterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.masterPolDataSet;
            this.productsBindingSource.PositionChanged += new System.EventHandler(this.productsBindingSource_PositionChanged);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccessLogsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeSkillsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ManagersTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.MaterialStockHistoryTableAdapter = null;
            this.tableAdapterManager.OrderItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.PartnerRatingHistoryTableAdapter = null;
            this.tableAdapterManager.PartnerSalesLocationsTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
            this.tableAdapterManager.ProductMaterialsTableAdapter = null;
            this.tableAdapterManager.ProductMinPriceHistoryTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ProductWarehouseStockTableAdapter = null;
            this.tableAdapterManager.SalesHistoryTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.SupplyHistoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterPolApp.MasterPolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WarehousesTableAdapter = null;
            this.tableAdapterManager.WarehouseStockTableAdapter = null;
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.productsBindingNavigator.TabIndex = 4;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            this.productsBindingNavigator.Visible = false;
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(81, 16);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(29, 13);
            productIDLabel.TabIndex = 4;
            productIDLabel.Text = "Код:";
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(235, 13);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(281, 22);
            this.productIDTextBox.TabIndex = 5;
            // 
            // articleLabel
            // 
            articleLabel.AutoSize = true;
            articleLabel.Location = new System.Drawing.Point(81, 42);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(48, 13);
            articleLabel.TabIndex = 6;
            articleLabel.Text = "Артикл:";
            // 
            // articleTextBox
            // 
            this.articleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Article", true));
            this.articleTextBox.Location = new System.Drawing.Point(235, 39);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(281, 22);
            this.articleTextBox.TabIndex = 7;
            // 
            // productTypeLabel
            // 
            productTypeLabel.AutoSize = true;
            productTypeLabel.Location = new System.Drawing.Point(81, 68);
            productTypeLabel.Name = "productTypeLabel";
            productTypeLabel.Size = new System.Drawing.Size(30, 13);
            productTypeLabel.TabIndex = 8;
            productTypeLabel.Text = "Тип:";
            // 
            // productTypeTextBox
            // 
            this.productTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductType", true));
            this.productTypeTextBox.Location = new System.Drawing.Point(235, 65);
            this.productTypeTextBox.Name = "productTypeTextBox";
            this.productTypeTextBox.Size = new System.Drawing.Size(281, 22);
            this.productTypeTextBox.TabIndex = 9;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(81, 94);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(91, 13);
            productNameLabel.TabIndex = 10;
            productNameLabel.Text = "Наименование:";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(235, 91);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(366, 22);
            this.productNameTextBox.TabIndex = 11;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(81, 120);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Описание:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(235, 117);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(366, 22);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(81, 146);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(37, 13);
            imageLabel.TabIndex = 14;
            imageLabel.Text = "Избр.";
            // 
            // imageTextBox
            // 
            this.imageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(235, 143);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(366, 22);
            this.imageTextBox.TabIndex = 15;
            this.imageTextBox.TextChanged += new System.EventHandler(this.imageTextBox_TextChanged);
            // 
            // minPriceForPartnerLabel
            // 
            minPriceForPartnerLabel.AutoSize = true;
            minPriceForPartnerLabel.Location = new System.Drawing.Point(81, 172);
            minPriceForPartnerLabel.Name = "minPriceForPartnerLabel";
            minPriceForPartnerLabel.Size = new System.Drawing.Size(148, 13);
            minPriceForPartnerLabel.TabIndex = 16;
            minPriceForPartnerLabel.Text = "Мин. цена для партнеров:";
            // 
            // minPriceForPartnerTextBox
            // 
            this.minPriceForPartnerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minPriceForPartnerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "MinPriceForPartner", true));
            this.minPriceForPartnerTextBox.Location = new System.Drawing.Point(235, 169);
            this.minPriceForPartnerTextBox.Name = "minPriceForPartnerTextBox";
            this.minPriceForPartnerTextBox.Size = new System.Drawing.Size(366, 22);
            this.minPriceForPartnerTextBox.TabIndex = 17;
            // 
            // packageLengthLabel
            // 
            packageLengthLabel.AutoSize = true;
            packageLengthLabel.Location = new System.Drawing.Point(81, 198);
            packageLengthLabel.Name = "packageLengthLabel";
            packageLengthLabel.Size = new System.Drawing.Size(97, 13);
            packageLengthLabel.TabIndex = 18;
            packageLengthLabel.Text = "Длина упаковки:";
            // 
            // packageLengthTextBox
            // 
            this.packageLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packageLengthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "PackageLength", true));
            this.packageLengthTextBox.Location = new System.Drawing.Point(235, 195);
            this.packageLengthTextBox.Name = "packageLengthTextBox";
            this.packageLengthTextBox.Size = new System.Drawing.Size(366, 22);
            this.packageLengthTextBox.TabIndex = 19;
            // 
            // packageWidthLabel
            // 
            packageWidthLabel.AutoSize = true;
            packageWidthLabel.Location = new System.Drawing.Point(81, 224);
            packageWidthLabel.Name = "packageWidthLabel";
            packageWidthLabel.Size = new System.Drawing.Size(114, 13);
            packageWidthLabel.TabIndex = 20;
            packageWidthLabel.Text = "Ширина упавковки:";
            // 
            // packageWidthTextBox
            // 
            this.packageWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packageWidthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "PackageWidth", true));
            this.packageWidthTextBox.Location = new System.Drawing.Point(235, 221);
            this.packageWidthTextBox.Name = "packageWidthTextBox";
            this.packageWidthTextBox.Size = new System.Drawing.Size(366, 22);
            this.packageWidthTextBox.TabIndex = 21;
            // 
            // packageHeightLabel
            // 
            packageHeightLabel.AutoSize = true;
            packageHeightLabel.Location = new System.Drawing.Point(81, 250);
            packageHeightLabel.Name = "packageHeightLabel";
            packageHeightLabel.Size = new System.Drawing.Size(100, 13);
            packageHeightLabel.TabIndex = 22;
            packageHeightLabel.Text = "Высота упаковки:";
            // 
            // packageHeightTextBox
            // 
            this.packageHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.packageHeightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "PackageHeight", true));
            this.packageHeightTextBox.Location = new System.Drawing.Point(235, 247);
            this.packageHeightTextBox.Name = "packageHeightTextBox";
            this.packageHeightTextBox.Size = new System.Drawing.Size(366, 22);
            this.packageHeightTextBox.TabIndex = 23;
            // 
            // weightWithoutPackageLabel
            // 
            weightWithoutPackageLabel.AutoSize = true;
            weightWithoutPackageLabel.Location = new System.Drawing.Point(81, 276);
            weightWithoutPackageLabel.Name = "weightWithoutPackageLabel";
            weightWithoutPackageLabel.Size = new System.Drawing.Size(101, 13);
            weightWithoutPackageLabel.TabIndex = 24;
            weightWithoutPackageLabel.Text = "Вес без упаковки:";
            // 
            // weightWithoutPackageTextBox
            // 
            this.weightWithoutPackageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightWithoutPackageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "WeightWithoutPackage", true));
            this.weightWithoutPackageTextBox.Location = new System.Drawing.Point(235, 273);
            this.weightWithoutPackageTextBox.Name = "weightWithoutPackageTextBox";
            this.weightWithoutPackageTextBox.Size = new System.Drawing.Size(366, 22);
            this.weightWithoutPackageTextBox.TabIndex = 25;
            // 
            // weightWithPackageLabel
            // 
            weightWithPackageLabel.AutoSize = true;
            weightWithPackageLabel.Location = new System.Drawing.Point(81, 302);
            weightWithPackageLabel.Name = "weightWithPackageLabel";
            weightWithPackageLabel.Size = new System.Drawing.Size(95, 13);
            weightWithPackageLabel.TabIndex = 26;
            weightWithPackageLabel.Text = "Вес с упаковкой:";
            // 
            // weightWithPackageTextBox
            // 
            this.weightWithPackageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightWithPackageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "WeightWithPackage", true));
            this.weightWithPackageTextBox.Location = new System.Drawing.Point(235, 299);
            this.weightWithPackageTextBox.Name = "weightWithPackageTextBox";
            this.weightWithPackageTextBox.Size = new System.Drawing.Size(366, 22);
            this.weightWithPackageTextBox.TabIndex = 27;
            // 
            // qualityCertificateLabel
            // 
            qualityCertificateLabel.AutoSize = true;
            qualityCertificateLabel.Location = new System.Drawing.Point(81, 328);
            qualityCertificateLabel.Name = "qualityCertificateLabel";
            qualityCertificateLabel.Size = new System.Drawing.Size(75, 13);
            qualityCertificateLabel.TabIndex = 28;
            qualityCertificateLabel.Text = "Сертификат:";
            // 
            // qualityCertificateTextBox
            // 
            this.qualityCertificateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qualityCertificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "QualityCertificate", true));
            this.qualityCertificateTextBox.Location = new System.Drawing.Point(235, 325);
            this.qualityCertificateTextBox.Name = "qualityCertificateTextBox";
            this.qualityCertificateTextBox.Size = new System.Drawing.Size(366, 22);
            this.qualityCertificateTextBox.TabIndex = 29;
            // 
            // standardNumberLabel
            // 
            standardNumberLabel.AutoSize = true;
            standardNumberLabel.Location = new System.Drawing.Point(81, 354);
            standardNumberLabel.Name = "standardNumberLabel";
            standardNumberLabel.Size = new System.Drawing.Size(103, 13);
            standardNumberLabel.TabIndex = 30;
            standardNumberLabel.Text = "Стандарт номера:";
            // 
            // standardNumberTextBox
            // 
            this.standardNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.standardNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "StandardNumber", true));
            this.standardNumberTextBox.Location = new System.Drawing.Point(235, 351);
            this.standardNumberTextBox.Name = "standardNumberTextBox";
            this.standardNumberTextBox.Size = new System.Drawing.Size(366, 22);
            this.standardNumberTextBox.TabIndex = 31;
            // 
            // productionTimeLabel
            // 
            productionTimeLabel.AutoSize = true;
            productionTimeLabel.Location = new System.Drawing.Point(81, 380);
            productionTimeLabel.Name = "productionTimeLabel";
            productionTimeLabel.Size = new System.Drawing.Size(120, 13);
            productionTimeLabel.TabIndex = 32;
            productionTimeLabel.Text = "Время производства:";
            // 
            // productionTimeTextBox
            // 
            this.productionTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productionTimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductionTime", true));
            this.productionTimeTextBox.Location = new System.Drawing.Point(235, 377);
            this.productionTimeTextBox.Name = "productionTimeTextBox";
            this.productionTimeTextBox.Size = new System.Drawing.Size(366, 22);
            this.productionTimeTextBox.TabIndex = 33;
            // 
            // productionCostLabel
            // 
            productionCostLabel.AutoSize = true;
            productionCostLabel.Location = new System.Drawing.Point(81, 406);
            productionCostLabel.Name = "productionCostLabel";
            productionCostLabel.Size = new System.Drawing.Size(144, 13);
            productionCostLabel.TabIndex = 34;
            productionCostLabel.Text = "Стоимость производства:";
            // 
            // productionCostTextBox
            // 
            this.productionCostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productionCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductionCost", true));
            this.productionCostTextBox.Location = new System.Drawing.Point(235, 403);
            this.productionCostTextBox.Name = "productionCostTextBox";
            this.productionCostTextBox.Size = new System.Drawing.Size(366, 22);
            this.productionCostTextBox.TabIndex = 35;
            // 
            // workshopNumberLabel
            // 
            workshopNumberLabel.AutoSize = true;
            workshopNumberLabel.Location = new System.Drawing.Point(81, 432);
            workshopNumberLabel.Name = "workshopNumberLabel";
            workshopNumberLabel.Size = new System.Drawing.Size(111, 13);
            workshopNumberLabel.TabIndex = 36;
            workshopNumberLabel.Text = "Номер мастерской:";
            // 
            // workshopNumberTextBox
            // 
            this.workshopNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workshopNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "WorkshopNumber", true));
            this.workshopNumberTextBox.Location = new System.Drawing.Point(235, 429);
            this.workshopNumberTextBox.Name = "workshopNumberTextBox";
            this.workshopNumberTextBox.Size = new System.Drawing.Size(366, 22);
            this.workshopNumberTextBox.TabIndex = 37;
            // 
            // productionWorkersLabel
            // 
            productionWorkersLabel.AutoSize = true;
            productionWorkersLabel.Location = new System.Drawing.Point(81, 458);
            productionWorkersLabel.Name = "productionWorkersLabel";
            productionWorkersLabel.Size = new System.Drawing.Size(57, 13);
            productionWorkersLabel.TabIndex = 38;
            productionWorkersLabel.Text = "Рабочий:";
            // 
            // productionWorkersTextBox
            // 
            this.productionWorkersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productionWorkersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductionWorkers", true));
            this.productionWorkersTextBox.Location = new System.Drawing.Point(235, 455);
            this.productionWorkersTextBox.Name = "productionWorkersTextBox";
            this.productionWorkersTextBox.Size = new System.Drawing.Size(366, 22);
            this.productionWorkersTextBox.TabIndex = 39;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::MasterPolApp.Properties.Resources.Мастер_пол;
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(64, 64);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(522, 489);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 40;
            this.btnLast.Text = ">";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(441, 489);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 41;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(360, 489);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 42;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(279, 489);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 43;
            this.btnFirst.Text = "<";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Location = new System.Drawing.Point(198, 518);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 44;
            this.btnSort.Text = "Сорт.";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(279, 518);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(360, 518);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 46;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(441, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(522, 518);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(8, 518);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(522, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(79, 75);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 50;
            this.picImage.TabStop = false;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 553);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(articleLabel);
            this.Controls.Add(this.articleTextBox);
            this.Controls.Add(productTypeLabel);
            this.Controls.Add(this.productTypeTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(minPriceForPartnerLabel);
            this.Controls.Add(this.minPriceForPartnerTextBox);
            this.Controls.Add(packageLengthLabel);
            this.Controls.Add(this.packageLengthTextBox);
            this.Controls.Add(packageWidthLabel);
            this.Controls.Add(this.packageWidthTextBox);
            this.Controls.Add(packageHeightLabel);
            this.Controls.Add(this.packageHeightTextBox);
            this.Controls.Add(weightWithoutPackageLabel);
            this.Controls.Add(this.weightWithoutPackageTextBox);
            this.Controls.Add(weightWithPackageLabel);
            this.Controls.Add(this.weightWithPackageTextBox);
            this.Controls.Add(qualityCertificateLabel);
            this.Controls.Add(this.qualityCertificateTextBox);
            this.Controls.Add(standardNumberLabel);
            this.Controls.Add(this.standardNumberTextBox);
            this.Controls.Add(productionTimeLabel);
            this.Controls.Add(this.productionTimeTextBox);
            this.Controls.Add(productionCostLabel);
            this.Controls.Add(this.productionCostTextBox);
            this.Controls.Add(workshopNumberLabel);
            this.Controls.Add(this.workshopNumberTextBox);
            this.Controls.Add(productionWorkersLabel);
            this.Controls.Add(this.productionWorkersTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Controls.Add(this.picIcon);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 592);
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукт";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picIcon;
        private MasterPolDataSet masterPolDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MasterPolDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.TextBox productTypeTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox minPriceForPartnerTextBox;
        private System.Windows.Forms.TextBox packageLengthTextBox;
        private System.Windows.Forms.TextBox packageWidthTextBox;
        private System.Windows.Forms.TextBox packageHeightTextBox;
        private System.Windows.Forms.TextBox weightWithoutPackageTextBox;
        private System.Windows.Forms.TextBox weightWithPackageTextBox;
        private System.Windows.Forms.TextBox qualityCertificateTextBox;
        private System.Windows.Forms.TextBox standardNumberTextBox;
        private System.Windows.Forms.TextBox productionTimeTextBox;
        private System.Windows.Forms.TextBox productionCostTextBox;
        private System.Windows.Forms.TextBox workshopNumberTextBox;
        private System.Windows.Forms.TextBox productionWorkersTextBox;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picImage;
    }
}