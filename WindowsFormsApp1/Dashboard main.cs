using System;
using System.Configuration; // Add this for ConfigurationManager
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard_main : Form
    {
        private string connectionString;

        public Dashboard_main()
        {
            InitializeComponent();

            // Retrieve the connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["EquipmentInventoryDB"].ConnectionString;

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

        private void Dashboard_main_Load(object sender, EventArgs e)
        {
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
                string query = "SELECT SUM(Quantity) FROM TblEquipmentItems";
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
                string query = "SELECT SUM(Quantity) FROM TblRentItems";
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
                string query = "SELECT SUM(Quantity) FROM TblReturnedItems";
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

                string rentedQuery = "SELECT * FROM TblRentItems WHERE CONVERT(DATE, RentDate) = @SelectedDate";
                SqlDataAdapter rentedAdapter = new SqlDataAdapter(rentedQuery, conn);
                rentedAdapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", date);
                DataTable rentedTable = new DataTable();
                rentedAdapter.Fill(rentedTable);

                dgvRentItems.DataSource = rentedTable;
            }
        }

        private void LoadReturnedItems(DateTime date)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string returnedQuery = "SELECT * FROM TblReturnedItems WHERE CONVERT(DATE, ReturnDate) = @SelectedDate";
                SqlDataAdapter returnedAdapter = new SqlDataAdapter(returnedQuery, conn);
                returnedAdapter.SelectCommand.Parameters.AddWithValue("@SelectedDate", date);
                DataTable returnedTable = new DataTable();
                returnedAdapter.Fill(returnedTable);

                dgvReturnedItems.DataSource = returnedTable;
            }
        }
    }
}
