namespace TP_AAD_Interface
{
    partial class UsersManagement
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
            this.tableUsers = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsBought = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tableUsers
            // 
            this.tableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Email,
            this.DOB,
            this.ProductsSold,
            this.ProductsBought});
            this.tableUsers.Location = new System.Drawing.Point(205, 33);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.Size = new System.Drawing.Size(478, 504);
            this.tableUsers.TabIndex = 0;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // DOB
            // 
            this.DOB.HeaderText = "DOB";
            this.DOB.Name = "DOB";
            // 
            // ProductsSold
            // 
            this.ProductsSold.HeaderText = "Products Sold";
            this.ProductsSold.Name = "ProductsSold";
            // 
            // ProductsBought
            // 
            this.ProductsBought.HeaderText = "Products Bought";
            this.ProductsBought.Name = "ProductsBought";
            // 
            // UsersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 549);
            this.Controls.Add(this.tableUsers);
            this.Name = "UsersManagement";
            this.Text = "UsersManagement";
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsBought;
    }
}