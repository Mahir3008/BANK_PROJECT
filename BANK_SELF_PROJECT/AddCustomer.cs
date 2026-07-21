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
                MessageBox.Show("All Fields Required","Fil All Details",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
        }
    }
}
