using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_ItemLogs : Form
    {
        // Set up your connection string here.
        private readonly string connectionStringEDB = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\New folder\\Equipment Inventory 11-8-2024\\Equipment Inventory 10302024\\Equipment Inventory 1\\Equipment Inventory\\WindowsFormsApp1\\EquipmentItemDB.mdf\";Integrated Security=True";
       
        public frm_ItemLogs()
        {
            InitializeComponent();
            LoadLogsData();
        }

        // Method to load data from tbl_Logs and display in dgv_LogView
        private void LoadLogsData()
        {
            string query = "SELECT * FROM tbl_Logs"; // SQL query to retrieve data from tbl_Logs

            using (SqlConnection conn = new SqlConnection(connectionStringEDB))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable logsTable = new DataTable();
                    dataAdapter.Fill(logsTable); // Fill DataTable with data from tbl_Logs

                    dgv_LogView.DataSource = logsTable; // Bind DataTable to DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while accessing the database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void frm_ItemLogs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.tbl_Logs' table. You can move, or remove it, as needed.
            this.tbl_LogsTableAdapter.Fill(this.equipmentItemDBDataSet.tbl_Logs);

        }
    }
}
