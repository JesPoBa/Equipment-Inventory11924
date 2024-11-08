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
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }

        private void tblCustomersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCustomersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipmentItemDBDataSet);

        }

        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblCustomers' table. You can move, or remove it, as needed.
            this.tblCustomersTableAdapter.Fill(this.equipmentItemDBDataSet.TblCustomers);

        }

        private void btn_SaveCustomer_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TblCustomers (CustomerName, ContactNumber, Email, Address, RentalStatus) " +
           "VALUES (@CustomerName, @ContactNumber, @Email, @Address, @RentalStatus)";

            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\New folder\Equipment Inventory 11-8-2024\Equipment Inventory 10302024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", txt_CustomerName.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txt_ContactNumber.Text); // Fix: Changed to txt_ContactNumber
                cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                cmd.Parameters.AddWithValue("@Address", txt_Address.Text);
                cmd.Parameters.AddWithValue("@RentalStatus", cmb_RentalStatus.SelectedItem.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added successfully.");
                conn.Close();

                // Clear the input fields
                txt_CustomerName.Clear();
                txt_ContactNumber.Clear();
                txt_Email.Clear();
                txt_Address.Clear();
                cmb_RentalStatus.SelectedIndex = -1; // Reset ComboBox selection

                // Refresh rent items form if necessary
                frm_rentItems fri = new frm_rentItems();
                fri.Refresh();
            }

        }
    }
}
