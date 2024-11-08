namespace WindowsFormsApp1
{
    partial class Dashboard_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.lblRentedItems = new System.Windows.Forms.Label();
            this.lblReturnedItems = new System.Windows.Forms.Label();
            this.lblDueSoonItems = new System.Windows.Forms.Label();
            this.dgvRentItems = new System.Windows.Forms.DataGridView();
            this.dgvReturnedItems = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Items in Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items currently rented out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(670, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items returned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(997, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upcoming return dates";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(17, 58);
            this.lblTotalItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(58, 61);
            this.lblTotalItems.TabIndex = 6;
            this.lblTotalItems.Text = "0";
            // 
            // lblRentedItems
            // 
            this.lblRentedItems.AutoSize = true;
            this.lblRentedItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedItems.Location = new System.Drawing.Point(322, 58);
            this.lblRentedItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRentedItems.Name = "lblRentedItems";
            this.lblRentedItems.Size = new System.Drawing.Size(58, 61);
            this.lblRentedItems.TabIndex = 7;
            this.lblRentedItems.Text = "0";
            // 
            // lblReturnedItems
            // 
            this.lblReturnedItems.AutoSize = true;
            this.lblReturnedItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedItems.Location = new System.Drawing.Point(651, 58);
            this.lblReturnedItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReturnedItems.Name = "lblReturnedItems";
            this.lblReturnedItems.Size = new System.Drawing.Size(58, 61);
            this.lblReturnedItems.TabIndex = 8;
            this.lblReturnedItems.Text = "0";
            // 
            // lblDueSoonItems
            // 
            this.lblDueSoonItems.AutoSize = true;
            this.lblDueSoonItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueSoonItems.Location = new System.Drawing.Point(989, 58);
            this.lblDueSoonItems.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDueSoonItems.Name = "lblDueSoonItems";
            this.lblDueSoonItems.Size = new System.Drawing.Size(58, 61);
            this.lblDueSoonItems.TabIndex = 9;
            this.lblDueSoonItems.Text = "0";
            // 
            // dgvRentItems
            // 
            this.dgvRentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentItems.Location = new System.Drawing.Point(292, 181);
            this.dgvRentItems.Name = "dgvRentItems";
            this.dgvRentItems.Size = new System.Drawing.Size(906, 162);
            this.dgvRentItems.TabIndex = 10;
            // 
            // dgvReturnedItems
            // 
            this.dgvReturnedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnedItems.Location = new System.Drawing.Point(292, 397);
            this.dgvReturnedItems.Name = "dgvReturnedItems";
            this.dgvReturnedItems.Size = new System.Drawing.Size(906, 162);
            this.dgvReturnedItems.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 181);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // Dashboard_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 604);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dgvReturnedItems);
            this.Controls.Add(this.dgvRentItems);
            this.Controls.Add(this.lblDueSoonItems);
            this.Controls.Add(this.lblReturnedItems);
            this.Controls.Add(this.lblRentedItems);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1238, 604);
            this.Name = "Dashboard_main";
            this.Text = "Dashboard_main";
            this.Load += new System.EventHandler(this.Dashboard_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.Label lblRentedItems;
        private System.Windows.Forms.Label lblReturnedItems;
        private System.Windows.Forms.Label lblDueSoonItems;
        private System.Windows.Forms.DataGridView dgvRentItems;
        private System.Windows.Forms.DataGridView dgvReturnedItems;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}