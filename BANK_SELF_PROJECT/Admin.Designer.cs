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
            main_panel = new Panel();
            ShowUsersGrid = new DataGridView();
            main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShowUsersGrid).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F);
            btn_back.Location = new Point(12, 12);
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
            btn_check_customer.Location = new Point(225, 12);
            btn_check_customer.Name = "btn_check_customer";
            btn_check_customer.Size = new Size(207, 42);
            btn_check_customer.TabIndex = 1;
            btn_check_customer.Text = "Check All Customer";
            btn_check_customer.UseVisualStyleBackColor = true;
            btn_check_customer.Click += btn_check_customer_Click;
            // 
            // btn_del_customer
            // 
            btn_del_customer.Font = new Font("Segoe UI", 12F);
            btn_del_customer.Location = new Point(651, 12);
            btn_del_customer.Name = "btn_del_customer";
            btn_del_customer.Size = new Size(207, 42);
            btn_del_customer.TabIndex = 2;
            btn_del_customer.Text = "Delete Customer";
            btn_del_customer.UseVisualStyleBackColor = true;
            // 
            // btn_add_customer
            // 
            btn_add_customer.Font = new Font("Segoe UI", 12F);
            btn_add_customer.Location = new Point(438, 12);
            btn_add_customer.Name = "btn_add_customer";
            btn_add_customer.Size = new Size(207, 42);
            btn_add_customer.TabIndex = 3;
            btn_add_customer.Text = "Add Customer";
            btn_add_customer.UseVisualStyleBackColor = true;
            btn_add_customer.Click += btn_add_customer_Click;
            // 
            // main_panel
            // 
            main_panel.Controls.Add(ShowUsersGrid);
            main_panel.Location = new Point(12, 60);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1443, 656);
            main_panel.TabIndex = 4;
            // 
            // ShowUsersGrid
            // 
            ShowUsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ShowUsersGrid.Location = new Point(37, 40);
            ShowUsersGrid.Name = "ShowUsersGrid";
            ShowUsersGrid.RowHeadersWidth = 51;
            ShowUsersGrid.Size = new Size(1403, 590);
            ShowUsersGrid.TabIndex = 0;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1467, 794);
            Controls.Add(main_panel);
            Controls.Add(btn_add_customer);
            Controls.Add(btn_del_customer);
            Controls.Add(btn_check_customer);
            Controls.Add(btn_back);
            Name = "Admin";
            Text = "Admin";
            main_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ShowUsersGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Button btn_check_customer;
        private Button btn_del_customer;
        private Button btn_add_customer;
        private Panel main_panel;
        private DataGridView ShowUsersGrid;
    }
}