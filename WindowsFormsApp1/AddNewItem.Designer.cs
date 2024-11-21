namespace WindowsFormsApp1.Inventory_Folder
{
    partial class frm_AddNewItem
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
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label datePurchasedLabel;
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label imageLabel;
            this.btn_SaveItem = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tblEquipmentItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentItemDBDataSet = new WindowsFormsApp1.EquipmentItemDBDataSet();
            this.tb_ItemID = new System.Windows.Forms.TextBox();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.cb_Condition = new System.Windows.Forms.ComboBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.dateTP_DatePurchased = new System.Windows.Forms.DateTimePicker();
            this.tb_SerialNumber = new System.Windows.Forms.TextBox();
            this.NumUD_Quantity = new System.Windows.Forms.NumericUpDown();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.btn_BrowseImage = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.tblEquipmentItemsTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblEquipmentItemsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TableAdapterManager();
            this.tblCategoryTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblCategoryTableAdapter();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            itemIDLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            datePurchasedLabel = new System.Windows.Forms.Label();
            serialNoLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(101, 103);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(51, 16);
            itemIDLabel.TabIndex = 9;
            itemIDLabel.Text = "Item ID:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(77, 138);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(75, 16);
            itemNameLabel.TabIndex = 10;
            itemNameLabel.Text = "Item Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(87, 178);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(65, 16);
            categoryLabel.TabIndex = 11;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(74, 222);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(78, 16);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(86, 318);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(66, 16);
            conditionLabel.TabIndex = 13;
            conditionLabel.Text = "Condition:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(105, 357);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(47, 16);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "Status:";
            statusLabel.Visible = false;
            // 
            // datePurchasedLabel
            // 
            datePurchasedLabel.AutoSize = true;
            datePurchasedLabel.Location = new System.Drawing.Point(478, 102);
            datePurchasedLabel.Name = "datePurchasedLabel";
            datePurchasedLabel.Size = new System.Drawing.Size(107, 16);
            datePurchasedLabel.TabIndex = 15;
            datePurchasedLabel.Text = "Date Purchased:";
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Location = new System.Drawing.Point(455, 141);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(130, 16);
            serialNoLabel.TabIndex = 17;
            serialNoLabel.Text = "Serial No. (Optional):";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(527, 176);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(58, 16);
            quantityLabel.TabIndex = 19;
            quantityLabel.Text = "Quantity:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(548, 213);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(37, 16);
            costLabel.TabIndex = 21;
            costLabel.Text = "Cost:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(537, 245);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(48, 16);
            imageLabel.TabIndex = 23;
            imageLabel.Text = "Image:";
            // 
            // btn_SaveItem
            // 
            this.btn_SaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(223)))), ((int)(((byte)(177)))));
            this.btn_SaveItem.FlatAppearance.BorderSize = 0;
            this.btn_SaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveItem.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveItem.Location = new System.Drawing.Point(595, 427);
            this.btn_SaveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SaveItem.Name = "btn_SaveItem";
            this.btn_SaveItem.Size = new System.Drawing.Size(123, 32);
            this.btn_SaveItem.TabIndex = 4;
            this.btn_SaveItem.Text = "Save Item";
            this.btn_SaveItem.UseVisualStyleBackColor = false;
            this.btn_SaveItem.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(223)))), ((int)(((byte)(177)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(743, 427);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(123, 32);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
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
            // tb_ItemID
            // 
            this.tb_ItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "ItemID", true));
            this.tb_ItemID.Location = new System.Drawing.Point(163, 101);
            this.tb_ItemID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ItemID.Name = "tb_ItemID";
            this.tb_ItemID.Size = new System.Drawing.Size(252, 22);
            this.tb_ItemID.TabIndex = 10;
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "ItemName", true));
            this.tb_ItemName.Location = new System.Drawing.Point(163, 135);
            this.tb_ItemName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(252, 22);
            this.tb_ItemName.TabIndex = 11;
            // 
            // cb_Category
            // 
            this.cb_Category.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Category", true));
            this.cb_Category.DataSource = this.tblCategoryBindingSource;
            this.cb_Category.DisplayMember = "Category";
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(163, 175);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(252, 24);
            this.cb_Category.TabIndex = 12;
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "TblCategory";
            this.tblCategoryBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // tb_Description
            // 
            this.tb_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Description", true));
            this.tb_Description.Location = new System.Drawing.Point(163, 218);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(252, 86);
            this.tb_Description.TabIndex = 13;
            // 
            // cb_Condition
            // 
            this.cb_Condition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Condition", true));
            this.cb_Condition.FormattingEnabled = true;
            this.cb_Condition.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Damaged"});
            this.cb_Condition.Location = new System.Drawing.Point(163, 315);
            this.cb_Condition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Condition.Name = "cb_Condition";
            this.cb_Condition.Size = new System.Drawing.Size(252, 24);
            this.cb_Condition.TabIndex = 14;
            // 
            // cb_Status
            // 
            this.cb_Status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Status", true));
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Available",
            "Checked Out",
            "Under Maintenance"});
            this.cb_Status.Location = new System.Drawing.Point(163, 354);
            this.cb_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(252, 24);
            this.cb_Status.TabIndex = 15;
            this.cb_Status.Visible = false;
            // 
            // dateTP_DatePurchased
            // 
            this.dateTP_DatePurchased.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblEquipmentItemsBindingSource, "DatePurchased", true));
            this.dateTP_DatePurchased.Location = new System.Drawing.Point(599, 102);
            this.dateTP_DatePurchased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTP_DatePurchased.Name = "dateTP_DatePurchased";
            this.dateTP_DatePurchased.Size = new System.Drawing.Size(251, 22);
            this.dateTP_DatePurchased.TabIndex = 16;
            // 
            // tb_SerialNumber
            // 
            this.tb_SerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "SerialNo", true));
            this.tb_SerialNumber.Location = new System.Drawing.Point(599, 139);
            this.tb_SerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_SerialNumber.Name = "tb_SerialNumber";
            this.tb_SerialNumber.Size = new System.Drawing.Size(251, 22);
            this.tb_SerialNumber.TabIndex = 18;
            // 
            // NumUD_Quantity
            // 
            this.NumUD_Quantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblEquipmentItemsBindingSource, "Quantity", true));
            this.NumUD_Quantity.Location = new System.Drawing.Point(599, 174);
            this.NumUD_Quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumUD_Quantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumUD_Quantity.Name = "NumUD_Quantity";
            this.NumUD_Quantity.Size = new System.Drawing.Size(251, 22);
            this.NumUD_Quantity.TabIndex = 20;
            // 
            // tb_Cost
            // 
            this.tb_Cost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Cost", true));
            this.tb_Cost.Location = new System.Drawing.Point(597, 209);
            this.tb_Cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(251, 22);
            this.tb_Cost.TabIndex = 22;
            // 
            // btn_BrowseImage
            // 
            this.btn_BrowseImage.Location = new System.Drawing.Point(592, 245);
            this.btn_BrowseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BrowseImage.Name = "btn_BrowseImage";
            this.btn_BrowseImage.Size = new System.Drawing.Size(93, 23);
            this.btn_BrowseImage.TabIndex = 26;
            this.btn_BrowseImage.Text = "Add Image";
            this.btn_BrowseImage.UseVisualStyleBackColor = true;
            this.btn_BrowseImage.Click += new System.EventHandler(this.btn_BrowseImage_Click);
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddCategory.FlatAppearance.BorderSize = 0;
            this.btn_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCategory.Image = global::WindowsFormsApp1.Properties.Resources.add_icon;
            this.btn_AddCategory.Location = new System.Drawing.Point(423, 176);
            this.btn_AddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(19, 21);
            this.btn_AddCategory.TabIndex = 25;
            this.btn_AddCategory.UseVisualStyleBackColor = false;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Image.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblEquipmentItemsBindingSource, "Image", true));
            this.pb_Image.Image = global::WindowsFormsApp1.Properties.Resources.add_icon_1;
            this.pb_Image.Location = new System.Drawing.Point(591, 272);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(275, 144);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Image.TabIndex = 24;
            this.pb_Image.TabStop = false;
            // 
            // tblEquipmentItemsTableAdapter
            // 
            this.tblEquipmentItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_LogsTableAdapter = null;
            this.tableAdapterManager.TblCategoryTableAdapter = null;
            this.tableAdapterManager.TblCustomersTableAdapter = null;
            this.tableAdapterManager.TblEquipmentItemsTableAdapter = this.tblEquipmentItemsTableAdapter;
            this.tableAdapterManager.TblRentItemsTableAdapter = null;
            this.tableAdapterManager.TblReturnedItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frm_AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.btn_BrowseImage);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.tb_Cost);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.NumUD_Quantity);
            this.Controls.Add(serialNoLabel);
            this.Controls.Add(this.tb_SerialNumber);
            this.Controls.Add(datePurchasedLabel);
            this.Controls.Add(this.dateTP_DatePurchased);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.cb_Condition);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.tb_ItemID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_AddNewItem";
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.frm_AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SaveItem;
        private System.Windows.Forms.Button btn_Cancel;
        private EquipmentItemDBDataSet equipmentItemDBDataSet;
        private System.Windows.Forms.BindingSource tblEquipmentItemsBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblEquipmentItemsTableAdapter tblEquipmentItemsTableAdapter;
        private EquipmentItemDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox tb_ItemID;
        private System.Windows.Forms.TextBox tb_ItemName;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.ComboBox cb_Condition;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DateTimePicker dateTP_DatePurchased;
        private System.Windows.Forms.TextBox tb_SerialNumber;
        private System.Windows.Forms.NumericUpDown NumUD_Quantity;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_BrowseImage;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblCategoryTableAdapter tblCategoryTableAdapter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}