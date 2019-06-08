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

    public partial class ProductsManagement : Form
    {

        int productIdValue = -1;
      
        public ProductsManagement()
        {
            InitializeComponent();

            buttonMainMenu.Click += new EventHandler(ButtonClick);
            FillUsersProducts();
            SetUserAverageNumberOfproducts();
            SetsTypeProductStatistics();
            SetUserPieChart();
            AtualizarArtigo.Enabled = false;
         
            EliminarArtigo.Enabled = false;
         

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch(button.Name)
            {
                case "buttonMainMenu":
                    Program.StartForm("MainMenu");
                    break;

                case "UpdateButton":
                    Program.StartForm("ProductsManagement");
                    break;

                default:
                    break;
            }
        }




        private void FillUsersProducts()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select * from Product", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] newRow = {reader.GetInt32(0).ToString(), reader.GetString(1),
                                            reader.GetString(4), reader.GetFloat(5).ToString()};

                        tabelaDeProdutos.Rows.Add(newRow);
                    }
                }
            }
        }

        private void SetUserAverageNumberOfproducts()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand(" SELECT AverageNumberOfProducts= AVG(X.MyCount) FROM(Select Count(ProductID) AS MyCount from Inventory where Inventory.State = 1 group by Inventory.UserID)X  ", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String average = reader.GetInt32(0).ToString();
                        AverageCount.Text = average;


                    }
                }
            }
        }


        private void SetUserPieChart()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select Cast(Count(distinct Email) as decimal(6,4))/(Select Cast(Count(Distinct Email) as decimal(6,4)) FROM [User]) * 100 AS PercentageOfSellers From[User] Where ProductsSold > 0", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       float percentage =(float) reader.GetDecimal(reader.GetOrdinal("PercentageOfSellers"));

                        Dictionary<string, int> tags = new Dictionary<string, int>() {
            { "Sellers",(int) percentage },
            { "NonSellers", (int)(100-percentage) },

        };

                        chart1.Series[0].Points.Clear();
                        chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                        foreach (string tagname in tags.Keys)
                        {
                            chart1.Series[0].Points.AddXY(tagname, tags[tagname]);
                            //chart1.Series[0].IsValueShownAsLabel = true;
                        }

                        chart1.Titles.Add("Percentage");

                    }
                }
            }
        }



        private void SetsTypeProductStatistics()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select General.TopID, NumberOfSales=Max(General.NumberOfProductsSold) from ("+
" Select Sub.TypeProductID as TopID, Count(Sub.TypeProductID) as NumberOfProductsSold from(Select TypeOfProduct.ToPID AS TypeProductID from TypeOfProduct"+
" join Product on TypeOfProduct.ToPID = Product.ToPID"+
" join Inventory on Product.ProductID = Inventory.ProductID)Sub"+
" group by Sub.TypeProductID)General"+
" group by TopID"+
" having Max(General.NumberOfProductsSold) >= All("+
" Select Max(General.NumberOfProductsSold) from("+
" Select Sub.TypeProductID as TopID, Count(Sub.TypeProductID) as NumberOfProductsSold from(Select TypeOfProduct.ToPID AS TypeProductID from TypeOfProduct "+
" join Product on TypeOfProduct.ToPID = Product.ToPID"+
" join Inventory on Product.ProductID = Inventory.ProductID)Sub"+
" group by Sub.TypeProductID)General"+
" group by TopID)"

, conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        String[] BufferString = { reader.GetInt32(0).ToString(), reader.GetInt32(1).ToString() };
                        label4.Text = BufferString[0];
                        label5.Text = BufferString[1];

                    }
                }
            }
        }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AtualizarArtigo.Enabled = true;
            EliminarArtigo.Enabled = true;

            if (e.RowIndex >= 0)
            {


                int rowIndex = tabelaDeProdutos.CurrentRow.Index;
                MessageBox.Show(rowIndex.ToString());



           //     DataGridViewCell cell = (DataGridViewCell)tabelaDeProdutos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                productIdValue = rowIndex;
            //    tabelaDeProdutos.Refresh();

            }
      
        }


     





    private void AverageCount_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void EliminarArtigo_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                SqlCommand comm = new SqlCommand("DeleteProduct", conn);
                comm.CommandType = System.Data.CommandType.StoredProcedure;  
                comm.Parameters.AddWithValue("@ProductId", SqlDbType.Int).Value = productIdValue;
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    }
                }
            }
            tabelaDeProdutos.Refresh();
        }

        private void AtualizarArtigo_Click(object sender, EventArgs e)
        {


          int productInfo=0;
            string ownerEmail="";
            string description="";
            float price=0.0f;


            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select * from Product where ProductId="+(productIdValue+1)+"", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productInfo = reader.GetInt32(0);
                        ownerEmail= reader.GetString(1);
                        description= reader.GetString(4);
                        price=  reader.GetFloat(5);
                       


                    }
                }
            }




            Form UpdateItemw = new UpdateItem(productInfo,ownerEmail,description,price);
            
            UpdateItemw.Show();
        }
    }
}
