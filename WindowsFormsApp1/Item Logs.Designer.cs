namespace WindowsFormsApp1
{
    partial class frm_ItemLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ItemLogs));
            this.label_Dashboard = new System.Windows.Forms.Label();
            this.linkLabel_EIS = new System.Windows.Forms.LinkLabel();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_LogView = new System.Windows.Forms.DataGridView();
            this.logIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loggedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentItemDBDataSet = new WindowsFormsApp1.EquipmentItemDBDataSet();
            this.tbl_LogsTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.tbl_LogsTableAdapter();
            this.btn_Export = new System.Windows.Forms.Button();
            this.panel_Header.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Dashboard
            // 
            this.label_Dashboard.AutoSize = true;
            this.label_Dashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dashboard.ForeColor = System.Drawing.Color.White;
            this.label_Dashboard.Location = new System.Drawing.Point(93, 20);
            this.label_Dashboard.Name = "label_Dashboard";
            this.label_Dashboard.Size = new System.Drawing.Size(120, 23);
            this.label_Dashboard.TabIndex = 1;
            this.label_Dashboard.Text = "Dashboard";
            // 
            // linkLabel_EIS
            // 
            this.linkLabel_EIS.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.linkLabel_EIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel_EIS.AutoSize = true;
            this.linkLabel_EIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_EIS.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_EIS.LinkColor = System.Drawing.Color.White;
            this.linkLabel_EIS.Location = new System.Drawing.Point(287, 16);
            this.linkLabel_EIS.Name = "linkLabel_EIS";
            this.linkLabel_EIS.Size = new System.Drawing.Size(316, 29);
            this.linkLabel_EIS.TabIndex = 2;
            this.linkLabel_EIS.TabStop = true;
            this.linkLabel_EIS.Text = "Equipment Inventory System";
            this.linkLabel_EIS.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(142)))));
            this.panel_Header.Controls.Add(this.label_Dashboard);
            this.panel_Header.Controls.Add(this.button1);
            this.panel_Header.Controls.Add(this.linkLabel_EIS);
            this.panel_Header.Location = new System.Drawing.Point(273, -185);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(888, 54);
            this.panel_Header.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btn_Search);
            this.panel8.Controls.Add(this.textBoxSearch);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(68, 103);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(435, 49);
            this.panel8.TabIndex = 5;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(279, 7);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(89, 30);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(43, 7);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(231, 27);
            this.textBoxSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.search_icon_black_24;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Logs";
            // 
            // dgv_LogView
            // 
            this.dgv_LogView.AutoGenerateColumns = false;
            this.dgv_LogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LogView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logIDDataGridViewTextBoxColumn,
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.loggedByDataGridViewTextBoxColumn,
            this.assignedToDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn});
            this.dgv_LogView.DataSource = this.tblLogsBindingSource;
            this.dgv_LogView.Location = new System.Drawing.Point(67, 170);
            this.dgv_LogView.Name = "dgv_LogView";
            this.dgv_LogView.ReadOnly = true;
            this.dgv_LogView.RowHeadersWidth = 51;
            this.dgv_LogView.RowTemplate.Height = 24;
            this.dgv_LogView.Size = new System.Drawing.Size(1369, 430);
            this.dgv_LogView.TabIndex = 9;
            // 
            // logIDDataGridViewTextBoxColumn
            // 
            this.logIDDataGridViewTextBoxColumn.DataPropertyName = "LogID";
            this.logIDDataGridViewTextBoxColumn.HeaderText = "Log ID";
            this.logIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.logIDDataGridViewTextBoxColumn.Name = "logIDDataGridViewTextBoxColumn";
            this.logIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.logIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            this.itemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
            this.actionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            this.actionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // loggedByDataGridViewTextBoxColumn
            // 
            this.loggedByDataGridViewTextBoxColumn.DataPropertyName = "LoggedBy";
            this.loggedByDataGridViewTextBoxColumn.HeaderText = "Logged By";
            this.loggedByDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loggedByDataGridViewTextBoxColumn.Name = "loggedByDataGridViewTextBoxColumn";
            this.loggedByDataGridViewTextBoxColumn.Width = 125;
            // 
            // assignedToDataGridViewTextBoxColumn
            // 
            this.assignedToDataGridViewTextBoxColumn.DataPropertyName = "AssignedTo";
            this.assignedToDataGridViewTextBoxColumn.HeaderText = "Assigned To";
            this.assignedToDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.assignedToDataGridViewTextBoxColumn.Name = "assignedToDataGridViewTextBoxColumn";
            this.assignedToDataGridViewTextBoxColumn.Width = 125;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblLogsBindingSource
            // 
            this.tblLogsBindingSource.DataMember = "tbl_Logs";
            this.tblLogsBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // equipmentItemDBDataSet
            // 
            this.equipmentItemDBDataSet.DataSetName = "EquipmentItemDBDataSet";
            this.equipmentItemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_LogsTableAdapter
            // 
            this.tbl_LogsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Export
            // 
            this.btn_Export.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Export.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Export.Location = new System.Drawing.Point(1259, 111);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(177, 41);
            this.btn_Export.TabIndex = 10;
            this.btn_Export.Text = "Export/ Create Report";
            this.btn_Export.UseVisualStyleBackColor = false;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // frm_ItemLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1490, 780);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.dgv_LogView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_ItemLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Logs";
            this.Load += new System.EventHandler(this.frm_ItemLogs_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LogView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Dashboard;
        private System.Windows.Forms.LinkLabel linkLabel_EIS;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dgv_LogView;
        private EquipmentItemDBDataSet equipmentItemDBDataSet;
        private System.Windows.Forms.BindingSource tblLogsBindingSource;
        private EquipmentItemDBDataSetTableAdapters.tbl_LogsTableAdapter tbl_LogsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loggedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Export;
    }
}