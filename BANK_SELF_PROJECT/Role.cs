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
                        Admin admin = new Admin();
                        admin.Show();
                        this.Hide();
                        break;
                    }
                case "Customer":
                    {
                        Customer customer = new Customer();
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
