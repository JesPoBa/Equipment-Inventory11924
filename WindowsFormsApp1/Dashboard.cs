using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_dashboard : Form
    {
        bool sidebarExpand;

        public frm_dashboard(String log)
        {
            InitializeComponent();
            lbl_loguser.Text = log;
            
        }

        public frm_dashboard()
        {

        }

        private void sidebarTimerTick(object sender, EventArgs e)
        {
            //SET the min and max size of sidebar panel
            if (sidebarExpand)
            {
                //if sidebar is expanded, minimize
                sidebar.Width -= 10;

                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            
        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }


        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelDefault.Controls.Clear();
            Dashboard_main dm = new Dashboard_main();
            dm.TopLevel = false;
            panelDefault.Controls.Add(dm);
            dm.BringToFront();
            dm.Show();
        }

        private void buttonInventItems_Click(object sender, EventArgs e)
        {
            panelDefault.Controls.Clear();
            frm_InventoryItems fii = new frm_InventoryItems();
            fii.TopLevel = false;
            panelDefault.Controls.Add(fii);
            fii.BringToFront();
            fii.Show();

            // Call the RefreshData method
            fii.RefreshData();

        }

        private void buttonItemLogs_Click(object sender, EventArgs e)
        {
            panelDefault.Controls.Clear();
            frm_ItemLogs fil = new frm_ItemLogs();
            fil.TopLevel = false;
            panelDefault.Controls.Add(fil);
            fil.BringToFront();
            fil.Show();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            panelDefault.Controls.Clear();
            frm_Settings fs = new frm_Settings();
            fs.TopLevel = false;
            panelDefault.Controls.Add(fs);
            fs.BringToFront();
            fs.Show();
        }

        private void frm_dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void panel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to logout?", "Logout message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                frm_Login fr = new frm_Login();
                fr.Show();
                this.Hide();
            }

        }
    }
}
