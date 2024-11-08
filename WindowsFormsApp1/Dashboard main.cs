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
    public partial class Dashboard_main : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\New folder\Equipment Inventory 11-8-2024\Equipment Inventory 10302024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True";

        public Dashboard_main()
        {
            InitializeComponent();
            UpdateTotalLabel();
            UpdateRentedItemsLabel();
            UpdateReturnedItemsLabel();
            monthCalendar1.DateSelected += new DateRangeEventHandler(monthCalendar1_DateSelected);
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start;
            LoadRentedItems(selectedDate);
            LoadReturnedItems(selectedDate);
        }

        private void LoadInventoryInfo()
        {/*
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\User\\Documents\\STI\\4th_YR_1st_Semester\\Capstone_2\\EIMS VS\\Equipment Inventory 1\\Equipment Inventory\\WindowsFormsApp1\\EquipmentItemDB.mdf\";Integrated Security=True"))
            {
                conn.Open();

                // Fetch total items
                SqlCommand cmdTotal = new SqlCommand("SELECT COUNT(*) FROM TblEquipmentItems", conn);
                int totalItems = (int)cmdTotal.ExecuteScalar();
                lblTotalItems.Text = $"Total Items: {totalItems}";

                // Fetch rented items
                SqlCommand cmdRented = new SqlCommand("SELECT COUNT(*) FROM TblRentItems WHERE Status = 'Rented'", conn);
                int rentedItems = (int)cmdRented.ExecuteScalar();
                lblRentedItems.Text = $"Rented Items: {rentedItems}";

                // Fetch returned items
                SqlCommand cmdReturned = new SqlCommand("SELECT COUNT(*) FROM TblRentItems WHERE Status = 'Returned'", conn);
                int returnedItems = (int)cmdReturned.ExecuteScalar();
                lblReturnedItems.Text = $"Returned Items: {returnedItems}";

                // Fetch items due soon (e.g., in the next 7 days)
                SqlCommand cmdDueSoon = new SqlCommand("SELECT COUNT(*) FROM TblRentItems WHERE DueDate BETWEEN GETDATE() AND DATEADD(DAY, 7, GETDATE())", conn);
                int dueSoonItems = (int)cmdDueSoon.ExecuteScalar();
                lblDueSoonItems.Text = $"Due Soon: {dueSoonItems}";
            }
        */
        }

        private void Dashboard_main_Load(object sender, EventArgs e)
        {
            LoadInventoryInfo();
        }
        private void UpdateTotalLabel()
        {
            int totalQuantity = GetTotalQuantity();
            lblTotalItems.Text = $"{totalQuantity}";
        }
        private int GetTotalQuantity()
        {
            int total = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Quantity) FROM TblEquipmentItems"; // Adjust 'Quantity' if needed
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    total = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return total;
        }
        private void UpdateRentedItemsLabel()
        {
            int totalRented = GetTotalRentedItems();
            lblRentedItems.Text = $"{totalRented}";
        }
        private int GetTotalRentedItems()
        {
            int total = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Quantity) FROM TblRentItems"; // Adjust 'Quantity' if needed
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    total = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return total;
        }
        private void UpdateReturnedItemsLabel()
        {
            int totalReturned = GetTotalReturnedItems();
            lblReturnedItems.Text = $"{totalReturned}";
        }
        private int GetTotalReturnedItems()
        {
            int total = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(Quantity) FROM TblReturnedItems"; // Adjust 'Quantity' if needed
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    total = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            return total;
        }
        private void LoadRentedItems(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Query for rented items on the selected date
                string rentedQuery = "SELECT * FROM TblRentItems WHERE CONVERT(DATE, RentDate) = @SelectedDate";

                SqlDataAdapter rentedAdapter = new SqlDataAdapter(rentedQuery, conn);
                rentedAdapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", date);
                DataTable rentedTable = new DataTable();
                rentedAdapter.Fill(rentedTable);

                // Bind rented items to dataGridViewRented
                dgvRentItems.DataSource = rentedTable;
            }
        }

        private void LoadReturnedItems(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Query for returned items on the selected date
                string returnedQuery = "SELECT * FROM TblReturnedItems WHERE CONVERT(DATE, ReturnDate) = @SelectedDate";

                SqlDataAdapter returnedAdapter = new SqlDataAdapter(returnedQuery, conn);
                returnedAdapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", date);
                DataTable returnedTable = new DataTable();
                returnedAdapter.Fill(returnedTable);

                // Bind returned items to dataGridViewReturned
                dgvReturnedItems.DataSource = returnedTable;
            }
        }
    }
}
