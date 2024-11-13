using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // Make sure to include this namespace

namespace WindowsFormsApp1
{
    public partial class frm_ItemLogs : Form
    {
        // Use the connection string from App.config
        private readonly string connectionStringEDB;

        public frm_ItemLogs()
        {
            InitializeComponent();
            connectionStringEDB = ConfigurationManager.ConnectionStrings["EquipmentInventoryDB"].ConnectionString;
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