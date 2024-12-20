﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; 
using System.IO; 
using System.Text; 

namespace WindowsFormsApp1
{
    public partial class frm_ItemLogs : Form
    {
        private readonly string connectionStringEDB;

        public frm_ItemLogs()
        {
            InitializeComponent();
            connectionStringEDB = ConfigurationManager.ConnectionStrings
                ["EquipmentInventoryDB"].ConnectionString;
            LoadLogsData();
        }

        // Method to load data from tbl_Logs and display in dgv_LogView
        private void LoadLogsData()
        {
            string query = "SELECT * FROM tbl_Logs"; 

            using (SqlConnection conn = new SqlConnection(connectionStringEDB))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable logsTable = new DataTable();
                    dataAdapter.Fill(logsTable); 

                    dgv_LogView.DataSource = logsTable; 
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while accessing the database: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void frm_ItemLogs_Load(object sender, EventArgs e)
        {
            if (ulog.Type == "A")
            {
                btn_Export.Visible = true;
            }
            else if (ulog.Type == "U")
            {
                btn_Export.Visible = false;
            }

            this.tbl_LogsTableAdapter.Fill(this.equipmentItemDBDataSet.tbl_Logs);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim(); 
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an item name to search.", "Input Required", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM tbl_Logs WHERE ItemName LIKE @SearchText"; 

            using (SqlConnection conn = new SqlConnection(connectionStringEDB))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable filteredTable = new DataTable();
                        dataAdapter.Fill(filteredTable); 

                        dgv_LogView.DataSource = filteredTable; 

                        if (filteredTable.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found matching the search criteria.", 
                                "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred while searching the database: " + ex.Message,
                        "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt user to select a folder to save the files
                FolderBrowserDialog folderDialog = new FolderBrowserDialog
                {
                    Description = "Select a folder to save exported files"
                };

                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderDialog.SelectedPath;

                    using (SqlConnection conn = new SqlConnection(connectionStringEDB))
                    {
                        conn.Open();

                        // Retrieve all table names from the database
                        DataTable schemaTable = conn.GetSchema("Tables");

                        foreach (DataRow row in schemaTable.Rows)
                        {
                            string tableName = row["TABLE_NAME"].ToString();

                            // Query all records from the table
                            string query = $"SELECT * FROM {tableName}";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Generate CSV content for the current table
                            StringBuilder csvContent = new StringBuilder();

                            // Add column headers
                            foreach (DataColumn column in dataTable.Columns)
                            {
                                csvContent.Append(column.ColumnName + ",");
                            }
                            csvContent.AppendLine();

                            // Add rows
                            foreach (DataRow dataRow in dataTable.Rows)
                            {
                                foreach (var item in dataRow.ItemArray)
                                {
                                    csvContent.Append(item.ToString().Replace(",", " ") + ",");
                                }
                                csvContent.AppendLine();
                            }

                            // Write content to CSV file
                            string filePath = Path.Combine(folderPath, $"{tableName}.csv");
                            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);

                            MessageBox.Show($"Exported table {tableName} to {filePath}", 
                                "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting records: " + ex.Message, "Export Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
