using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            cmd = new SqlCommand("SELECT * FROM tbllog WHERE Username=@Username AND Password=@Password", con);
            cmd.Parameters.AddWithValue("@Username", textUsername.Text);
            cmd.Parameters.AddWithValue("@Password", textPassword.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                ulog.Username = dr["Username"].ToString();
                ulog.Type = dr["Role"].ToString() == "Admin" ? "A" : "U"; // Assuming "Role" column defines admin/user

                log = ulog.Username;
                this.Hide();
                frm_dashboard fd = new frm_dashboard(log);
                fd.Show();
                
            }
            else
            {
                MessageBox.Show("Please check your Username or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
