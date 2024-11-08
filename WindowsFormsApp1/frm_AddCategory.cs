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
using WindowsFormsApp1.Inventory_Folder;

namespace WindowsFormsApp1
{
    public partial class frm_AddCategory : Form
    {
        public string NewCategory { get; set; }
        public bool CategoryAdded { get; set; }

        static SqlConnection conn = null;
        static SqlCommand cmd = null;

        public frm_AddCategory()
        {
            InitializeComponent();
            DatabaseConnection();
        }

        private void DatabaseConnection()
        {
            string url = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\New folder\Equipment Inventory 11-8-2024\Equipment Inventory 10302024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True");

            conn = new SqlConnection(url);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Add the new category to the database
            try
            {
                string query = "INSERT INTO TblCategory (Category) VALUES (@CategoryName)";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CategoryName", tb_Category.Text);
                cmd.ExecuteNonQuery();
                conn.Close();


                // Set the new category and category added flag
                NewCategory = tb_Category.Text;
                CategoryAdded = true;

                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
