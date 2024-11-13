using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // For ConfigurationManager

namespace WindowsFormsApp1
{
    public partial class frm_AddCategory : Form
    {
        public string NewCategory { get; private set; }
        public bool CategoryAdded { get; private set; }

        public frm_AddCategory()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Add the new category to the database
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["EquipmentInventoryDB"].ConnectionString;
                string query = "INSERT INTO TblCategory (Category) VALUES (@CategoryName)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", tb_Category.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Set the new category and category added flag
                NewCategory = tb_Category.Text;
                CategoryAdded = true;

                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}