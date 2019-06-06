namespace TP_AAD_Interface
{
    partial class DeleteUserForm
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
            this.labelDescricao = new System.Windows.Forms.Label();
            this.buttonSim = new System.Windows.Forms.Button();
            this.buttonNao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(102, 40);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(304, 13);
            this.labelDescricao.TabIndex = 0;
            this.labelDescricao.Text = "Tem a certeza que quer eliminar os utilizadores seleccionados?";
            // 
            // buttonSim
            // 
            this.buttonSim.Location = new System.Drawing.Point(143, 91);
            this.buttonSim.Name = "buttonSim";
            this.buttonSim.Size = new System.Drawing.Size(75, 23);
            this.buttonSim.TabIndex = 1;
            this.buttonSim.Text = "Sim";
            this.buttonSim.UseVisualStyleBackColor = true;
            // 
            // buttonNao
            // 
            this.buttonNao.Location = new System.Drawing.Point(270, 91);
            this.buttonNao.Name = "buttonNao";
            this.buttonNao.Size = new System.Drawing.Size(75, 23);
            this.buttonNao.TabIndex = 1;
            this.buttonNao.Text = "Não";
            this.buttonNao.UseVisualStyleBackColor = true;
            // 
            // DeleteUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 155);
            this.Controls.Add(this.buttonNao);
            this.Controls.Add(this.buttonSim);
            this.Controls.Add(this.labelDescricao);
            this.Name = "DeleteUserForm";
            this.Text = "DeleteUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Button buttonSim;
        private System.Windows.Forms.Button buttonNao;
    }
}