namespace WindowsFormsApp1
{
    partial class frm_AddCustomer
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
            System.Windows.Forms.Label customerNameLabel;
            System.Windows.Forms.Label contactNumberLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label rentalStatusLabel;
            this.equipmentItemDBDataSet = new WindowsFormsApp1.EquipmentItemDBDataSet();
            this.tblCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomersTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblCustomersTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TableAdapterManager();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.txt_ContactNumber = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.cmb_RentalStatus = new System.Windows.Forms.ComboBox();
            this.btn_SaveCustomer = new System.Windows.Forms.Button();
            customerNameLabel = new System.Windows.Forms.Label();
            contactNumberLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            rentalStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            customerNameLabel.AutoSize = true;
            customerNameLabel.Location = new System.Drawing.Point(98, 115);
            customerNameLabel.Name = "customerNameLabel";
            customerNameLabel.Size = new System.Drawing.Size(107, 16);
            customerNameLabel.TabIndex = 3;
            customerNameLabel.Text = "Customer Name:";
            // 
            // contactNumberLabel
            // 
            contactNumberLabel.AutoSize = true;
            contactNumberLabel.Location = new System.Drawing.Point(98, 185);
            contactNumberLabel.Name = "contactNumberLabel";
            contactNumberLabel.Size = new System.Drawing.Size(106, 16);
            contactNumberLabel.TabIndex = 5;
            contactNumberLabel.Text = "Contact Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(98, 230);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(98, 277);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(61, 16);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Address:";
            // 
            // rentalStatusLabel
            // 
            rentalStatusLabel.AutoSize = true;
            rentalStatusLabel.Location = new System.Drawing.Point(98, 390);
            rentalStatusLabel.Name = "rentalStatusLabel";
            rentalStatusLabel.Size = new System.Drawing.Size(89, 16);
            rentalStatusLabel.TabIndex = 11;
            rentalStatusLabel.Text = "Rental Status:";
            // 
            // equipmentItemDBDataSet
            // 
            this.equipmentItemDBDataSet.DataSetName = "EquipmentItemDBDataSet";
            this.equipmentItemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCustomersBindingSource
            // 
            this.tblCustomersBindingSource.DataMember = "TblCustomers";
            this.tblCustomersBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // tblCustomersTableAdapter
            // 
            this.tblCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_LogsTableAdapter = null;
            this.tableAdapterManager.TblCategoryTableAdapter = null;
            this.tableAdapterManager.TblCustomersTableAdapter = this.tblCustomersTableAdapter;
            this.tableAdapterManager.TblEquipmentItemsTableAdapter = null;
            this.tableAdapterManager.TblRentItemsTableAdapter = null;
            this.tableAdapterManager.TblReturnedItemsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "CustomerName", true));
            this.txt_CustomerName.Location = new System.Drawing.Point(221, 112);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(304, 22);
            this.txt_CustomerName.TabIndex = 4;
            // 
            // txt_ContactNumber
            // 
            this.txt_ContactNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "ContactNumber", true));
            this.txt_ContactNumber.Location = new System.Drawing.Point(221, 182);
            this.txt_ContactNumber.Name = "txt_ContactNumber";
            this.txt_ContactNumber.Size = new System.Drawing.Size(304, 22);
            this.txt_ContactNumber.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "Email", true));
            this.txt_Email.Location = new System.Drawing.Point(221, 227);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(304, 22);
            this.txt_Email.TabIndex = 8;
            // 
            // txt_Address
            // 
            this.txt_Address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "Address", true));
            this.txt_Address.Location = new System.Drawing.Point(221, 274);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(304, 91);
            this.txt_Address.TabIndex = 10;
            // 
            // cmb_RentalStatus
            // 
            this.cmb_RentalStatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCustomersBindingSource, "RentalStatus", true));
            this.cmb_RentalStatus.FormattingEnabled = true;
            this.cmb_RentalStatus.Items.AddRange(new object[] {
            "Active"});
            this.cmb_RentalStatus.Location = new System.Drawing.Point(221, 387);
            this.cmb_RentalStatus.Name = "cmb_RentalStatus";
            this.cmb_RentalStatus.Size = new System.Drawing.Size(304, 24);
            this.cmb_RentalStatus.TabIndex = 12;
            // 
            // btn_SaveCustomer
            // 
            this.btn_SaveCustomer.Location = new System.Drawing.Point(331, 508);
            this.btn_SaveCustomer.Name = "btn_SaveCustomer";
            this.btn_SaveCustomer.Size = new System.Drawing.Size(194, 37);
            this.btn_SaveCustomer.TabIndex = 14;
            this.btn_SaveCustomer.Text = "Save";
            this.btn_SaveCustomer.UseVisualStyleBackColor = true;
            this.btn_SaveCustomer.Click += new System.EventHandler(this.btn_SaveCustomer_Click);
            // 
            // frm_AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 568);
            this.Controls.Add(this.btn_SaveCustomer);
            this.Controls.Add(rentalStatusLabel);
            this.Controls.Add(this.cmb_RentalStatus);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(contactNumberLabel);
            this.Controls.Add(this.txt_ContactNumber);
            this.Controls.Add(customerNameLabel);
            this.Controls.Add(this.txt_CustomerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_AddCustomer";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.frm_AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EquipmentItemDBDataSet equipmentItemDBDataSet;
        private System.Windows.Forms.BindingSource tblCustomersBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblCustomersTableAdapter tblCustomersTableAdapter;
        private EquipmentItemDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.TextBox txt_ContactNumber;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.ComboBox cmb_RentalStatus;
        private System.Windows.Forms.Button btn_SaveCustomer;
    }
}