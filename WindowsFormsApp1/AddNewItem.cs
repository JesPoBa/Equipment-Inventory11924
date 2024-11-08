using Org.BouncyCastle.Asn1.Cmp;
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
using System.IO;

namespace WindowsFormsApp1.Inventory_Folder
{
    public partial class frm_AddNewItem : Form
    {
        public frm_AddNewItem()
        {
            InitializeComponent();
            DatabaseConnection();
        }

        private void DatabaseConnection()
        {
            // Define your connection string here or use App.config
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Validate Item Name 
            if (string.IsNullOrWhiteSpace(tb_ItemName.Text))
            {
                MessageBox.Show("Item Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ItemName.Focus();
                return;
            }

            // Validate Category 
            if (cb_Category.SelectedIndex == -1)  // Check if no category is selected
            {
                MessageBox.Show("Please select a Category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_Category.Focus();
                return;
            }

            // Validate Quantity (required, and should be greater than zero)
            if (NumUD_Quantity.Value <= 0)
            {
                MessageBox.Show("Quantity should be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumUD_Quantity.Focus();
                return;
            }

            // If all validations pass, proceed with saving the item
            SaveNewItem();
        }

        private void SaveNewItem()
        {
            // SQL query to insert data into TblEquipmentItems
            string insertItemQuery = "INSERT INTO TblEquipmentItems (ItemID, ItemName, Category, Description, Condition, Status, DatePurchased, SerialNo, Quantity, Cost, Image) " +
                                     "VALUES (@ItemID, @ItemName, @Category, @Description, @Condition, @Status, @DatePurchased, @SerialNo, @Quantity, @Cost, @Image)";

            // Connection string (you can move this to App.config for easier management)
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\New folder\\Equipment Inventory 11-8-2024\\Equipment Inventory 10302024\\Equipment Inventory 1\\Equipment Inventory\\WindowsFormsApp1\\EquipmentItemDB.mdf\";Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(insertItemQuery, conn))
                {
                    try
                    {
                        conn.Open();

                        // Add parameters from textboxes for inserting into TblEquipmentItems
                        cmd.Parameters.AddWithValue("@ItemID", tb_ItemID.Text);
                        cmd.Parameters.AddWithValue("@ItemName", tb_ItemName.Text);
                        cmd.Parameters.AddWithValue("@Category", cb_Category.Text);
                        cmd.Parameters.AddWithValue("@Description", tb_Description.Text);
                        cmd.Parameters.AddWithValue("@Condition", cb_Condition.Text);
                        cmd.Parameters.AddWithValue("@Status", cb_Status.Text);
                        cmd.Parameters.AddWithValue("@DatePurchased", dateTP_DatePurchased.Value);
                        cmd.Parameters.AddWithValue("@SerialNo", tb_SerialNumber.Text);
                        cmd.Parameters.AddWithValue("@Quantity", NumUD_Quantity.Value); // Directly using Value property

                        if (decimal.TryParse(tb_Cost.Text, out decimal cost))
                        {
                            cmd.Parameters.AddWithValue("@Cost", cost);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid cost.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tb_Cost.Focus();
                            return;
                        }

                        // Handle image conversion safely
                        if (pb_Image.Image != null)
                        {
                            cmd.Parameters.AddWithValue("@Image", ConvertImageToByteArray(pb_Image.Image));
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@Image", DBNull.Value); // If no image is selected
                        }

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Item added successfully.");
                            LogNewItem(tb_ItemID.Text, tb_ItemName.Text, "New Item Created");

                            // Refresh the inventory form's data
                            if (Application.OpenForms["frm_InventoryItems"] is frm_InventoryItems invForm)
                            {
                                invForm.RefreshData(); // Refresh the data after adding the new item
                            }
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Method to log the new item creation in tbl_Logs
        private void LogNewItem(string itemID, string itemName, string action)
        {
            // SQL query to insert data into tbl_Logs
            string logQuery = "INSERT INTO tbl_Logs (ItemID, ItemName, Action, Date, Time, LoggedBy, AssignedTo, Condition) " +
                              "VALUES (@ItemID, @ItemName, @Action, @Date, @Time, @LoggedBy, @AssignedTo, @Condition)";

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\New folder\\Equipment Inventory 11-8-2024\\Equipment Inventory 10302024\\Equipment Inventory 1\\Equipment Inventory\\WindowsFormsApp1\\EquipmentItemDB.mdf\";Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(logQuery, conn))
                {
                    try
                    {
                        conn.Open();

                        // Add parameters for logging
                        cmd.Parameters.AddWithValue("@ItemID", itemID);
                        cmd.Parameters.AddWithValue("@ItemName", itemName);
                        cmd.Parameters.AddWithValue("@Action", action);
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@Time", DateTime.Now.TimeOfDay);
                        cmd.Parameters.AddWithValue("@LoggedBy", Environment.UserName); // Assuming this is the username of the person logged in
                        cmd.Parameters.AddWithValue("@AssignedTo", DBNull.Value); // AssignedTo is left blank
                        cmd.Parameters.AddWithValue("@Condition", cb_Condition.Text); // Use the Condition selected in the form

                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void frm_AddNewItem_Load(object sender, EventArgs e)
        {
            // Load categories for the ComboBox
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Load categories from the database
            string query = "SELECT Category FROM TblCategory";
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Desktop\\New folder\\Equipment Inventory 11-8-2024\\Equipment Inventory 10302024\\Equipment Inventory 1\\Equipment Inventory\\WindowsFormsApp1\\EquipmentItemDB.mdf\";Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable categories = new DataTable();
                    categories.Load(reader);
                    cb_Category.DataSource = categories;
                    cb_Category.DisplayMember = "Category";
                    cb_Category.ValueMember = "Category";
                    
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            // Create a new instance of the existing Add Category form
            frm_AddCategory addCategoryForm = new frm_AddCategory();
            addCategoryForm.ShowDialog();

            // Refresh the data source of the cb_Category ComboBox
            if (addCategoryForm.CategoryAdded)
            {
                LoadCategories();
                cb_Category.SelectedItem = addCategoryForm.NewCategory;
            }
        }

        private void btn_BrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Select an Image File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pb_Image.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                pb_Image.Image = null; // Clear image if none is selected
            }
        }
    }
}
