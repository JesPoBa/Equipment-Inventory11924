using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frm_Login : Form
    {
        
        SqlConnection con = new SqlConnection(Properties.Settings.Default.uaDBConnectionString);
        SqlDataAdapter da;
        SqlCommand cmd;
        public frm_Login()
        {
            InitializeComponent();
            this.ActiveControl = textUsername;
            textUsername.Focus();
        }
        string log;

        private void buttonLog_in_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE Username='"+textUsername.Text+"' and Password='"+textPassword.Text+"'", con);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i == 1)
            {
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[3].ToString() == "Admin")
                {
                    ulog.type = "A";
                }
                else if (dr[3].ToString() == "User")
                {
                    ulog.type = "U";
                }               
                log = "Welcome: "+ textUsername.Text;
                this.Hide();
                frm_dashboard fd = new frm_dashboard(log);
                fd.Show();
                
                
            } 
            else
            {
                MessageBox.Show("Please checkyour User name or Password", "Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            textUsername.Clear();
            textPassword.Clear();
            textUsername.Focus();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
