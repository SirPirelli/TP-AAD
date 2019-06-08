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
            labelNumAppProducts.Text = GetNumOfApprovedProducts().ToString();
            labelNumOfUsers.Text = GetNumOfUsers().ToString();
            labelNumRegisteredCountries.Text = GetNumOfRegisteredCountries().ToString();

            buttonUsersManag.Click += new EventHandler(ButtonClickMainMenu);
            buttonProductsManag.Click += new EventHandler(ButtonClickMainMenu);
        }

        int GetNumOfApprovedProducts()
        {

            using (SqlConnection conn = new SqlConnection("Data Source= (local);" +
                                            "Initial Catalog=MyFirstDataBase;" +
                                            "Integrated Security=SSPI;"))
            {
                conn.Open();
                Console.WriteLine(conn.State);
                Console.WriteLine(conn.ConnectionString);
                using (SqlCommand comm = new SqlCommand("Select Count(distinct ProductID) From Product", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return 99999;
            }
        }

        int GetNumOfUsers()
        {
            using (SqlConnection conn = new SqlConnection("Data Source= (local);" +
                                            "Initial Catalog=MyFirstDataBase;" +
                                            "Integrated Security=SSPI;"))
            {
                conn.Open();
                Console.WriteLine(conn.State);
                Console.WriteLine(conn.ConnectionString);
                using (SqlCommand comm = new SqlCommand("Select Count(distinct Email) From [User]", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return 99999;
            }
        }

        int GetNumOfRegisteredCountries()
        {
            using (SqlConnection conn = new SqlConnection("Data Source= (local);" +
                                            "Initial Catalog=MyFirstDataBase;" +
                                            "Integrated Security=SSPI;"))
            {
                conn.Open();
                Console.WriteLine(conn.State);
                Console.WriteLine(conn.ConnectionString);
                using (SqlCommand comm = new SqlCommand("Select Count(distinct Country) FROM PaymentData", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }

                return 99999;
            }
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
