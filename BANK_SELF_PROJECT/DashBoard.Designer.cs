namespace BANK_SELF_PROJECT
{
    partial class DashBoard
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
            panel_left = new Panel();
            btn_check_balance = new Button();
            panel_main = new Panel();
            panel_top = new Panel();
            panel_left.SuspendLayout();
            panel_top.SuspendLayout();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(687, 3);
            btn_back.Name = "btn_back";
            btn_back.RightToLeft = RightToLeft.No;
            btn_back.Size = new Size(225, 33);
            btn_back.TabIndex = 0;
            btn_back.Text = "Back To the Main Screen";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // panel_left
            // 
            panel_left.Controls.Add(btn_check_balance);
            panel_left.Dock = DockStyle.Left;
            panel_left.Location = new Point(0, 0);
            panel_left.Name = "panel_left";
            panel_left.Size = new Size(190, 660);
            panel_left.TabIndex = 1;
            // 
            // btn_check_balance
            // 
            btn_check_balance.Font = new Font("Segoe UI", 10F);
            btn_check_balance.Location = new Point(3, 12);
            btn_check_balance.Name = "btn_check_balance";
            btn_check_balance.Size = new Size(184, 33);
            btn_check_balance.TabIndex = 0;
            btn_check_balance.Text = "Check Balance";
            btn_check_balance.UseVisualStyleBackColor = true;
            btn_check_balance.Click += btn_check_balance_Click;
            // 
            // panel_main
            // 
            panel_main.Dock = DockStyle.Fill;
            panel_main.Location = new Point(190, 0);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(924, 660);
            panel_main.TabIndex = 2;
            // 
            // panel_top
            // 
            panel_top.Controls.Add(btn_back);
            panel_top.Dock = DockStyle.Top;
            panel_top.Location = new Point(190, 0);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(924, 45);
            panel_top.TabIndex = 3;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 660);
            Controls.Add(panel_top);
            Controls.Add(panel_main);
            Controls.Add(panel_left);
            Name = "DashBoard";
            Text = "DashBoard";
            panel_left.ResumeLayout(false);
            panel_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_back;
        private Panel panel_left;
        private Button btn_check_balance;
        private Panel panel_main;
        private Panel panel_top;
    }
}