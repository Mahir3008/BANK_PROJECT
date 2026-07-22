using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;


namespace BANK_SELF_PROJECT
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }
        private string ds = $"Data Source = {AppDomain.CurrentDomain.BaseDirectory}Bank_Self.db";
        private void btn_add_Click(object sender, EventArgs e)
        {
            string id = txt_userid.Text.Trim();
            string fullname = txt_fullname.Text.Trim();
            string email = txt_email.Text.Trim();
            string phone = txt_phone.Text.Trim();
            string address = txt_address.Text.Trim();
            string balance = txt_balance.Text.Trim();
            string date = txt_date.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(fullname) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(balance) ||
                string.IsNullOrWhiteSpace(date))

            {
                MessageBox.Show("All Fields Required", "Fil All Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqliteConnection conn = new SqliteConnection(ds))
            {
                conn.Open();
                try
                {
                    string createTable = @"CREATE TABLE IF NOT EXISTS Bank_Self(
                                 ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                 USERID TEXT UNIQUE NOT NULL,
                                 FULLNAME TEXT NOT NULL,
                                 EMAIL TEXT NOT NULL,
                                 PHONE TEXT NOT NULL,
                                 ADDRESS TEXT NOT NULL,
                                 BALANCE REAL NOT NULL,
                                 DATE TEXT NOT NULL);";

                    using (SqliteCommand table = new SqliteCommand(createTable, conn))
                    {
                        table.ExecuteNonQuery();
                    }

                    string insertQuery = $"INSERT INTO Bank_Self(USERID,FULLNAME,EMAIL,PHONE,ADDRESS,BALANCE,DATE)" +
                        $"VALUES(@Userid,@Fullname,@Email,@Phone,@Address,@Balance,@Date)";

                    using (SqliteCommand cmd = new SqliteCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Userid", id);
                        cmd.Parameters.AddWithValue("@Fullname", fullname);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        //cmd.Parameters.AddWithValue("@Balance", balance);
                        cmd.Parameters.AddWithValue("@Date", date);

                        double Balance = Convert.ToDouble(balance);
                        cmd.Parameters.AddWithValue("@Balance", Balance);

                        int success = cmd.ExecuteNonQuery();
                        if (success > 0)
                        {
                            MessageBox.Show("Customer Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
            this.Hide();
        }
    }
}

