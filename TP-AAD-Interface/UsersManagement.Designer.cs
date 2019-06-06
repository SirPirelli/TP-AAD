using System;
using System.Windows.Forms;

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
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonRegisterUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUserInfo = new System.Windows.Forms.Button();
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
            this.tableUsers.Location = new System.Drawing.Point(240, 33);
            this.tableUsers.Name = "tableUsers";
            this.tableUsers.Size = new System.Drawing.Size(443, 504);
            this.tableUsers.TabIndex = 0;
            this.tableUsers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableUsers_RowHeaderMouseClick);
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(0, 11);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(100, 35);
            this.buttonMainMenu.TabIndex = 1;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            // 
            // buttonRegisterUser
            // 
            this.buttonRegisterUser.Location = new System.Drawing.Point(0, 97);
            this.buttonRegisterUser.Name = "buttonRegisterUser";
            this.buttonRegisterUser.Size = new System.Drawing.Size(100, 35);
            this.buttonRegisterUser.TabIndex = 1;
            this.buttonRegisterUser.Text = "Register New User";
            this.buttonRegisterUser.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(0, 138);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(100, 35);
            this.buttonDeleteUser.TabIndex = 1;
            this.buttonDeleteUser.Text = "Delete User";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateUserInfo
            // 
            this.buttonUpdateUserInfo.Location = new System.Drawing.Point(0, 179);
            this.buttonUpdateUserInfo.Name = "buttonUpdateUserInfo";
            this.buttonUpdateUserInfo.Size = new System.Drawing.Size(100, 35);
            this.buttonUpdateUserInfo.TabIndex = 1;
            this.buttonUpdateUserInfo.Text = "Update User Info";
            this.buttonUpdateUserInfo.UseVisualStyleBackColor = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 57;
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
            this.Controls.Add(this.buttonUpdateUserInfo);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonRegisterUser);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.tableUsers);
            this.Name = "UsersManagement";
            this.Text = "Users Management";
            ((System.ComponentModel.ISupportInitialize)(this.tableUsers)).EndInit();
            this.ResumeLayout(false);

        }

       

        #endregion

        private System.Windows.Forms.DataGridView tableUsers;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonRegisterUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUserInfo;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn DOB;
        private DataGridViewTextBoxColumn ProductsSold;
        private DataGridViewTextBoxColumn ProductsBought;
    }
}