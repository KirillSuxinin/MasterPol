namespace MasterPolApp.Lenta
{
    partial class PartnerRatingHistoryForm
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
            System.Windows.Forms.Label ratingHistoryIDLabel;
            System.Windows.Forms.Label partnerIDLabel;
            System.Windows.Forms.Label managerIDLabel;
            System.Windows.Forms.Label ratingChangeDateLabel;
            System.Windows.Forms.Label oldRatingLabel;
            System.Windows.Forms.Label newRatingLabel;
            System.Windows.Forms.Label reasonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartnerRatingHistoryForm));
            this.masterPolDataSet = new MasterPolApp.MasterPolDataSet();
            this.partnerRatingHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerRatingHistoryTableAdapter = new MasterPolApp.MasterPolDataSetTableAdapters.PartnerRatingHistoryTableAdapter();
            this.tableAdapterManager = new MasterPolApp.MasterPolDataSetTableAdapters.TableAdapterManager();
            this.partnerRatingHistoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ratingHistoryIDTextBox = new System.Windows.Forms.TextBox();
            this.partnerIDTextBox = new System.Windows.Forms.TextBox();
            this.managerIDTextBox = new System.Windows.Forms.TextBox();
            this.ratingChangeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.oldRatingTextBox = new System.Windows.Forms.TextBox();
            this.newRatingTextBox = new System.Windows.Forms.TextBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.partnerRatingHistoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
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
            ratingHistoryIDLabel = new System.Windows.Forms.Label();
            partnerIDLabel = new System.Windows.Forms.Label();
            managerIDLabel = new System.Windows.Forms.Label();
            ratingChangeDateLabel = new System.Windows.Forms.Label();
            oldRatingLabel = new System.Windows.Forms.Label();
            newRatingLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerRatingHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerRatingHistoryBindingNavigator)).BeginInit();
            this.partnerRatingHistoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // masterPolDataSet
            // 
            this.masterPolDataSet.DataSetName = "MasterPolDataSet";
            this.masterPolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partnerRatingHistoryBindingSource
            // 
            this.partnerRatingHistoryBindingSource.DataMember = "PartnerRatingHistory";
            this.partnerRatingHistoryBindingSource.DataSource = this.masterPolDataSet;
            // 
            // partnerRatingHistoryTableAdapter
            // 
            this.partnerRatingHistoryTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PartnerRatingHistoryTableAdapter = this.partnerRatingHistoryTableAdapter;
            this.tableAdapterManager.PartnerSalesLocationsTableAdapter = null;
            this.tableAdapterManager.PartnersTableAdapter = null;
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
            // partnerRatingHistoryBindingNavigator
            // 
            this.partnerRatingHistoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.partnerRatingHistoryBindingNavigator.BindingSource = this.partnerRatingHistoryBindingSource;
            this.partnerRatingHistoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.partnerRatingHistoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.partnerRatingHistoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.partnerRatingHistoryBindingNavigatorSaveItem});
            this.partnerRatingHistoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.partnerRatingHistoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.partnerRatingHistoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.partnerRatingHistoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.partnerRatingHistoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.partnerRatingHistoryBindingNavigator.Name = "partnerRatingHistoryBindingNavigator";
            this.partnerRatingHistoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.partnerRatingHistoryBindingNavigator.Size = new System.Drawing.Size(613, 25);
            this.partnerRatingHistoryBindingNavigator.TabIndex = 0;
            this.partnerRatingHistoryBindingNavigator.Text = "bindingNavigator1";
            this.partnerRatingHistoryBindingNavigator.Visible = false;
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
            // ratingHistoryIDLabel
            // 
            ratingHistoryIDLabel.AutoSize = true;
            ratingHistoryIDLabel.Location = new System.Drawing.Point(81, 14);
            ratingHistoryIDLabel.Name = "ratingHistoryIDLabel";
            ratingHistoryIDLabel.Size = new System.Drawing.Size(29, 13);
            ratingHistoryIDLabel.TabIndex = 1;
            ratingHistoryIDLabel.Text = "Код:";
            // 
            // ratingHistoryIDTextBox
            // 
            this.ratingHistoryIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingHistoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerRatingHistoryBindingSource, "RatingHistoryID", true));
            this.ratingHistoryIDTextBox.Location = new System.Drawing.Point(201, 11);
            this.ratingHistoryIDTextBox.Name = "ratingHistoryIDTextBox";
            this.ratingHistoryIDTextBox.Size = new System.Drawing.Size(400, 22);
            this.ratingHistoryIDTextBox.TabIndex = 2;
            // 
            // partnerIDLabel
            // 
            partnerIDLabel.AutoSize = true;
            partnerIDLabel.Location = new System.Drawing.Point(81, 42);
            partnerIDLabel.Name = "partnerIDLabel";
            partnerIDLabel.Size = new System.Drawing.Size(83, 13);
            partnerIDLabel.TabIndex = 3;
            partnerIDLabel.Text = "Код партнера:";
            // 
            // partnerIDTextBox
            // 
            this.partnerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partnerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerRatingHistoryBindingSource, "PartnerID", true));
            this.partnerIDTextBox.Location = new System.Drawing.Point(201, 39);
            this.partnerIDTextBox.Name = "partnerIDTextBox";
            this.partnerIDTextBox.Size = new System.Drawing.Size(400, 22);
            this.partnerIDTextBox.TabIndex = 4;
            // 
            // managerIDLabel
            // 
            managerIDLabel.AutoSize = true;
            managerIDLabel.Location = new System.Drawing.Point(81, 70);
            managerIDLabel.Name = "managerIDLabel";
            managerIDLabel.Size = new System.Drawing.Size(93, 13);
            managerIDLabel.TabIndex = 5;
            managerIDLabel.Text = "Код менеджера:";
            // 
            // managerIDTextBox
            // 
            this.managerIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.managerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerRatingHistoryBindingSource, "ManagerID", true));
            this.managerIDTextBox.Location = new System.Drawing.Point(201, 67);
            this.managerIDTextBox.Name = "managerIDTextBox";
            this.managerIDTextBox.Size = new System.Drawing.Size(400, 22);
            this.managerIDTextBox.TabIndex = 6;
            // 
            // ratingChangeDateLabel
            // 
            ratingChangeDateLabel.AutoSize = true;
            ratingChangeDateLabel.Location = new System.Drawing.Point(81, 99);
            ratingChangeDateLabel.Name = "ratingChangeDateLabel";
            ratingChangeDateLabel.Size = new System.Drawing.Size(97, 13);
            ratingChangeDateLabel.TabIndex = 7;
            ratingChangeDateLabel.Text = "Дата изменения:";
            // 
            // ratingChangeDateDateTimePicker
            // 
            this.ratingChangeDateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingChangeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partnerRatingHistoryBindingSource, "RatingChangeDate", true));
            this.ratingChangeDateDateTimePicker.Location = new System.Drawing.Point(201, 95);
            this.ratingChangeDateDateTimePicker.Name = "ratingChangeDateDateTimePicker";
            this.ratingChangeDateDateTimePicker.Size = new System.Drawing.Size(400, 22);
            this.ratingChangeDateDateTimePicker.TabIndex = 8;
            // 
            // oldRatingLabel
            // 
            oldRatingLabel.AutoSize = true;
            oldRatingLabel.Location = new System.Drawing.Point(81, 126);
            oldRatingLabel.Name = "oldRatingLabel";
            oldRatingLabel.Size = new System.Drawing.Size(97, 13);
            oldRatingLabel.TabIndex = 9;
            oldRatingLabel.Text = "Старый рейтинг:";
            // 
            // oldRatingTextBox
            // 
            this.oldRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oldRatingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerRatingHistoryBindingSource, "OldRating", true));
            this.oldRatingTextBox.Location = new System.Drawing.Point(201, 123);
            this.oldRatingTextBox.Name = "oldRatingTextBox";
            this.oldRatingTextBox.Size = new System.Drawing.Size(400, 22);
            this.oldRatingTextBox.TabIndex = 10;
            // 
            // newRatingLabel
            // 
            newRatingLabel.AutoSize = true;
            newRatingLabel.Location = new System.Drawing.Point(81, 154);
            newRatingLabel.Name = "newRatingLabel";
            newRatingLabel.Size = new System.Drawing.Size(93, 13);
            newRatingLabel.TabIndex = 11;
            newRatingLabel.Text = "Новый рейтинг:";
            // 
            // newRatingTextBox
            // 
            this.newRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newRatingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerRatingHistoryBindingSource, "NewRating", true));
            this.newRatingTextBox.Location = new System.Drawing.Point(201, 151);
            this.newRatingTextBox.Name = "newRatingTextBox";
            this.newRatingTextBox.Size = new System.Drawing.Size(400, 22);
            this.newRatingTextBox.TabIndex = 12;
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(81, 182);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(59, 13);
            reasonLabel.TabIndex = 13;
            reasonLabel.Text = "Причина:";
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partnerRatingHistoryBindingSource, "Reason", true));
            this.reasonTextBox.Location = new System.Drawing.Point(201, 179);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(400, 22);
            this.reasonTextBox.TabIndex = 14;
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
            // partnerRatingHistoryBindingNavigatorSaveItem
            // 
            this.partnerRatingHistoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.partnerRatingHistoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("partnerRatingHistoryBindingNavigatorSaveItem.Image")));
            this.partnerRatingHistoryBindingNavigatorSaveItem.Name = "partnerRatingHistoryBindingNavigatorSaveItem";
            this.partnerRatingHistoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.partnerRatingHistoryBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.partnerRatingHistoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.partnerRatingHistoryBindingNavigatorSaveItem_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::MasterPolApp.Properties.Resources.Мастер_пол;
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(64, 64);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 15;
            this.picIcon.TabStop = false;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(526, 246);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 23);
            this.btnLast.TabIndex = 16;
            this.btnLast.Text = ">";
            this.btnLast.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(445, 246);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(364, 246);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 18;
            this.btnPrev.Text = "<<";
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(283, 246);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 23);
            this.btnFirst.TabIndex = 19;
            this.btnFirst.Text = "<";
            this.btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnSort
            // 
            this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Location = new System.Drawing.Point(202, 275);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 20;
            this.btnSort.Text = "Сорт.";
            this.btnSort.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(283, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(364, 275);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(445, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(526, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(186)))), ((int)(((byte)(128)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(12, 275);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // PartnerRatingHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(613, 310);
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
            this.Controls.Add(ratingHistoryIDLabel);
            this.Controls.Add(this.ratingHistoryIDTextBox);
            this.Controls.Add(partnerIDLabel);
            this.Controls.Add(this.partnerIDTextBox);
            this.Controls.Add(managerIDLabel);
            this.Controls.Add(this.managerIDTextBox);
            this.Controls.Add(ratingChangeDateLabel);
            this.Controls.Add(this.ratingChangeDateDateTimePicker);
            this.Controls.Add(oldRatingLabel);
            this.Controls.Add(this.oldRatingTextBox);
            this.Controls.Add(newRatingLabel);
            this.Controls.Add(this.newRatingTextBox);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.partnerRatingHistoryBindingNavigator);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(629, 319);
            this.Name = "PartnerRatingHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История рейтинга партнера";
            this.Load += new System.EventHandler(this.PartnerRatingHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterPolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerRatingHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerRatingHistoryBindingNavigator)).EndInit();
            this.partnerRatingHistoryBindingNavigator.ResumeLayout(false);
            this.partnerRatingHistoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MasterPolDataSet masterPolDataSet;
        private System.Windows.Forms.BindingSource partnerRatingHistoryBindingSource;
        private MasterPolDataSetTableAdapters.PartnerRatingHistoryTableAdapter partnerRatingHistoryTableAdapter;
        private MasterPolDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator partnerRatingHistoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton partnerRatingHistoryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ratingHistoryIDTextBox;
        private System.Windows.Forms.TextBox partnerIDTextBox;
        private System.Windows.Forms.TextBox managerIDTextBox;
        private System.Windows.Forms.DateTimePicker ratingChangeDateDateTimePicker;
        private System.Windows.Forms.TextBox oldRatingTextBox;
        private System.Windows.Forms.TextBox newRatingTextBox;
        private System.Windows.Forms.TextBox reasonTextBox;
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
    }
}