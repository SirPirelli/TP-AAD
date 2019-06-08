using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP_AAD_Interface
{
    public partial class UpdateItem : Form
    {
        int productIDValue = 0;
     


        public UpdateItem(int productID, string ownerEmail, string description, float price)
        {
            InitializeComponent();

            this.productIDValue = productID;
            textBox1.Text = ownerEmail.ToString();
            textBox2.Text = description.ToString();
            textBox3.Text = price.ToString();
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }

        private void ProductID_Click(object sender, EventArgs e)
        {

        }

        private void ProductIDValue_Click(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
         


        
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("UpdateProductInfo", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@OwnerEmail", SqlDbType.VarChar).Value = textBox1.Text;
                comm.Parameters.AddWithValue("@Description", SqlDbType.VarChar).Value = textBox2.Text;
                comm.Parameters.AddWithValue("@Price", SqlDbType.Float).Value = float.Parse(textBox3.Text);
                comm.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = productIDValue;
                using (SqlDataReader reader = comm.ExecuteReader()) 
                {
                    while (reader.Read())
                    {                          
                    }
                }
            }

            Button but = sender as Button;

            switch (but.Name)
            {
                case "UpdateButton":
                    Program.StartForm("ProductsManagement");
                    this.Close();
                    break;
                default:
                    break;
            }
        }   

        }

    }

