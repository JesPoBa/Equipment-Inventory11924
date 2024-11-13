namespace WindowsFormsApp1
{
    partial class frm_InventoryItems
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
            this.label_Dashboard = new System.Windows.Forms.Label();
            this.btn_rentItem = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.dgv_InventoryList = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblEquipmentItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentItemDBDataSet = new WindowsFormsApp1.EquipmentItemDBDataSet();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn_AddNewItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_RentItems = new System.Windows.Forms.DataGridView();
            this.tblRentItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_ReturnedItems = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tblReturnedItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEquipmentItemsTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblEquipmentItemsTableAdapter();
            this.tblRentItemsTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblRentItemsTableAdapter();
            this.tblReturnedItemsTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblReturnedItemsTableAdapter();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_SearchRentItems = new System.Windows.Forms.TextBox();
            this.btn_SearchRentItems = new System.Windows.Forms.Button();
            this.btn_TransferToReturned = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InventoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReturnedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReturnedItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Dashboard
            // 
            this.label_Dashboard.AutoSize = true;
            this.label_Dashboard.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label_Dashboard.ForeColor = System.Drawing.Color.Black;
            this.label_Dashboard.Location = new System.Drawing.Point(99, 23);
            this.label_Dashboard.Name = "label_Dashboard";
            this.label_Dashboard.Size = new System.Drawing.Size(166, 30);
            this.label_Dashboard.TabIndex = 1;
            this.label_Dashboard.Text = "Inventory List";
            this.label_Dashboard.Click += new System.EventHandler(this.label_Dashboard_Click);
            // 
            // btn_rentItem
            // 
            this.btn_rentItem.BackColor = System.Drawing.SystemColors.Control;
            this.btn_rentItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rentItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_rentItem.FlatAppearance.BorderSize = 2;
            this.btn_rentItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rentItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rentItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_rentItem.Image = global::WindowsFormsApp1.Properties.Resources.return_icon_24;
            this.btn_rentItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rentItem.Location = new System.Drawing.Point(1595, 94);
            this.btn_rentItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_rentItem.Name = "btn_rentItem";
            this.btn_rentItem.Size = new System.Drawing.Size(129, 39);
            this.btn_rentItem.TabIndex = 10;
            this.btn_rentItem.Text = "     Rent";
            this.btn_rentItem.UseVisualStyleBackColor = false;
            this.btn_rentItem.Click += new System.EventHandler(this.btn_rentItem_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.White;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(173, 101);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(309, 31);
            this.txt_Search.TabIndex = 7;
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // dgv_InventoryList
            // 
            this.dgv_InventoryList.AllowUserToAddRows = false;
            this.dgv_InventoryList.AllowUserToDeleteRows = false;
            this.dgv_InventoryList.AutoGenerateColumns = false;
            this.dgv_InventoryList.BackgroundColor = System.Drawing.Color.Azure;
            this.dgv_InventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InventoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datePurchasedDataGridViewTextBoxColumn,
            this.serialNoDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dgv_InventoryList.DataSource = this.tblEquipmentItemsBindingSource;
            this.dgv_InventoryList.Location = new System.Drawing.Point(173, 139);
            this.dgv_InventoryList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_InventoryList.Name = "dgv_InventoryList";
            this.dgv_InventoryList.ReadOnly = true;
            this.dgv_InventoryList.RowHeadersWidth = 51;
            this.dgv_InventoryList.RowTemplate.Height = 24;
            this.dgv_InventoryList.Size = new System.Drawing.Size(1551, 210);
            this.dgv_InventoryList.TabIndex = 11;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // datePurchasedDataGridViewTextBoxColumn
            // 
            this.datePurchasedDataGridViewTextBoxColumn.DataPropertyName = "DatePurchased";
            this.datePurchasedDataGridViewTextBoxColumn.HeaderText = "DatePurchased";
            this.datePurchasedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datePurchasedDataGridViewTextBoxColumn.Name = "datePurchasedDataGridViewTextBoxColumn";
            this.datePurchasedDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePurchasedDataGridViewTextBoxColumn.Width = 125;
            // 
            // serialNoDataGridViewTextBoxColumn
            // 
            this.serialNoDataGridViewTextBoxColumn.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.HeaderText = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serialNoDataGridViewTextBoxColumn.Name = "serialNoDataGridViewTextBoxColumn";
            this.serialNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.serialNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.MinimumWidth = 6;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 125;
            // 
            // tblEquipmentItemsBindingSource
            // 
            this.tblEquipmentItemsBindingSource.DataMember = "TblEquipmentItems";
            this.tblEquipmentItemsBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // equipmentItemDBDataSet
            // 
            this.equipmentItemDBDataSet.DataSetName = "EquipmentItemDBDataSet";
            this.equipmentItemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1619, 11);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 39);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_AddNewItem
            // 
            this.btn_AddNewItem.BackColor = System.Drawing.Color.Honeydew;
            this.btn_AddNewItem.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_AddNewItem.FlatAppearance.BorderSize = 2;
            this.btn_AddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddNewItem.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddNewItem.Image = global::WindowsFormsApp1.Properties.Resources.add_icon_1;
            this.btn_AddNewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddNewItem.Location = new System.Drawing.Point(1465, 94);
            this.btn_AddNewItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddNewItem.Name = "btn_AddNewItem";
            this.btn_AddNewItem.Size = new System.Drawing.Size(107, 39);
            this.btn_AddNewItem.TabIndex = 9;
            this.btn_AddNewItem.Text = "   New";
            this.btn_AddNewItem.UseVisualStyleBackColor = false;
            this.btn_AddNewItem.Click += new System.EventHandler(this.btn_AddNewItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(99, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Rented List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_RentItems
            // 
            this.dgv_RentItems.AllowUserToAddRows = false;
            this.dgv_RentItems.AllowUserToDeleteRows = false;
            this.dgv_RentItems.AutoGenerateColumns = false;
            this.dgv_RentItems.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgv_RentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ItemID,
            this.ItemName,
            this.Category,
            this.Description,
            this.Condition,
            this.Status,
            this.SerialNo,
            this.RentDate,
            this.ReturnDated,
            this.Quantity,
            this.Cost,
            this.Image,
            this.CustomerName});
            this.dgv_RentItems.DataSource = this.tblRentItemsBindingSource;
            this.dgv_RentItems.Location = new System.Drawing.Point(173, 446);
            this.dgv_RentItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_RentItems.Name = "dgv_RentItems";
            this.dgv_RentItems.RowHeadersWidth = 51;
            this.dgv_RentItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RentItems.Size = new System.Drawing.Size(1551, 255);
            this.dgv_RentItems.TabIndex = 14;
            // 
            // tblRentItemsBindingSource
            // 
            this.tblRentItemsBindingSource.DataMember = "TblRentItems";
            this.tblRentItemsBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(99, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 30);
            this.label2.TabIndex = 15;
            this.label2.Text = "Returned Item";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_ReturnedItems
            // 
            this.dgv_ReturnedItems.AllowUserToAddRows = false;
            this.dgv_ReturnedItems.AllowUserToDeleteRows = false;
            this.dgv_ReturnedItems.AutoGenerateColumns = false;
            this.dgv_ReturnedItems.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgv_ReturnedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReturnedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn2,
            this.itemNameDataGridViewTextBoxColumn2,
            this.categoryDataGridViewTextBoxColumn2,
            this.descriptionDataGridViewTextBoxColumn2,
            this.conditionDataGridViewTextBoxColumn2,
            this.statusDataGridViewTextBoxColumn2,
            this.serialNoDataGridViewTextBoxColumn2,
            this.quantityDataGridViewTextBoxColumn2,
            this.rentDateDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn2,
            this.imageDataGridViewImageColumn1});
            this.dgv_ReturnedItems.DataSource = this.tblReturnedItemsBindingSource;
            this.dgv_ReturnedItems.Location = new System.Drawing.Point(173, 748);
            this.dgv_ReturnedItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ReturnedItems.Name = "dgv_ReturnedItems";
            this.dgv_ReturnedItems.ReadOnly = true;
            this.dgv_ReturnedItems.RowHeadersWidth = 51;
            this.dgv_ReturnedItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ReturnedItems.Size = new System.Drawing.Size(1551, 262);
            this.dgv_ReturnedItems.TabIndex = 16;
            // 
            // itemIDDataGridViewTextBoxColumn2
            // 
            this.itemIDDataGridViewTextBoxColumn2.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn2.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn2.Name = "itemIDDataGridViewTextBoxColumn2";
            this.itemIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn2
            // 
            this.itemNameDataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn2.Name = "itemNameDataGridViewTextBoxColumn2";
            this.itemNameDataGridViewTextBoxColumn2.ReadOnly = true;
            this.itemNameDataGridViewTextBoxColumn2.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn2
            // 
            this.categoryDataGridViewTextBoxColumn2.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn2.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn2.Name = "categoryDataGridViewTextBoxColumn2";
            this.categoryDataGridViewTextBoxColumn2.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn2.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn2
            // 
            this.descriptionDataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn2.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn2.Name = "descriptionDataGridViewTextBoxColumn2";
            this.descriptionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn2.Width = 125;
            // 
            // conditionDataGridViewTextBoxColumn2
            // 
            this.conditionDataGridViewTextBoxColumn2.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn2.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn2.Name = "conditionDataGridViewTextBoxColumn2";
            this.conditionDataGridViewTextBoxColumn2.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn2.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn2
            // 
            this.statusDataGridViewTextBoxColumn2.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn2.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn2.Name = "statusDataGridViewTextBoxColumn2";
            this.statusDataGridViewTextBoxColumn2.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn2.Visible = false;
            this.statusDataGridViewTextBoxColumn2.Width = 125;
            // 
            // serialNoDataGridViewTextBoxColumn2
            // 
            this.serialNoDataGridViewTextBoxColumn2.DataPropertyName = "SerialNo";
            this.serialNoDataGridViewTextBoxColumn2.HeaderText = "Serial No.";
            this.serialNoDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.serialNoDataGridViewTextBoxColumn2.Name = "serialNoDataGridViewTextBoxColumn2";
            this.serialNoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.serialNoDataGridViewTextBoxColumn2.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn2
            // 
            this.quantityDataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn2.Name = "quantityDataGridViewTextBoxColumn2";
            this.quantityDataGridViewTextBoxColumn2.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn2.Width = 125;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "Rent Date";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "Return Date";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn2
            // 
            this.costDataGridViewTextBoxColumn2.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn2.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn2.Name = "costDataGridViewTextBoxColumn2";
            this.costDataGridViewTextBoxColumn2.ReadOnly = true;
            this.costDataGridViewTextBoxColumn2.Width = 125;
            // 
            // imageDataGridViewImageColumn1
            // 
            this.imageDataGridViewImageColumn1.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn1.HeaderText = "Image";
            this.imageDataGridViewImageColumn1.MinimumWidth = 6;
            this.imageDataGridViewImageColumn1.Name = "imageDataGridViewImageColumn1";
            this.imageDataGridViewImageColumn1.ReadOnly = true;
            this.imageDataGridViewImageColumn1.Width = 125;
            // 
            // tblReturnedItemsBindingSource
            // 
            this.tblReturnedItemsBindingSource.DataMember = "TblReturnedItems";
            this.tblReturnedItemsBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // tblEquipmentItemsTableAdapter
            // 
            this.tblEquipmentItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tblRentItemsTableAdapter
            // 
            this.tblRentItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tblReturnedItemsTableAdapter
            // 
            this.tblReturnedItemsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.search_icon_black_24;
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Search.Location = new System.Drawing.Point(485, 101);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(39, 30);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_SearchRentItems
            // 
            this.txt_SearchRentItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SearchRentItems.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_SearchRentItems.Location = new System.Drawing.Point(175, 409);
            this.txt_SearchRentItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchRentItems.Name = "txt_SearchRentItems";
            this.txt_SearchRentItems.Size = new System.Drawing.Size(309, 31);
            this.txt_SearchRentItems.TabIndex = 18;
            this.txt_SearchRentItems.TextChanged += new System.EventHandler(this.txt_SearchRentItems_TextChanged);
            this.txt_SearchRentItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SearchRentItems_KeyUp);
            // 
            // btn_SearchRentItems
            // 
            this.btn_SearchRentItems.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.search_icon_black_24;
            this.btn_SearchRentItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_SearchRentItems.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_SearchRentItems.FlatAppearance.BorderSize = 0;
            this.btn_SearchRentItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchRentItems.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_SearchRentItems.Location = new System.Drawing.Point(487, 409);
            this.btn_SearchRentItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SearchRentItems.Name = "btn_SearchRentItems";
            this.btn_SearchRentItems.Size = new System.Drawing.Size(39, 30);
            this.btn_SearchRentItems.TabIndex = 19;
            this.btn_SearchRentItems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_SearchRentItems.UseVisualStyleBackColor = true;
            this.btn_SearchRentItems.Click += new System.EventHandler(this.btn_SearchRentItems_Click);
            // 
            // btn_TransferToReturned
            // 
            this.btn_TransferToReturned.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TransferToReturned.Location = new System.Drawing.Point(1617, 399);
            this.btn_TransferToReturned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TransferToReturned.Name = "btn_TransferToReturned";
            this.btn_TransferToReturned.Size = new System.Drawing.Size(107, 39);
            this.btn_TransferToReturned.TabIndex = 20;
            this.btn_TransferToReturned.Text = "Return";
            this.btn_TransferToReturned.UseVisualStyleBackColor = true;
            this.btn_TransferToReturned.Click += new System.EventHandler(this.btn_TransferToReturned_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(772, 1077);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "label3";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Rent ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 4;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 8;
            this.ItemID.Name = "ItemID";
            this.ItemID.Width = 77;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // Condition
            // 
            this.Condition.DataPropertyName = "Condition";
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 6;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            this.Condition.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            this.Status.Width = 125;
            // 
            // SerialNo
            // 
            this.SerialNo.DataPropertyName = "SerialNo";
            this.SerialNo.HeaderText = "Serial No.";
            this.SerialNo.MinimumWidth = 6;
            this.SerialNo.Name = "SerialNo";
            this.SerialNo.ReadOnly = true;
            this.SerialNo.Width = 125;
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "RentDate";
            this.RentDate.HeaderText = "RentDate";
            this.RentDate.MinimumWidth = 6;
            this.RentDate.Name = "RentDate";
            this.RentDate.ReadOnly = true;
            this.RentDate.Width = 125;
            // 
            // ReturnDated
            // 
            this.ReturnDated.DataPropertyName = "ReturnDated";
            this.ReturnDated.HeaderText = "ReturnDated";
            this.ReturnDated.MinimumWidth = 6;
            this.ReturnDated.Name = "ReturnDated";
            this.ReturnDated.ReadOnly = true;
            this.ReturnDated.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Cost
            // 
            this.Cost.DataPropertyName = "Cost";
            this.Cost.HeaderText = "Cost";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 125;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 125;
            // 
            // frm_InventoryItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1731, 1102);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_TransferToReturned);
            this.Controls.Add(this.btn_SearchRentItems);
            this.Controls.Add(this.txt_SearchRentItems);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.dgv_ReturnedItems);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_RentItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgv_InventoryList);
            this.Controls.Add(this.btn_rentItem);
            this.Controls.Add(this.btn_AddNewItem);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.label_Dashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_InventoryItems";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory_Items";
            this.Load += new System.EventHandler(this.frm_InventoryItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InventoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRentItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReturnedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblReturnedItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Dashboard;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_AddNewItem;
        private System.Windows.Forms.Button btn_rentItem;
        private System.Windows.Forms.DataGridView dgv_InventoryList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_RentItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_ReturnedItems;
        private EquipmentItemDBDataSet equipmentItemDBDataSet;
        private System.Windows.Forms.BindingSource tblEquipmentItemsBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblEquipmentItemsTableAdapter tblEquipmentItemsTableAdapter;
        private System.Windows.Forms.BindingSource tblRentItemsBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblRentItemsTableAdapter tblRentItemsTableAdapter;
        private System.Windows.Forms.BindingSource tblReturnedItemsBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblReturnedItemsTableAdapter tblReturnedItemsTableAdapter;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_SearchRentItems;
        private System.Windows.Forms.Button btn_SearchRentItems;
        private System.Windows.Forms.Button btn_TransferToReturned;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
    }
}