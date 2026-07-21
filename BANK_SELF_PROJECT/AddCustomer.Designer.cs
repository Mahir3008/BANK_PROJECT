namespace BANK_SELF_PROJECT
{
    partial class AddCustomer
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
            Title = new Label();
            lbl_id = new Label();
            lbl_fullname = new Label();
            lbl_email = new Label();
            lbl_phone = new Label();
            lbl_address = new Label();
            lbl_balance = new Label();
            lbl_date = new Label();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            btn_clear = new Button();
            txt_userid = new TextBox();
            txt_fullname = new TextBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            txt_address = new TextBox();
            txt_balance = new TextBox();
            txt_date = new DateTimePicker();
            btn_back = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 12F);
            Title.Location = new Point(332, 22);
            Title.Name = "Title";
            Title.Size = new Size(138, 28);
            Title.TabIndex = 0;
            Title.Text = "Add Customer";
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 10F);
            lbl_id.Location = new Point(12, 103);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(64, 23);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "User Id";
            // 
            // lbl_fullname
            // 
            lbl_fullname.AutoSize = true;
            lbl_fullname.Font = new Font("Segoe UI", 10F);
            lbl_fullname.Location = new Point(12, 156);
            lbl_fullname.Name = "lbl_fullname";
            lbl_fullname.Size = new Size(87, 23);
            lbl_fullname.TabIndex = 2;
            lbl_fullname.Text = "Full Name";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 10F);
            lbl_email.Location = new Point(12, 220);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(51, 23);
            lbl_email.TabIndex = 3;
            lbl_email.Text = "Email";
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI", 10F);
            lbl_phone.Location = new Point(12, 277);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(59, 23);
            lbl_phone.TabIndex = 4;
            lbl_phone.Text = "Phone";
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 10F);
            lbl_address.Location = new Point(12, 338);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(70, 23);
            lbl_address.TabIndex = 5;
            lbl_address.Text = "Address";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Font = new Font("Segoe UI", 10F);
            lbl_balance.Location = new Point(12, 398);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(69, 23);
            lbl_balance.TabIndex = 6;
            lbl_balance.Text = "Balance";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Font = new Font("Segoe UI", 10F);
            lbl_date.Location = new Point(12, 465);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(111, 23);
            lbl_date.TabIndex = 7;
            lbl_date.Text = "Created Date";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.FlatAppearance.BorderColor = Color.Green;
            btn_add.FlatAppearance.BorderSize = 2;
            btn_add.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_add.ForeColor = Color.DarkGreen;
            btn_add.Location = new Point(332, 567);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(122, 42);
            btn_add.TabIndex = 8;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.White;
            btn_update.FlatAppearance.BorderColor = Color.Orange;
            btn_update.FlatAppearance.BorderSize = 2;
            btn_update.FlatAppearance.MouseOverBackColor = Color.Orange;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_update.ForeColor = Color.Orange;
            btn_update.Location = new Point(460, 567);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(122, 42);
            btn_update.TabIndex = 9;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.FlatAppearance.BorderColor = Color.Red;
            btn_delete.FlatAppearance.BorderSize = 2;
            btn_delete.FlatAppearance.MouseOverBackColor = Color.Red;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_delete.ForeColor = Color.Red;
            btn_delete.Location = new Point(588, 567);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(122, 42);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.White;
            btn_clear.FlatAppearance.BorderColor = Color.Gray;
            btn_clear.FlatAppearance.BorderSize = 2;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_clear.ForeColor = Color.Gray;
            btn_clear.Location = new Point(716, 567);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(122, 42);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // txt_userid
            // 
            txt_userid.Font = new Font("Segoe UI", 10F);
            txt_userid.Location = new Point(130, 99);
            txt_userid.Name = "txt_userid";
            txt_userid.Size = new Size(807, 30);
            txt_userid.TabIndex = 12;
            // 
            // txt_fullname
            // 
            txt_fullname.Font = new Font("Segoe UI", 10F);
            txt_fullname.Location = new Point(130, 152);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(807, 30);
            txt_fullname.TabIndex = 13;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.Location = new Point(130, 216);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(807, 30);
            txt_email.TabIndex = 14;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 10F);
            txt_phone.Location = new Point(130, 277);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(807, 30);
            txt_phone.TabIndex = 15;
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10F);
            txt_address.Location = new Point(130, 334);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(807, 30);
            txt_address.TabIndex = 16;
            // 
            // txt_balance
            // 
            txt_balance.Font = new Font("Segoe UI", 10F);
            txt_balance.Location = new Point(130, 394);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(807, 30);
            txt_balance.TabIndex = 17;
            // 
            // txt_date
            // 
            txt_date.Font = new Font("Segoe UI", 10F);
            txt_date.Location = new Point(130, 461);
            txt_date.Name = "txt_date";
            txt_date.Size = new Size(807, 30);
            txt_date.TabIndex = 18;
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 10F);
            btn_back.Location = new Point(786, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(151, 38);
            btn_back.TabIndex = 19;
            btn_back.Text = "Back To Main Screen";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(949, 621);
            Controls.Add(btn_back);
            Controls.Add(txt_date);
            Controls.Add(txt_balance);
            Controls.Add(txt_address);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_fullname);
            Controls.Add(txt_userid);
            Controls.Add(btn_clear);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(lbl_date);
            Controls.Add(lbl_balance);
            Controls.Add(lbl_address);
            Controls.Add(lbl_phone);
            Controls.Add(lbl_email);
            Controls.Add(lbl_fullname);
            Controls.Add(lbl_id);
            Controls.Add(Title);
            Name = "AddCustomer";
            Text = "AddCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lbl_id;
        private Label lbl_fullname;
        private Label lbl_email;
        private Label lbl_phone;
        private Label lbl_address;
        private Label lbl_balance;
        private Label lbl_date;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_clear;
        private TextBox txt_userid;
        private TextBox txt_fullname;
        private TextBox txt_email;
        private TextBox txt_phone;
        private TextBox txt_address;
        private TextBox txt_balance;
        private DateTimePicker txt_date;
        private Button btn_back;
    }
}