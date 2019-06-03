namespace TP_AAD_Interface
{
    partial class MainMenu
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
            this.buttonUsersManag = new System.Windows.Forms.Button();
            this.buttonProductsManag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumUsersLabel = new System.Windows.Forms.Label();
            this.labelNumOfUsers = new System.Windows.Forms.Label();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.labelNumRegisteredCountriesLabel = new System.Windows.Forms.Label();
            this.labelNumAppProductsLabel = new System.Windows.Forms.Label();
            this.labelNumRegisteredCountries = new System.Windows.Forms.Label();
            this.labelNumAppProducts = new System.Windows.Forms.Label();
            this.groupBoxStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUsersManag
            // 
            this.buttonUsersManag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersManag.Location = new System.Drawing.Point(36, 69);
            this.buttonUsersManag.Name = "buttonUsersManag";
            this.buttonUsersManag.Size = new System.Drawing.Size(113, 75);
            this.buttonUsersManag.TabIndex = 0;
            this.buttonUsersManag.Text = "Users";
            this.buttonUsersManag.UseVisualStyleBackColor = true;
            // 
            // buttonProductsManag
            // 
            this.buttonProductsManag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProductsManag.Location = new System.Drawing.Point(36, 149);
            this.buttonProductsManag.Name = "buttonProductsManag";
            this.buttonProductsManag.Size = new System.Drawing.Size(113, 75);
            this.buttonProductsManag.TabIndex = 1;
            this.buttonProductsManag.Text = "Products";
            this.buttonProductsManag.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Management";
            // 
            // labelNumUsersLabel
            // 
            this.labelNumUsersLabel.AutoSize = true;
            this.labelNumUsersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumUsersLabel.Location = new System.Drawing.Point(6, 20);
            this.labelNumUsersLabel.Name = "labelNumUsersLabel";
            this.labelNumUsersLabel.Size = new System.Drawing.Size(118, 17);
            this.labelNumUsersLabel.TabIndex = 4;
            this.labelNumUsersLabel.Text = "Number Of Users";
            // 
            // labelNumOfUsers
            // 
            this.labelNumOfUsers.AutoSize = true;
            this.labelNumOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfUsers.Location = new System.Drawing.Point(9, 37);
            this.labelNumOfUsers.Name = "labelNumOfUsers";
            this.labelNumOfUsers.Size = new System.Drawing.Size(119, 31);
            this.labelNumOfUsers.TabIndex = 5;
            this.labelNumOfUsers.Text = "9999999";
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.labelNumRegisteredCountriesLabel);
            this.groupBoxStats.Controls.Add(this.labelNumAppProductsLabel);
            this.groupBoxStats.Controls.Add(this.labelNumUsersLabel);
            this.groupBoxStats.Controls.Add(this.labelNumRegisteredCountries);
            this.groupBoxStats.Controls.Add(this.labelNumAppProducts);
            this.groupBoxStats.Controls.Add(this.labelNumOfUsers);
            this.groupBoxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxStats.Location = new System.Drawing.Point(248, 43);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(220, 210);
            this.groupBoxStats.TabIndex = 6;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Stats";
            // 
            // labelNumRegisteredCountriesLabel
            // 
            this.labelNumRegisteredCountriesLabel.AutoSize = true;
            this.labelNumRegisteredCountriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRegisteredCountriesLabel.Location = new System.Drawing.Point(6, 144);
            this.labelNumRegisteredCountriesLabel.Name = "labelNumRegisteredCountriesLabel";
            this.labelNumRegisteredCountriesLabel.Size = new System.Drawing.Size(214, 17);
            this.labelNumRegisteredCountriesLabel.TabIndex = 4;
            this.labelNumRegisteredCountriesLabel.Text = "Number Of Registered Countries";
            // 
            // labelNumAppProductsLabel
            // 
            this.labelNumAppProductsLabel.AutoSize = true;
            this.labelNumAppProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumAppProductsLabel.Location = new System.Drawing.Point(6, 84);
            this.labelNumAppProductsLabel.Name = "labelNumAppProductsLabel";
            this.labelNumAppProductsLabel.Size = new System.Drawing.Size(202, 17);
            this.labelNumAppProductsLabel.TabIndex = 4;
            this.labelNumAppProductsLabel.Text = "Number Of Approved Products";
            // 
            // labelNumRegisteredCountries
            // 
            this.labelNumRegisteredCountries.AutoSize = true;
            this.labelNumRegisteredCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumRegisteredCountries.Location = new System.Drawing.Point(9, 161);
            this.labelNumRegisteredCountries.Name = "labelNumRegisteredCountries";
            this.labelNumRegisteredCountries.Size = new System.Drawing.Size(119, 31);
            this.labelNumRegisteredCountries.TabIndex = 5;
            this.labelNumRegisteredCountries.Text = "9999999";
            // 
            // labelNumAppProducts
            // 
            this.labelNumAppProducts.AutoSize = true;
            this.labelNumAppProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumAppProducts.Location = new System.Drawing.Point(9, 101);
            this.labelNumAppProducts.Name = "labelNumAppProducts";
            this.labelNumAppProducts.Size = new System.Drawing.Size(119, 31);
            this.labelNumAppProducts.TabIndex = 5;
            this.labelNumAppProducts.Text = "9999999";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 347);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProductsManag);
            this.Controls.Add(this.buttonUsersManag);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUsersManag;
        private System.Windows.Forms.Button buttonProductsManag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumUsersLabel;
        private System.Windows.Forms.Label labelNumOfUsers;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label labelNumAppProductsLabel;
        private System.Windows.Forms.Label labelNumAppProducts;
        private System.Windows.Forms.Label labelNumRegisteredCountriesLabel;
        private System.Windows.Forms.Label labelNumRegisteredCountries;
    }
}