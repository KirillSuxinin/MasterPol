namespace MasterPolApp.Lenta
{
    partial class PartnersForm
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
            System.Windows.Forms.Label partnerIDLabel;
            System.Windows.Forms.Label partnerTypeLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label legalAddressLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label directorFullNameLabel;
            System.Windows.Forms.Label contactPhoneLabel;
            System.Windows.Forms.Label contactEmailLabel;
            System.Windows.Forms.Label logoLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label rubExchangeRateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnersForm));
            this.masterPolDataSet = new MasterPolApp.MasterPolDataSet();
            this.partnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnersTableAdapter = new MasterPolApp.MasterPolDataSetTableAdapters.PartnersTableAdapter();
            this.tableAdapterManager = new MasterPolApp.MasterPolDataSetTableAdapters.TableAdapterManager();
            this.partnersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.partnersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.partnerIDTextBox = new System.Windows.Forms.TextBox();
            this.partnerTypeTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.legalAddressTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.directorFullNameTextBox = new System.Windows.Forms.TextBox();
            this.contactPhoneTextBox = new System.Windows.Forms.TextBox();
            this.contactEmailTextBox = new System.Windows.Forms.TextBox();
            this.logoTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.rubExchangeRateTextBox = new System.Windows.Forms.TextBox();
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
            partnerIDLabel = new System.Windows.Forms.Label();
            partnerTypeLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            legalAddressLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            directorFullNameLabel = new System.Windows.Forms.Label();
            contactPhoneLabel = new System.Windows.Forms.Label();
            contactEmailLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            rubExchangeRateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingNavigator)).BeginInit();
            this.partnersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // partnerIDLabel
            // 
            partnerIDLabel.AutoSize = true;
            partnerIDLabel.Location = new System.Drawing.Point(81, 12);
            partnerIDLabel.Name = "partnerIDLabel";
            partnerIDLabel.Size = new System.Drawing.Size(29, 13);
            partnerIDLabel.TabIndex = 1;
            partnerIDLabel.Text = "Код:";
            // 
            // partnerTypeLabel
            // 
            partnerTypeLabel.AutoSize = true;
            partnerTypeLabel.Location = new System.Drawing.Point(81, 38);
            partnerTypeLabel.Name = "partnerTypeLabel";
            partnerTypeLabel.Size = new System.Drawing.Size(29, 13);
            partnerTypeLabel.TabIndex = 3;
            partnerTypeLabel.Text = "Тип:";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(81, 64);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(86, 13);
            companyNameLabel.TabIndex = 5;
            companyNameLabel.Text = "Наименование:";
            // 
            // legalAddressLabel
            // 
            legalAddressLabel.AutoSize = true;
            legalAddressLabel.Location = new System.Drawing.Point(81, 90);
            legalAddressLabel.Name = "legalAddressLabel";
            legalAddressLabel.Size = new System.Drawing.Size(62, 13);
            legalAddressLabel.TabIndex = 7;
            legalAddressLabel.Text = "Юр. Адрес:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Location = new System.Drawing.Point(81, 116);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(34, 13);
            iNNLabel.TabIndex = 9;
            iNNLabel.Text = "ИНН:";
            // 
            // directorFullNameLabel
            // 
            directorFullNameLabel.AutoSize = true;
            directorFullNameLabel.Location = new System.Drawing.Point(81, 142);
            directorFullNameLabel.Name = "directorFullNameLabel";
            directorFullNameLabel.Size = new System.Drawing.Size(96, 13);
            directorFullNameLabel.TabIndex = 11;
            directorFullNameLabel.Text = "ФИО Директора:";
            // 
            // contactPhoneLabel
            // 
            contactPhoneLabel.AutoSize = true;
            contactPhoneLabel.Location = new System.Drawing.Point(81, 168);
            contactPhoneLabel.Name = "contactPhoneLabel";
            contactPhoneLabel.Size = new System.Drawing.Size(55, 13);
            contactPhoneLabel.TabIndex = 13;
            contactPhoneLabel.Text = "Телефон:";
            // 
            // contactEmailLabel
            // 
            contactEmailLabel.AutoSize = true;
            contactEmailLabel.Location = new System.Drawing.Point(81, 194);
            contactEmailLabel.Name = "contactEmailLabel";
            contactEmailLabel.Size = new System.Drawing.Size(40, 13);
            contactEmailLabel.TabIndex = 15;
            contactEmailLabel.Text = "Почта:";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Location = new System.Drawing.Point(81, 220);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(35, 13);
            logoLabel.TabIndex = 17;
            logoLabel.Text = "Лого:";
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(81, 246);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(51, 13);
            ratingLabel.TabIndex = 19;
            ratingLabel.Text = "Рейтинг:";
            // 
            // rubExchangeRateLabel
            // 
            rubExchangeRateLabel.AutoSize = true;
            rubExchangeRateLabel.Location = new System.Drawing.Point(81, 272);
            rubExchangeRateLabel.Name = "rubExchangeRateLabel";
            rubExchangeRateLabel.Size = new System.Drawing.Size(98, 13);
            rubExchangeRateLabel.TabIndex = 21;
            rubExchangeRateLabel.Text = "Процента скидки:";
            // 
            // masterPolDataSet
            // 
            this.masterPolDataSet.DataSetName = "MasterPolDataSet";
            this.masterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnersBindingSource
            // 
            this.partnersBindingSource.DataMember = "Partners";
            this.partnersBindingSource.DataSource = this.masterPolDataSet;
            this.partnersBindingSource.PositionChanged += new System.EventHandler(this.partnersBindingSource_PositionChanged);
            // 
            // partnersTableAdapter
            // 
            this.partnersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PartnersTableAdapter = this.partnersTableAdapter;
            this.tableAdapterManager.ProductMaterialsTableAdapter = null;
            this.tableAdapterManager.ProductMinPriceHistoryTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProductWarehouseStockTableAdapter = null;
            this.tableAdapterManager.SalesHistoryTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.SupplyHistoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MasterPolApp.MasterPolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.WarehousesTableAdapter = null;
            this.tableAdapterManager.WarehouseStockTableAdapter = null;
            // 
            // partnersBindingNavigator
            // 
            this.partnersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partnersBindingNavigator.BindingSource = this.partnersBindingSource;
            this.partnersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partnersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partnersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partnersBindingNavigatorSaveItem});
            this.partnersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partnersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partnersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partnersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partnersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partnersBindingNavigator.Name = "partnersBindingNavigator";
            this.partnersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partnersBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.partnersBindingNavigator.TabIndex = 0;
            this.partnersBindingNavigator.Text = "bindingNavigator1";
            this.partnersBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // partnersBindingNavigatorSaveItem
            // 
            this.partnersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partnersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partnersBindingNavigatorSaveItem.Image")));
            this.partnersBindingNavigatorSaveItem.Name = "partnersBindingNavigatorSaveItem";
            this.partnersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partnersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.partnersBindingNavigatorSaveItem.Click += new System.EventHandler(this.partnersBindingNavigatorSaveItem_Click);
            // 
            // partnerIDTextBox
            // 
            this.partnerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partnerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "PartnerID", true));
            this.partnerIDTextBox.Location = new System.Drawing.Point(194, 9);
            this.partnerIDTextBox.Name = "partnerIDTextBox";
            this.partnerIDTextBox.Size = new System.Drawing.Size(299, 20);
            this.partnerIDTextBox.TabIndex = 2;
            // 
            // partnerTypeTextBox
            // 
            this.partnerTypeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partnerTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "PartnerType", true));
            this.partnerTypeTextBox.Location = new System.Drawing.Point(194, 35);
            this.partnerTypeTextBox.Name = "partnerTypeTextBox";
            this.partnerTypeTextBox.Size = new System.Drawing.Size(299, 20);
            this.partnerTypeTextBox.TabIndex = 4;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(194, 61);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(299, 20);
            this.companyNameTextBox.TabIndex = 6;
            // 
            // legalAddressTextBox
            // 
            this.legalAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.legalAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "LegalAddress", true));
            this.legalAddressTextBox.Location = new System.Drawing.Point(194, 87);
            this.legalAddressTextBox.Name = "legalAddressTextBox";
            this.legalAddressTextBox.Size = new System.Drawing.Size(407, 20);
            this.legalAddressTextBox.TabIndex = 8;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "INN", true));
            this.iNNTextBox.Location = new System.Drawing.Point(194, 113);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(407, 20);
            this.iNNTextBox.TabIndex = 10;
            // 
            // directorFullNameTextBox
            // 
            this.directorFullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directorFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "DirectorFullName", true));
            this.directorFullNameTextBox.Location = new System.Drawing.Point(194, 139);
            this.directorFullNameTextBox.Name = "directorFullNameTextBox";
            this.directorFullNameTextBox.Size = new System.Drawing.Size(407, 20);
            this.directorFullNameTextBox.TabIndex = 12;
            // 
            // contactPhoneTextBox
            // 
            this.contactPhoneTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "ContactPhone", true));
            this.contactPhoneTextBox.Location = new System.Drawing.Point(194, 165);
            this.contactPhoneTextBox.Name = "contactPhoneTextBox";
            this.contactPhoneTextBox.Size = new System.Drawing.Size(407, 20);
            this.contactPhoneTextBox.TabIndex = 14;
            // 
            // contactEmailTextBox
            // 
            this.contactEmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "ContactEmail", true));
            this.contactEmailTextBox.Location = new System.Drawing.Point(194, 191);
            this.contactEmailTextBox.Name = "contactEmailTextBox";
            this.contactEmailTextBox.Size = new System.Drawing.Size(407, 20);
            this.contactEmailTextBox.TabIndex = 16;
            // 
            // logoTextBox
            // 
            this.logoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Logo", true));
            this.logoTextBox.Location = new System.Drawing.Point(194, 217);
            this.logoTextBox.Name = "logoTextBox";
            this.logoTextBox.Size = new System.Drawing.Size(407, 20);
            this.logoTextBox.TabIndex = 18;
            this.logoTextBox.TextChanged += new System.EventHandler(this.logoTextBox_TextChanged);
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(194, 243);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(407, 20);
            this.ratingTextBox.TabIndex = 20;
            // 
            // rubExchangeRateTextBox
            // 
            this.rubExchangeRateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rubExchangeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnersBindingSource, "RubExchangeRate", true));
            this.rubExchangeRateTextBox.Location = new System.Drawing.Point(194, 269);
            this.rubExchangeRateTextBox.Name = "rubExchangeRateTextBox";
            this.rubExchangeRateTextBox.Size = new System.Drawing.Size(407, 20);
            this.rubExchangeRateTextBox.TabIndex = 22;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::MasterPolApp.Properties.Resources.Мастер_пол;
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(64, 64);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 23;
            this.picIcon.TabStop = false;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(523, 311);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 24;
            this.btnLast.Text = ">";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(442, 311);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(361, 311);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(280, 311);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 27;
            this.btnFirst.Text = "<";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Location = new System.Drawing.Point(199, 340);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 28;
            this.btnSort.Text = "Сорт.";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(280, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(361, 340);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(442, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(523, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(9, 340);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // picImage
            // 
            this.picImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picImage.Location = new System.Drawing.Point(498, 9);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(103, 72);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 34;
            this.picImage.TabStop = false;
            // 
            // PartnersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 376);
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
            this.Controls.Add(this.picIcon);
            this.Controls.Add(partnerIDLabel);
            this.Controls.Add(this.partnerIDTextBox);
            this.Controls.Add(partnerTypeLabel);
            this.Controls.Add(this.partnerTypeTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(legalAddressLabel);
            this.Controls.Add(this.legalAddressTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(directorFullNameLabel);
            this.Controls.Add(this.directorFullNameTextBox);
            this.Controls.Add(contactPhoneLabel);
            this.Controls.Add(this.contactPhoneTextBox);
            this.Controls.Add(contactEmailLabel);
            this.Controls.Add(this.contactEmailTextBox);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.logoTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(rubExchangeRateLabel);
            this.Controls.Add(this.rubExchangeRateTextBox);
            this.Controls.Add(this.partnersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 415);
            this.Name = "PartnersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Партнёры";
            this.Load += new System.EventHandler(this.PartnersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnersBindingNavigator)).EndInit();
            this.partnersBindingNavigator.ResumeLayout(false);
            this.partnersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasterPolDataSet masterPolDataSet;
        private System.Windows.Forms.BindingSource partnersBindingSource;
        private MasterPolDataSetTableAdapters.PartnersTableAdapter partnersTableAdapter;
        private MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partnersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton partnersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox partnerIDTextBox;
        private System.Windows.Forms.TextBox partnerTypeTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox legalAddressTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox directorFullNameTextBox;
        private System.Windows.Forms.TextBox contactPhoneTextBox;
        private System.Windows.Forms.TextBox contactEmailTextBox;
        private System.Windows.Forms.TextBox logoTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox rubExchangeRateTextBox;
        private System.Windows.Forms.PictureBox picIcon;
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