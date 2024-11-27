using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Settings : Form
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;

        public frm_Settings()
        {
            InitializeComponent();
            DatabaseConnection();
        }
      

        private void DatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.uaDBConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            if (ulog.Type == "A")
            {
                adduseradmin.Visible = true;
            }
            else if (ulog.Type == "U")
            {
                adduseradmin.Visible = false;
            }
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);
           
            dgv_adminuser.Refresh();
        }

        private void Edit(bool value)
        {
            txt_userName.Enabled = value;
            txt_password.Enabled = value;
            cb_role.Enabled = value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                // Clear input fields for new entry
                txt_userName.Clear();
                txt_password.Clear();
                cb_role.SelectedIndex = -1; // Or set to a default value if necessary
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast();
                txt_userName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dgv_adminuser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_adminuser.SelectedRows[0];

                // Safely retrieve cell values and populate fields
                if (selectedRow.Cells["Username"].Value != null)
                    txt_userName.Text = selectedRow.Cells["Username"].Value.ToString();
                if (selectedRow.Cells["Password"].Value != null)
                    txt_password.Text = selectedRow.Cells["Password"].Value.ToString();
                if (selectedRow.Cells["Role"].Value != null)
                    cb_role.Text = selectedRow.Cells["Role"].Value.ToString();

                // Enable editing
                Edit(true);
                txt_userName.Focus();
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                conn.Open();

                string query;
                int records;

                if (dgv_adminuser.SelectedRows.Count > 0)
                {
                    // Updating existing record
                    int selectedId = Convert.ToInt32(dgv_adminuser.SelectedRows[0].Cells["Id"].Value);

                    // Fetch the record to confirm it exists
                    query = "SELECT COUNT(*) FROM tbllog WHERE Id = @Id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    int exists = (int)cmd.ExecuteScalar();

                    if (exists == 0)
                    {
                        MessageBox.Show("The record no longer exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Proceed to update
                    query = "UPDATE tbllog SET Username = @Username, Password = @Password, Role = @Role WHERE Id = @Id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txt_userName.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@Role", cb_role.Text);
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                }
                else
                {
                    // Inserting new record
                    query = "INSERT INTO tbllog (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txt_userName.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@Role", cb_role.Text);
                }

                records = cmd.ExecuteNonQuery();

                if (records > 0)
                {
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the DataGridView and reset controls
                    tbllogTableAdapter.Fill(appData.tbllog);
                    dgv_adminuser.Refresh();
                    Edit(false);
                }
                else
                {
                    MessageBox.Show("No records were affected. Please check your input.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_adminuser.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        // Get the selected row
                        DataGridViewRow selectedRow = dgv_adminuser.SelectedRows[0];

                        // Retrieve the Id from the hidden column
                        int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value); // Assuming you have an Id column that is hidden

                        string query = "DELETE FROM tbllog WHERE Id = @Id";
                        conn.Open();
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Id", selectedId); // Use the Id parameter for the delete

                        int records = cmd.ExecuteNonQuery();
                        if (records > 0)
                        {
                            MessageBox.Show("The record has been successfully deleted.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No records were deleted. Please check if the record exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        // Remove the current item from the BindingSource
                        tbllogBindingSource.RemoveCurrent();

                        // Refresh the DataGridView
                        tbllogTableAdapter.Fill(appData.tbllog);
                        dgv_adminuser.Refresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        dgv_adminuser.Refresh();
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChangePasswordforUser_Click(object sender, EventArgs e)
        {
            // Assuming you have a way to get the current user's username
            string currentUsername = ulog.Username; // Adjust this according to your actual user management

            // Prompt the user for their current password and new password
            string currentPassword = PromptForPassword("Enter your current password:");
            if (string.IsNullOrEmpty(currentPassword))
            {
                MessageBox.Show("Current password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = PromptForPassword("Enter your new password:");
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("New password cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the current password is correct
            string query = "SELECT COUNT(*) FROM tbllog WHERE Username = @Username AND Password = @Password";
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Username", currentUsername);
            cmd.Parameters.AddWithValue("@Password", currentPassword);

            int userExists = (int)cmd.ExecuteScalar();
            if (userExists == 0)
            {
                MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
                return;
            }

            // Update the password in the database
            query = "UPDATE tbllog SET Password = @NewPassword WHERE Username = @Username";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@NewPassword", newPassword);
            cmd.Parameters.AddWithValue("@Username", currentUsername);

            int recordsAffected = cmd.ExecuteNonQuery();
            if (recordsAffected > 0)
            {
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password change failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conn.Close();
        }

        private string PromptForPassword(string message)
        {
            // Use a simple input dialog to get the password (you can customize this)
            using (Form prompt = new Form())
            {
                prompt.Width = 300;
                prompt.Height = 170;
                prompt.Text = "Enter Password";

                Label textLabel = new Label() { Left = 20, Top = 20, Width = 260, Text = message };
                TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 260, PasswordChar = '*' };
                Button confirmation = new Button() { Text = "Ok", Left = 100, Width = 100, Top = 90, DialogResult = DialogResult.OK };

                confirmation.Click += (sender, e) => { prompt.Close(); };
                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
            }
        }
    }
}
