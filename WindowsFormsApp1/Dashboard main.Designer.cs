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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Items in Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items currently rented out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(893, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items returned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1329, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Upcoming return dates";
            // 
            // lblTotalItems
            // 
            this.lblTotalItems.AutoSize = true;
            this.lblTotalItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItems.Location = new System.Drawing.Point(23, 71);
            this.lblTotalItems.Name = "lblTotalItems";
            this.lblTotalItems.Size = new System.Drawing.Size(73, 77);
            this.lblTotalItems.TabIndex = 6;
            this.lblTotalItems.Text = "0";
            // 
            // lblRentedItems
            // 
            this.lblRentedItems.AutoSize = true;
            this.lblRentedItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedItems.Location = new System.Drawing.Point(429, 71);
            this.lblRentedItems.Name = "lblRentedItems";
            this.lblRentedItems.Size = new System.Drawing.Size(73, 77);
            this.lblRentedItems.TabIndex = 7;
            this.lblRentedItems.Text = "0";
            // 
            // lblReturnedItems
            // 
            this.lblReturnedItems.AutoSize = true;
            this.lblReturnedItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedItems.Location = new System.Drawing.Point(868, 71);
            this.lblReturnedItems.Name = "lblReturnedItems";
            this.lblReturnedItems.Size = new System.Drawing.Size(73, 77);
            this.lblReturnedItems.TabIndex = 8;
            this.lblReturnedItems.Text = "0";
            // 
            // lblDueSoonItems
            // 
            this.lblDueSoonItems.AutoSize = true;
            this.lblDueSoonItems.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueSoonItems.Location = new System.Drawing.Point(1319, 71);
            this.lblDueSoonItems.Name = "lblDueSoonItems";
            this.lblDueSoonItems.Size = new System.Drawing.Size(73, 77);
            this.lblDueSoonItems.TabIndex = 9;
            this.lblDueSoonItems.Text = "0";
            // 
            // dgvRentItems
            // 
            this.dgvRentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentItems.Location = new System.Drawing.Point(389, 223);
            this.dgvRentItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRentItems.Name = "dgvRentItems";
            this.dgvRentItems.RowHeadersWidth = 51;
            this.dgvRentItems.Size = new System.Drawing.Size(1208, 199);
            this.dgvRentItems.TabIndex = 10;
            // 
            // dgvReturnedItems
            // 
            this.dgvReturnedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnedItems.Location = new System.Drawing.Point(389, 489);
            this.dgvReturnedItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReturnedItems.Name = "dgvReturnedItems";
            this.dgvReturnedItems.RowHeadersWidth = 51;
            this.dgvReturnedItems.Size = new System.Drawing.Size(1208, 199);
            this.dgvReturnedItems.TabIndex = 11;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(37, 223);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(396, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "RENTED ITEMS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "RETURNED ITEMS";
            // 
            // Dashboard_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1651, 743);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}