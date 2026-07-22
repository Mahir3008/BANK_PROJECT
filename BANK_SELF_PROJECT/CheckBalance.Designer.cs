namespace BANK_SELF_PROJECT
{
    partial class CheckBalance
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
            check_balance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)check_balance).BeginInit();
            SuspendLayout();
            // 
            // check_balance
            // 
            check_balance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            check_balance.Location = new Point(12, 35);
            check_balance.Name = "check_balance";
            check_balance.RowHeadersWidth = 51;
            check_balance.Size = new Size(643, 353);
            check_balance.TabIndex = 0;
            // 
            // CheckBalance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 579);
            Controls.Add(check_balance);
            Name = "CheckBalance";
            Text = "CheckBalance";
            ((System.ComponentModel.ISupportInitialize)check_balance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView check_balance;
    }
}