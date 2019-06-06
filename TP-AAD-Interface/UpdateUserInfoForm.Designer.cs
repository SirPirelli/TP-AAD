namespace TP_AAD_Interface
{
    partial class UpdateUserInfoForm
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
            this.labelLastEmail = new System.Windows.Forms.Label();
            this.labelEmaillabel = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLastEmail
            // 
            this.labelLastEmail.AutoSize = true;
            this.labelLastEmail.Location = new System.Drawing.Point(58, 25);
            this.labelLastEmail.Name = "labelLastEmail";
            this.labelLastEmail.Size = new System.Drawing.Size(29, 13);
            this.labelLastEmail.TabIndex = 0;
            this.labelLastEmail.Text = "User";
            // 
            // labelEmaillabel
            // 
            this.labelEmaillabel.AutoSize = true;
            this.labelEmaillabel.Location = new System.Drawing.Point(122, 25);
            this.labelEmaillabel.Name = "labelEmaillabel";
            this.labelEmaillabel.Size = new System.Drawing.Size(57, 13);
            this.labelEmaillabel.TabIndex = 0;
            this.labelEmaillabel.Text = "New Email";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(9, 65);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "New Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 20);
            this.textBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(125, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New DOB";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(137, 143);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // UpdateUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 188);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmaillabel);
            this.Controls.Add(this.labelLastEmail);
            this.Name = "UpdateUserInfoForm";
            this.Text = "UpdateUserInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLastEmail;
        private System.Windows.Forms.Label labelEmaillabel;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
    }
}