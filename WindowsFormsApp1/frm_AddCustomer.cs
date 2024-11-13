using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // For ConfigurationManager

namespace WindowsFormsApp1
{
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }

        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {
            // Load data into the 'TblCustomers' table
            this.tblCustomersTableAdapter.Fill(this.equipmentItemDBDataSet.TblCustomers);
        }

        private void btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            // Validate input fields before proceeding
            if (string.IsNullOrWhiteSpace(txt_CustomerName.Text) ||
                string.IsNullOrWhiteSpace(txt_ContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txt_Email.Text) ||
                string.IsNullOrWhiteSpace(txt_Address.Text) ||
                cmb_RentalStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "INSERT INTO TblCustomers (CustomerName, ContactNumber, Email, Address, RentalStatus) " +
                           "VALUES (@CustomerName, @ContactNumber, @Email, @Address, @RentalStatus)";

            string connectionString = ConfigurationManager.ConnectionStrings["EquipmentInventoryDB"].ConnectionString;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", txt_CustomerName.Text);
                        cmd.Parameters.AddWithValue("@ContactNumber", txt_ContactNumber.Text);
                        cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                        cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                        cmd.Parameters.AddWithValue("@RentalStatus", cmb_RentalStatus.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully.");
                    }
                }

                // Clear the input fields
                ClearInputFields();

                // Optionally refresh the rent items form if necessary
                // Assuming you have a reference to the rent items form
                frm_rentItems fri = new frm_rentItems();
                fri.Refresh();
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

        private void ClearInputFields()
        {
            txt_CustomerName.Clear();
            txt_ContactNumber.Clear();
            txt_Email.Clear();
            txt_Address.Clear();
            cmb_RentalStatus.SelectedIndex = -1; // Reset ComboBox selection
        }
    }
}