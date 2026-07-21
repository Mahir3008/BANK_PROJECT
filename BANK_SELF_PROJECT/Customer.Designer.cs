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
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_back);
            Name = "Customer";
            Text = "Customer";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
    }
}