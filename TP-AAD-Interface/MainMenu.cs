using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            labelNumAppProducts.Text = GetNumOfApprovedProducts(Form1.sqlConnection).ToString();
            labelNumOfUsers.Text = GetNumOfUsers(Form1.sqlConnection).ToString();
            labelNumRegisteredCountries.Text = GetNumOfRegisteredCountries(Form1.sqlConnection).ToString();

            buttonUsersManag.Click += new EventHandler(ButtonClickMainMenu);
            buttonProductsManag.Click += new EventHandler(ButtonClickMainMenu);
        }

        int GetNumOfApprovedProducts(SqlConnection sqlConnection)
        {
            int res = -1;
            
            sqlConnection.Open();

            using (SqlCommand comm = new SqlCommand("Select Count(distinct ProductID) From Product", sqlConnection))
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    res = reader.GetInt32(0);
                }
            }

            sqlConnection.Close();

            return res;
        }

        int GetNumOfUsers(SqlConnection sqlConnection)
        {
            int res = -1;

            sqlConnection.Open();

            using (SqlCommand comm = new SqlCommand("Select Count(distinct Email) From [User]", sqlConnection))
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    res = reader.GetInt32(0);
                }
            }

            sqlConnection.Close();

            return res;
        }

        int GetNumOfRegisteredCountries(SqlConnection sqlConnection)
        {
            int res = -1;

            sqlConnection.Open();
            
            using (SqlCommand comm = new SqlCommand("Select Count(distinct Country) FROM PaymentData", sqlConnection))
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while (reader.Read())
                {
                    res = reader.GetInt32(0);
                }
            }

            sqlConnection.Close();

            return res;
            
        }

        private void ButtonClickMainMenu(object sender, EventArgs e)
        {

           Button btn = sender as Button;

           switch(btn.Name)
            {
                case "buttonUsersManag":
                    Program.StartForm("UsersManagement");
                    break;

                case "buttonProductsManag":
                    Program.StartForm("ProductsManagement");
                    break;
            }
        }

        ~MainMenu()
        {
            buttonUsersManag.Click -= new EventHandler(ButtonClickMainMenu);
            buttonProductsManag.Click -= new EventHandler(ButtonClickMainMenu);
        }
    }
}
