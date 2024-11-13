﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Inventory_Folder;
using WindowsFormsApp1.Helpers; // Add the namespace for the helper class

namespace WindowsFormsApp1
{
    public partial class frm_InventoryItems : Form
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;

        public frm_InventoryItems()
        {
            InitializeComponent();
            DatabaseConnection();
        }

        private void DatabaseConnection()
        {
            string url = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\New folder\Equipment Inventory 11-8-2024\Equipment Inventory 10302024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True");

            conn = new SqlConnection(url);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0'Data Source"
                + Application.StartupPath + @"\db");
        }

        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
            frm_AddNewItem adi = new frm_AddNewItem();
            adi.Show();
        }

        private void frm_InventoryItems_Load(object sender, EventArgs e)
        {
            try
            {
                // Load data into the Returned Items table
                this.tblReturnedItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblReturnedItems);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Constraint Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

            try
            {
                // Load data into the Rent Items table
                this.tblRentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblRentItems);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Constraint Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }

            try
            {
                // Load data into the Equipment Items table
                this.tblEquipmentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblEquipmentItems);
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show("Constraint Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        public void RefreshData()
        {
            RefreshEquipmentItems();
            RefreshRentItems();
            RefreshReturnedItems();
        }

        private void RefreshEquipmentItems()
        {
            // SQL query to fetch data from the inventory items table
            string query = "SELECT * FROM TblEquipmentItems";

            try
            {
                conn.Open();

                // Create a data adapter to fetch the data
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable with data
                da.Fill(dt);

                // Bind the data to the DataGridView
                dgv_InventoryList.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after the operation
                conn.Close();
            }
        }

        private void RefreshRentItems()
        {
            string query = "SELECT * FROM tblRentItems";

            try
            {
                // Use the connection inside the 'using' block
                using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\New folder\Equipment Inventory 11-8-2024\Equipment Inventory 10302024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True")) // Ensure you are using your connection string here
                {
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_RentItems.DataSource = dt;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void RefreshReturnedItems()
        {
            // SQL query to fetch data from the returned items table
            string query = "SELECT * FROM TblReturnedItems";

            try
            {
                // Create a data adapter to fetch the data
                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable with data
                da.Fill(dt);

                // Bind the data to the DataGridView
                dgv_ReturnedItems.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after the operation
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData(); // Call the method that refreshes both DataGridViews
        }

        private void btn_rentItem_Click(object sender, EventArgs e)
        {
            frm_rentItems rentItemForm = new frm_rentItems();
            rentItemForm.Show();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = txt_Search.Text.Trim(); // Get the text from the search box
            SearchInventoryItems(searchText);
        }

        private void SearchInventoryItems(string searchText)
        {
            string query = "SELECT * FROM TblEquipmentItems WHERE ItemName LIKE @searchText"; // Adjust the query to match your columns

            try
            {
                conn.Open();

                // Create the command and set the search parameter
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable with data
                da.Fill(dt);

                // Bind the data to the DataGridView
                dgv_InventoryList.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after the operation
                conn.Close();
            }
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            SearchInventoryItems(txt_Search.Text.Trim());
        }

        private void btn_SearchRentItems_Click(object sender, EventArgs e)
        {
            string searchText = txt_SearchRentItems.Text.Trim(); // Get the text from the search box
            SearchRentItems(searchText);
        }

        private void SearchRentItems(string searchText)
        {
            string query = "SELECT * FROM TblRentItems WHERE ItemName LIKE @searchText"; // Adjust the query to match your columns

            try
            {
                // Open connection
                conn.Open();

                // Create the command and set the search parameter
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                // Create a data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                // Create a DataTable to hold the data
                DataTable dt = new DataTable();

                // Fill the DataTable with data
                da.Fill(dt);

                // Bind the data to the DataGridView
                dgv_RentItems.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            finally
            {
                // Close the connection after the operation
                conn.Close();
            }
        }

        private void txt_SearchRentItems_KeyUp(object sender, KeyEventArgs e)
        {
            SearchRentItems(txt_SearchRentItems.Text.Trim());
        }

        private void btn_TransferToReturned_Click(object sender, EventArgs e)
        {
            if (dgv_RentItems.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_RentItems.SelectedRows[0];
                int itemId = Convert.ToInt32(selectedRow.Cells["ItemID"].Value);
                string itemName = selectedRow.Cells["ItemName"].Value.ToString();
                string category = selectedRow.Cells["Category"].Value.ToString();
                string description = selectedRow.Cells["Description"].Value.ToString();
                string condition = selectedRow.Cells["Condition"].Value.ToString();
                string status = selectedRow.Cells["Status"].Value.ToString();
                string serialNo = selectedRow.Cells["SerialNo"].Value.ToString();
                int quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value);
                DateTimeOffset rentDate = (DateTimeOffset)selectedRow.Cells["RentDate"].Value;
                DateTimeOffset returnDate = DateTimeOffset.Now;
                float cost = Convert.ToSingle(selectedRow.Cells["Cost"].Value);

                try
                {
                    conn.Open();

                    // Insert the rented item into the Returned Items table
                    string insertQuery = "INSERT INTO TblReturnedItems (ItemID, ItemName, Category, Description, Condition, Status, SerialNo, Quantity, RentDate, ReturnDate, Cost) " +
                                         "VALUES (@ItemID, @ItemName, @Category, @Description, @Condition, @Status, @SerialNo, @Quantity, @RentDate, @ReturnDate, @Cost)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@ItemID", itemId);
                    insertCmd.Parameters.AddWithValue("@ItemName", itemName);
                    insertCmd.Parameters.AddWithValue("@Category", category);
                    insertCmd.Parameters.AddWithValue("@Description", description);
                    insertCmd.Parameters.AddWithValue("@Condition", condition);
                    insertCmd.Parameters.AddWithValue("@Status", status);
                    insertCmd.Parameters.AddWithValue("@SerialNo", serialNo);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@RentDate", rentDate);
                    insertCmd.Parameters.AddWithValue("@ReturnDate", returnDate);
                    insertCmd.Parameters.AddWithValue("@Cost", cost);
                    insertCmd.ExecuteNonQuery();

                    // Update quantity in TblEquipmentItems
                    string updateQuery = "UPDATE TblEquipmentItems SET Quantity = Quantity + @Quantity WHERE ItemID = @ItemID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateCmd.Parameters.AddWithValue("@ItemID", itemId);
                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        string insertEquipmentQuery = "INSERT INTO TblEquipmentItems (ItemID, ItemName, Category, Description, Condition, Status, SerialNo, Quantity) " +
                                                      "VALUES (@ItemID, @ItemName, @Category, @Description, @Condition, @Status, @SerialNo, @Quantity)";
                        SqlCommand insertEquipmentCmd = new SqlCommand(insertEquipmentQuery, conn);
                        insertEquipmentCmd.Parameters.AddWithValue("@ItemID", itemId);
                        insertEquipmentCmd.Parameters.AddWithValue("@ItemName", itemName);
                        insertEquipmentCmd.Parameters.AddWithValue("@Category", category);
                        insertEquipmentCmd.Parameters.AddWithValue("@Description", description);
                        insertEquipmentCmd.Parameters.AddWithValue("@Condition", condition);
                        insertEquipmentCmd.Parameters.AddWithValue("@Status", status);
                        insertEquipmentCmd.Parameters.AddWithValue("@SerialNo", serialNo);
                        insertEquipmentCmd.Parameters.AddWithValue("@Quantity", quantity);
                        insertEquipmentCmd.ExecuteNonQuery();
                    }

                    // Delete the rented item from TblRentItems
                    string deleteQuery = "DELETE FROM TblRentItems WHERE ItemID = @ItemID";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@ItemID", itemId);
                    deleteCmd.ExecuteNonQuery();

                    // Log the action in tbl_Logs
                    string logQuery = "INSERT INTO tbl_Logs (ItemID, ItemName, Action, Date, Time, LoggedBy, AssignedTo, Condition) " +
                                      "VALUES (@ItemID, @ItemName, @Action, @Date, @Time, @LoggedBy, @AssignedTo, @Condition)";
                    SqlCommand logCmd = new SqlCommand(logQuery, conn);
                    logCmd.Parameters.AddWithValue("@ItemID", itemId);
                    logCmd.Parameters.AddWithValue("@ItemName", itemName);
                    logCmd.Parameters.AddWithValue("@Action", "Returned");
                    logCmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                    logCmd.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
                    logCmd.Parameters.AddWithValue("@LoggedBy", "Current User"); // Replace with actual username if available
                    logCmd.Parameters.AddWithValue("@AssignedTo", "Customer Name"); // Replace with actual customer name if available
                    logCmd.Parameters.AddWithValue("@Condition", condition);
                    logCmd.ExecuteNonQuery();

                    // Refresh DataGridViews
                    RefreshRentItems();
                    RefreshReturnedItems();
                    RefreshEquipmentItems();

                    MessageBox.Show("Item successfully transferred to Returned Items, updated in Equipment Items, and logged in tbl_Logs.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a rented item to transfer.");
            }
        }


        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Dashboard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_SearchRentItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}