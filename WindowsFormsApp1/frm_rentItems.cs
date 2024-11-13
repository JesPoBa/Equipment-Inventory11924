using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // Add this namespace

namespace WindowsFormsApp1
{
    public partial class frm_rentItems : Form
    {
        private readonly string connectionString;

        public frm_rentItems()
        {
            InitializeComponent();
            // Retrieve the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["EquipmentInventoryDB"].ConnectionString;
        }

        private void frm_rentItems_Load(object sender, EventArgs e)
        {
            LoadItemsIntoComboBox();
            this.tblRentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblRentItems);
            ReloadRentItemsData(); // Load data into the DataGridView on form load
            LoadCustomerNames();
        }

        // Method to load customer names from the database into the ComboBox
        private void LoadCustomerNames()
        {
            string query = "SELECT CustomerName FROM TblCustomers"; // Ensure this matches your database column

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmb_ShowCustomerNames.Items.Clear(); // Clear previous items in ComboBox
                    while (reader.Read())
                    {
                        cmb_ShowCustomerNames.Items.Add(reader["CustomerName"].ToString());
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error loading customer names: " + ex.Message);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadItemsIntoComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ItemName FROM TblEquipmentItems"; // Change to your table and column name
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_RentItems.Items.Add(reader["ItemName"].ToString());
                    }
                    cb_RentItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cb_RentItems.AutoCompleteSource = AutoCompleteSource.ListItems;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading items: " + ex.Message);
                }
            }
        }

        private void cb_RentItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cb_RentItems.SelectedItem.ToString();
            DataTable itemData = GetItemDetailsFromDatabase(selectedItem);
            dgv_RentItems.DataSource = itemData;
        }

        private DataTable GetItemDetailsFromDatabase(string itemName)
        {
            DataTable table = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM TblEquipmentItems WHERE ItemName = @ItemName"; // Customize the query
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(table);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching item details: " + ex.Message);
                }
            }

            return table;
        }

        private void TransferSelectedItem()
        {
            // Get the selected item from the ComboBox
            var selectedItem = cb_RentItems.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Please select an item to transfer.");
                return;
            }

            // Get the selected customer name directly from the ComboBox
            var selectedCustomerName = cmb_ShowCustomerNames.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedCustomerName))
            {
                MessageBox.Show("Please select a customer for this rental.");
                return;
            }

            // Validate and get the quantity
            if (!int.TryParse(txt_quantity.Text, out int transferQuantity) || transferQuantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemID, ItemName, Category, Description, Condition, Status, SerialNo, Quantity, Cost, Image FROM TblEquipmentItems WHERE ItemName = @ItemName";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@ItemName", selectedItem);

                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve item details
                            int itemID = (int)reader["ItemID"];
                            string itemName = reader["ItemName"].ToString();
                            string category = reader["Category"].ToString();
                            string description = reader["Description"].ToString();
                            string condition = reader["Condition"].ToString();

                            string status = reader["Status"].ToString();
                            if (status == "Under Maintenance")
                            {
                                MessageBox.Show("Item is under maintenance and cannot be rented.");
                                return;
                            }

                            string serialNo = reader["SerialNo"].ToString();
                            int quantity = (int)reader["Quantity"];
                            float cost = (float)Convert.ToDouble(reader["Cost"]);
                            byte[] image = (byte[])reader["Image"];

                            if (quantity < transferQuantity)
                            {
                                MessageBox.Show($"Insufficient quantity for item '{itemName}'. Available quantity: {quantity}");
                                return;
                            }

                            // Insert item and selected customer name into TblRentItems
                            string insertQuery = "INSERT INTO TblRentItems (ItemID, ItemName, Category, Description, Condition, Status, SerialNo, RentDate, Quantity, Cost, Image, CustomerName) " +
                                "VALUES (@ItemID, @ItemName, @Category, @Description, @Condition, @Status, @SerialNo, @RentDate, @TransferQuantity, @Cost, @Image, @CustomerName)";

                            using (SqlCommand insertCommand = new SqlCommand(insertQuery, conn))
                            {
                                insertCommand.Parameters.AddWithValue("@ItemID", itemID);
                                insertCommand.Parameters.AddWithValue("@ItemName", itemName);
                                insertCommand.Parameters.AddWithValue("@Category", category);
                                insertCommand.Parameters.AddWithValue("@Description", description);
                                insertCommand.Parameters.AddWithValue("@Condition", condition);
                                insertCommand.Parameters.AddWithValue("@Status", status);
                                insertCommand.Parameters.AddWithValue("@SerialNo", serialNo);
                                insertCommand.Parameters.AddWithValue("@RentDate", dtpRentDate.Value);
                                insertCommand.Parameters.AddWithValue("@TransferQuantity", transferQuantity);
                                insertCommand.Parameters.AddWithValue("@Cost", cost);
                                insertCommand.Parameters.AddWithValue("@Image", image);
                                insertCommand.Parameters.AddWithValue("@CustomerName", selectedCustomerName); // Use selected CustomerName

                                reader.Close();

                                int rowsAffected = insertCommand.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show($"Item '{itemName}' successfully transferred to TblRentItems for customer '{selectedCustomerName}'.");

                                    // Update quantity in TblEquipmentItems
                                    string updateQuery = "UPDATE TblEquipmentItems SET Quantity = Quantity - @TransferQuantity WHERE ItemID = @ItemID";
                                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, conn))
                                    {
                                        updateCommand.Parameters.AddWithValue("@ItemID", itemID);
                                        updateCommand.Parameters.AddWithValue("@TransferQuantity", transferQuantity);
                                        int updateRows = updateCommand.ExecuteNonQuery();
                                        if (updateRows > 0)
                                        {
                                            MessageBox.Show($"Quantity of item '{itemName}' successfully reduced by {transferQuantity}.");
                                        }
                                        else
                                        {
                                            MessageBox.Show($"Failed to update quantity for item '{itemName}'.");
                                        }
                                    }

                                    // Log the action in tbl_Logs
                                    string logQuery = "INSERT INTO tbl_Logs (ItemID, ItemName, Action, Date, Time, LoggedBy, AssignedTo) " +
                                                      "VALUES (@ItemID, @ItemName, 'Item rented', @Date, @Time, @LoggedBy, @AssignedTo)";
                                    using (SqlCommand logCommand = new SqlCommand(logQuery, conn))
                                    {
                                        logCommand.Parameters.AddWithValue("@ItemID", itemID);
                                        logCommand.Parameters.AddWithValue("@ItemName", itemName);
                                        logCommand.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                                        logCommand.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
                                        logCommand.Parameters.AddWithValue("@LoggedBy", Environment.UserName); // Adjust as needed
                                        logCommand.Parameters.AddWithValue("@AssignedTo", selectedCustomerName);

                                        logCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show($"Failed to transfer item '{itemName}' to TblRentItems.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show($"No item found with the name '{selectedItem}'");
                        }
                    }
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            TransferSelectedItem();
            ReloadRentItemsData(); // Refresh the DataGridView after adding the item
        }

        private void ReloadRentItemsData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM TblRentItems";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgv_RentItems.DataSource = table; // Set the data source for the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rent items: " + ex.Message);
                }
            }
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            frm_AddCustomer addCustomerForm = new frm_AddCustomer();
            addCustomerForm.ShowDialog();
        }
    }
}
