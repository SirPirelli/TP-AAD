namespace TP_AAD_Interface
{
    partial class ProductsManagement
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
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.tabelaDeProdutos = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AverageCount = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AtualizarArtigo = new System.Windows.Forms.Button();
            this.EliminarArtigo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDeProdutos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(48, 18);
            this.buttonMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(100, 40);
            this.buttonMainMenu.TabIndex = 1;
            this.buttonMainMenu.Text = "Back";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            // 
            // tabelaDeProdutos
            // 
            this.tabelaDeProdutos.AllowUserToResizeColumns = false;
            this.tabelaDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaDeProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.OwnerEmail,
            this.Description,
            this.Price});
            this.tabelaDeProdutos.Location = new System.Drawing.Point(365, 47);
            this.tabelaDeProdutos.MultiSelect = false;
            this.tabelaDeProdutos.Name = "tabelaDeProdutos";
            this.tabelaDeProdutos.ReadOnly = true;
            this.tabelaDeProdutos.RowTemplate.Height = 24;
            this.tabelaDeProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaDeProdutos.Size = new System.Drawing.Size(540, 483);
            this.tabelaDeProdutos.TabIndex = 2;
            this.tabelaDeProdutos.TabStop = false;
            this.tabelaDeProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OwnerEmail
            // 
            this.OwnerEmail.HeaderText = "OwnerEmail";
            this.OwnerEmail.Name = "OwnerEmail";
            this.OwnerEmail.ReadOnly = true;
            this.OwnerEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "List of Products in MarketPlace";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(51, 47);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(195, 17);
            this.labelAverage.TabIndex = 4;
            this.labelAverage.Text = "Average of Products by Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.AverageCount);
            this.groupBox1.Controls.Add(this.tabelaDeProdutos);
            this.groupBox1.Controls.Add(this.labelAverage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(187, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 544);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Percentage of users that sell products";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(58, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Most Sold Type of Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "No of Sales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Type of Product ID:";
            // 
            // AverageCount
            // 
            this.AverageCount.AutoSize = true;
            this.AverageCount.Location = new System.Drawing.Point(136, 81);
            this.AverageCount.Name = "AverageCount";
            this.AverageCount.Size = new System.Drawing.Size(26, 17);
            this.AverageCount.TabIndex = 5;
            this.AverageCount.Text = "No";
            this.AverageCount.Click += new System.EventHandler(this.AverageCount_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AtualizarArtigo);
            this.groupBox3.Controls.Add(this.EliminarArtigo);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(4, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 460);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Manipulation";
            // 
            // AtualizarArtigo
            // 
            this.AtualizarArtigo.Location = new System.Drawing.Point(44, 39);
            this.AtualizarArtigo.Name = "AtualizarArtigo";
            this.AtualizarArtigo.Size = new System.Drawing.Size(100, 275);
            this.AtualizarArtigo.TabIndex = 8;
            this.AtualizarArtigo.Text = "Update Item";
            this.AtualizarArtigo.UseVisualStyleBackColor = true;
            this.AtualizarArtigo.Click += new System.EventHandler(this.AtualizarArtigo_Click);
            // 
            // EliminarArtigo
            // 
            this.EliminarArtigo.Location = new System.Drawing.Point(44, 320);
            this.EliminarArtigo.Name = "EliminarArtigo";
            this.EliminarArtigo.Size = new System.Drawing.Size(100, 113);
            this.EliminarArtigo.TabIndex = 7;
            this.EliminarArtigo.Text = "Delete Item";
            this.EliminarArtigo.UseVisualStyleBackColor = true;
            this.EliminarArtigo.Click += new System.EventHandler(this.EliminarArtigo_Click);
            // 
            // ProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 548);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsManagement";
            this.Text = "ProductsManagement";
            ((System.ComponentModel.ISupportInitialize)(this.tabelaDeProdutos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.DataGridView tabelaDeProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label AverageCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button AtualizarArtigo;
        private System.Windows.Forms.Button EliminarArtigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}