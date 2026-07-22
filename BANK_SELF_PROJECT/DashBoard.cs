using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BANK_SELF_PROJECT
{
    public partial class DashBoard : Form
    {
        public DashBoard(string userid)
        {
            InitializeComponent();
            checkUserid = userid;
        }
        private string checkUserid = string.Empty;

        private void btn_back_Click(object sender, EventArgs e)
        {
            Role role = new Role();
            role.Show();
            this.Hide();
        }

        private void btn_check_balance_Click(object sender, EventArgs e)
        {
            
            panel_main.Controls.Clear();
            CheckBalance balance = new CheckBalance(checkUserid);
            balance.TopLevel = false;
            balance.FormBorderStyle = FormBorderStyle.None;
            balance.Dock = DockStyle.Fill;
            panel_main.Controls.Add(balance);
            balance.Show();
        }
    }
}
