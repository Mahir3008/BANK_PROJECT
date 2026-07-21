namespace BANK_SELF_PROJECT
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_back = new Button();
            btn_check_customer = new Button();
            btn_del_customer = new Button();
            btn_add_customer = new Button();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F);
            btn_back.Location = new Point(290, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(207, 42);
            btn_back.TabIndex = 0;
            btn_back.Text = "Back To Home Page";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_check_customer
            // 
            btn_check_customer.Font = new Font("Segoe UI", 12F);
            btn_check_customer.Location = new Point(290, 82);
            btn_check_customer.Name = "btn_check_customer";
            btn_check_customer.Size = new Size(207, 42);
            btn_check_customer.TabIndex = 1;
            btn_check_customer.Text = "Check All Customer";
            btn_check_customer.UseVisualStyleBackColor = true;
            // 
            // btn_del_customer
            // 
            btn_del_customer.Font = new Font("Segoe UI", 12F);
            btn_del_customer.Location = new Point(290, 223);
            btn_del_customer.Name = "btn_del_customer";
            btn_del_customer.Size = new Size(207, 42);
            btn_del_customer.TabIndex = 2;
            btn_del_customer.Text = "Delete Customer";
            btn_del_customer.UseVisualStyleBackColor = true;
            // 
            // btn_add_customer
            // 
            btn_add_customer.Font = new Font("Segoe UI", 12F);
            btn_add_customer.Location = new Point(290, 161);
            btn_add_customer.Name = "btn_add_customer";
            btn_add_customer.Size = new Size(207, 42);
            btn_add_customer.TabIndex = 3;
            btn_add_customer.Text = "Add Customer";
            btn_add_customer.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_add_customer);
            Controls.Add(btn_del_customer);
            Controls.Add(btn_check_customer);
            Controls.Add(btn_back);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Button btn_check_customer;
        private Button btn_del_customer;
        private Button btn_add_customer;
    }
}