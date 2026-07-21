using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BANK_SELF_PROJECT
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            ShowUsersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ShowUsersGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private string ds = $"Data Source = {AppDomain.CurrentDomain.BaseDirectory}Bank_Self.db";
        private void btn_back_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
            this.Hide();
        }

        private void btn_check_customer_Click(object sender, EventArgs e)
        {
            main_panel.Controls.Clear();

            try
            {
                using (SqliteConnection conn = new SqliteConnection(ds))
                {
                    conn.Open();
                    string query = $"SELECT * FROM Bank_Self";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        using (SqliteDataReader Datareader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(Datareader);
                            ShowUsersGrid.DataSource = dt;
                            main_panel.Controls.Add(ShowUsersGrid);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            AddCustomer customer = new AddCustomer();
            customer.Show();
            this.Hide();
        }
    }
}
