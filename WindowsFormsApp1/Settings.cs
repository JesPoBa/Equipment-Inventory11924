using System;
using System.Configuration;
using System.Data.SqlClient;
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
            if (ulog.type == "A")
            {
                adduseradmin.Visible = true;
            }
            else if (ulog.type == "U")
            {
                adduseradmin.Visible = false;
            }
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);

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
            // Check if there is a selected row in the DataGridView
            if (dgv_adminuser.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_adminuser.SelectedRows[0];

                // Check if the expected columns exist
                if (selectedRow.Cells["Username"] != null && selectedRow.Cells["Password"] != null && selectedRow.Cells["Role"] != null)
                {
                    txt_userName.Text = selectedRow.Cells["Username"].Value.ToString();
                    txt_password.Text = selectedRow.Cells["Password"].Value.ToString();
                    cb_role.Text = selectedRow.Cells["Role"].Value.ToString();

                    Edit(true);
                    txt_userName.Focus();
                }
                else
                {
                    MessageBox.Show("One or more expected columns are missing in the selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if we are editing an existing record
                if (dgv_adminuser.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dgv_adminuser.SelectedRows[0];

                    // Retrieve the Id from the hidden column
                    int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value); // Assuming you have an Id column that is hidden

                    string query = "UPDATE tbllog SET Username = @Username, Password = @Password, Role = @Role WHERE Id = @Id";
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txt_userName.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@Role", cb_role.Text);
                    cmd.Parameters.AddWithValue("@Id", selectedId); // Use the Id parameter for the update

                    int records = cmd.ExecuteNonQuery();
                    if (records > 0)
                    {
                        MessageBox.Show("Your data has been successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No records were updated. Please check the values.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Insert new record
                    string query = "INSERT INTO tbllog (Username, Password, Role) VALUES (@Username, @Password, @Role)";
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txt_userName.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@Role", cb_role.Text);
                    int records = cmd.ExecuteNonQuery();
                    MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Reset the form
                Edit(false);
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txt_userName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
            finally
            {
                conn.Close();
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

        private void btn_ChangeProfilePicture_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox_ProfilePicture.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
