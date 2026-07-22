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
    public partial class CheckBalance : Form
    {
        public CheckBalance(string userid)
        {
            InitializeComponent();
            checkUserid = userid;
            checkBalance();
        }
        private string checkUserid;
        private string ds = $"Data Source = {AppDomain.CurrentDomain.BaseDirectory}Bank_Self.db";

        public void checkBalance()
        {
            try
            {
                using (SqliteConnection conn = new SqliteConnection(ds))
                { 
                    conn.Open();
                    string query = $"SELECT BALANCE FROM Bank_Self WHERE USERID = @Userid";

                    using (SqliteCommand cmd = new SqliteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Userid",checkUserid);

                        using (SqliteDataReader reader = cmd.ExecuteReader())
                        { 
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            check_balance.DataSource = dt;
                            check_balance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            check_balance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
