namespace BANK_SELF_PROJECT
{
    partial class Role
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            txt_role = new ComboBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 15F);
            Title.Location = new Point(318, 27);
            Title.Name = "Title";
            Title.Size = new Size(120, 35);
            Title.TabIndex = 0;
            Title.Text = "Your Role";
            // 
            // txt_role
            // 
            txt_role.Font = new Font("Segoe UI", 10F);
            txt_role.FormattingEnabled = true;
            txt_role.Items.AddRange(new object[] { "Admin", "Customer" });
            txt_role.Location = new Point(291, 118);
            txt_role.Name = "txt_role";
            txt_role.Size = new Size(200, 31);
            txt_role.TabIndex = 1;
            txt_role.SelectedIndexChanged += txt_role_SelectedIndexChanged;
            // 
            // Role
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_role);
            Controls.Add(Title);
            Name = "Role";
            Text = "Role";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private ComboBox txt_role;
    }
}
