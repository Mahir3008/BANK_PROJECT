using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace BANK_SELF_PROJECT
{
    public partial class Role : Form
    {
        public Role()
        {
            InitializeComponent();
        }

        private void txt_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            string role = txt_role.SelectedItem.ToString();
            if (string.IsNullOrEmpty(role))
            
                return;
            
            switch (role)
            {
                case "Admin":
                    {
                         string pass = Interaction.InputBox("Please Enter the admin password to continue");
                        if (pass == "Admin123")
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Hide();
                        }
                        if (!(pass == "Admin123"))
                        {
                            MessageBox.Show("Wrong Password","Please type correct password",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                        break;
                    }
                case "Customer":
                    {
                        Customer customer = new Customer(string.Empty);
                        customer.Show();
                        this.Hide();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Please Select a valid option","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        break;
                    }
            }
        }
    }
}
