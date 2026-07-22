using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace BANK_SELF_PROJECT
{
    public partial class Customer : Form
    {
        
        public Customer(string? userid)
        {
            InitializeComponent();
            checkUserid = userid ?? string.Empty;
        }
        private string checkUserid = string.Empty;
        private string ds = $"Data Source = {AppDomain.CurrentDomain.BaseDirectory}Bank_Self.db";

        private void btn_back_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userid = txt_userid.Text.Trim();
            string username = txt_username.Text.Trim();

            if (string.IsNullOrWhiteSpace(userid) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("All Fields Required", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqliteConnection conn = new SqliteConnection(ds))
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM Bank_Self WHERE USERID = @Userid AND FULLNAME = @Fullname";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Userid", userid);
                        cmd.Parameters.AddWithValue("@Fullname", username);

                        long userExists = (long)cmd.ExecuteScalar();

                        if (userExists > 0)
                        {
                            DashBoard board = new DashBoard(userid);
                            board.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid User ID or Username.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
