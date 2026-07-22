namespace BANK_SELF_PROJECT
{
    partial class Customer
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
            lbl_userid = new Label();
            lbl_username = new Label();
            txt_userid = new TextBox();
            txt_username = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Font = new Font("Segoe UI", 12F);
            btn_back.Location = new Point(290, 12);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(207, 42);
            btn_back.TabIndex = 1;
            btn_back.Text = "Back To Home Page";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // lbl_userid
            // 
            lbl_userid.AutoSize = true;
            lbl_userid.Location = new Point(277, 126);
            lbl_userid.Name = "lbl_userid";
            lbl_userid.Size = new Size(55, 20);
            lbl_userid.TabIndex = 2;
            lbl_userid.Text = "User Id";
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(277, 222);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(82, 20);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "User Name";
            // 
            // txt_userid
            // 
            txt_userid.Font = new Font("Segoe UI", 10F);
            txt_userid.Location = new Point(371, 119);
            txt_userid.Name = "txt_userid";
            txt_userid.Size = new Size(187, 30);
            txt_userid.TabIndex = 4;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 10F);
            txt_username.Location = new Point(371, 212);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(187, 30);
            txt_username.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 10F);
            btn_login.Location = new Point(371, 280);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(187, 40);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_login);
            Controls.Add(txt_username);
            Controls.Add(txt_userid);
            Controls.Add(lbl_username);
            Controls.Add(lbl_userid);
            Controls.Add(btn_back);
            Name = "Customer";
            Text = "Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private Label lbl_userid;
        private Label lbl_username;
        private TextBox txt_userid;
        private TextBox txt_username;
        private Button btn_login;
    }
}