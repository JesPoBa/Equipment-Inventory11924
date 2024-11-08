namespace WindowsFormsApp1
{
    partial class frm_dashboard
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
            this.panel_Header = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.lbl_loguser = new System.Windows.Forms.Label();
            this.linkLabel_EIS = new System.Windows.Forms.LinkLabel();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Menu = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonInventItems = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonItemLogs = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDefault = new System.Windows.Forms.Panel();
            this.panel_Header.SuspendLayout();
            this.panel23.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Header
            // 
            this.panel_Header.AutoSize = true;
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(86)))), ((int)(((byte)(142)))));
            this.panel_Header.Controls.Add(this.panel23);
            this.panel_Header.Controls.Add(this.linkLabel_EIS);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(0, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(1901, 50);
            this.panel_Header.TabIndex = 0;
            // 
            // panel23
            // 
            this.panel23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel23.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel23.Controls.Add(this.lbl_loguser);
            this.panel23.Location = new System.Drawing.Point(1409, 2);
            this.panel23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(477, 46);
            this.panel23.TabIndex = 6;
            // 
            // lbl_loguser
            // 
            this.lbl_loguser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_loguser.AutoSize = true;
            this.lbl_loguser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loguser.ForeColor = System.Drawing.Color.White;
            this.lbl_loguser.Location = new System.Drawing.Point(193, 11);
            this.lbl_loguser.Name = "lbl_loguser";
            this.lbl_loguser.Size = new System.Drawing.Size(44, 28);
            this.lbl_loguser.TabIndex = 3;
            this.lbl_loguser.Text = "....";
            // 
            // linkLabel_EIS
            // 
            this.linkLabel_EIS.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.linkLabel_EIS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel_EIS.AutoSize = true;
            this.linkLabel_EIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_EIS.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_EIS.LinkColor = System.Drawing.Color.White;
            this.linkLabel_EIS.Location = new System.Drawing.Point(795, 9);
            this.linkLabel_EIS.Name = "linkLabel_EIS";
            this.linkLabel_EIS.Size = new System.Drawing.Size(316, 29);
            this.linkLabel_EIS.TabIndex = 5;
            this.linkLabel_EIS.TabStop = true;
            this.linkLabel_EIS.Text = "Equipment Inventory System";
            this.linkLabel_EIS.VisitedLinkColor = System.Drawing.Color.LightSteelBlue;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimerTick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.label1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 50);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(275, 1231);
            this.sidebar.MinimumSize = new System.Drawing.Size(69, 1231);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(275, 1231);
            this.sidebar.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Menu);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 113);
            this.panel1.TabIndex = 0;
            // 
            // label_Menu
            // 
            this.label_Menu.AutoSize = true;
            this.label_Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Menu.ForeColor = System.Drawing.Color.White;
            this.label_Menu.Location = new System.Drawing.Point(77, 42);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(62, 28);
            this.label_Menu.TabIndex = 1;
            this.label_Menu.Text = "Menu";
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = global::WindowsFormsApp1.Properties.Resources.hmMenu;
            this.menuButton.Location = new System.Drawing.Point(20, 39);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(37, 37);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDashboard);
            this.panel2.Location = new System.Drawing.Point(3, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 60);
            this.panel2.TabIndex = 1;
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonDashboard.Image = global::WindowsFormsApp1.Properties.Resources.dashboard_24;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(-11, -11);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonDashboard.Size = new System.Drawing.Size(283, 82);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "           Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonInventItems);
            this.panel3.Location = new System.Drawing.Point(3, 183);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 60);
            this.panel3.TabIndex = 2;
            // 
            // buttonInventItems
            // 
            this.buttonInventItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonInventItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventItems.ForeColor = System.Drawing.Color.White;
            this.buttonInventItems.Image = global::WindowsFormsApp1.Properties.Resources.box_2_24;
            this.buttonInventItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventItems.Location = new System.Drawing.Point(-13, -11);
            this.buttonInventItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInventItems.Name = "buttonInventItems";
            this.buttonInventItems.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonInventItems.Size = new System.Drawing.Size(283, 82);
            this.buttonInventItems.TabIndex = 3;
            this.buttonInventItems.Text = "           Inventory Items";
            this.buttonInventItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventItems.UseVisualStyleBackColor = false;
            this.buttonInventItems.Click += new System.EventHandler(this.buttonInventItems_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonItemLogs);
            this.panel6.Location = new System.Drawing.Point(3, 247);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(257, 60);
            this.panel6.TabIndex = 5;
            // 
            // buttonItemLogs
            // 
            this.buttonItemLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonItemLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonItemLogs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonItemLogs.ForeColor = System.Drawing.Color.White;
            this.buttonItemLogs.Image = global::WindowsFormsApp1.Properties.Resources.logs_icon;
            this.buttonItemLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonItemLogs.Location = new System.Drawing.Point(-13, -11);
            this.buttonItemLogs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonItemLogs.Name = "buttonItemLogs";
            this.buttonItemLogs.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonItemLogs.Size = new System.Drawing.Size(283, 82);
            this.buttonItemLogs.TabIndex = 4;
            this.buttonItemLogs.Text = "            Item Logs";
            this.buttonItemLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonItemLogs.UseVisualStyleBackColor = false;
            this.buttonItemLogs.Click += new System.EventHandler(this.buttonItemLogs_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonSettings);
            this.panel4.Location = new System.Drawing.Point(3, 311);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(257, 60);
            this.panel4.TabIndex = 3;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::WindowsFormsApp1.Properties.Resources.settings_icon2_24;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(-13, -11);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.buttonSettings.Size = new System.Drawing.Size(283, 82);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = "           Settings";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonLogout);
            this.panel5.Location = new System.Drawing.Point(3, 375);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 60);
            this.panel5.TabIndex = 4;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Image = global::WindowsFormsApp1.Properties.Resources.account_logout_24;
            this.buttonLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.Location = new System.Drawing.Point(-13, -11);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.buttonLogout.Size = new System.Drawing.Size(281, 82);
            this.buttonLogout.TabIndex = 6;
            this.buttonLogout.Text = "           Logout";
            this.buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(3, 440);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(268, 509);
            this.panel7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 952);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Version 1.1";
            // 
            // panelDefault
            // 
            this.panelDefault.AutoScroll = true;
            this.panelDefault.AutoSize = true;
            this.panelDefault.BackColor = System.Drawing.SystemColors.Control;
            this.panelDefault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDefault.Location = new System.Drawing.Point(275, 50);
            this.panelDefault.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panelDefault.Name = "panelDefault";
            this.panelDefault.Size = new System.Drawing.Size(1626, 1005);
            this.panelDefault.TabIndex = 8;
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1901, 1055);
            this.Controls.Add(this.panelDefault);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EIMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_dashboard_Load);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonInventItems;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonItemLogs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.LinkLabel linkLabel_EIS;
        private System.Windows.Forms.Panel panelDefault;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Label lbl_loguser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
    }
}

