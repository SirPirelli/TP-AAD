using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    public partial class UsersManagement : Form
    {
        public UsersManagement()
        {
            InitializeComponent();

            buttonMainMenu.Click += new EventHandler(ButtonClick);
            buttonRegisterUser.Click += new EventHandler(ButtonClick);

            FillUsersTable();
            

        }

        private void FillUsersTable()
        {
            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select * from [User]", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] newRow = {reader.GetString(0), reader.GetDateTime(1).Date.ToString(),
                                            reader.GetInt32(3).ToString(), reader.GetInt32(4).ToString()};

                        tableUsers.Rows.Add(newRow);
                    }
                }
            }
        }


        








        private void ButtonClick(object sender, EventArgs e)
        {
            Button but = sender as Button;

            switch(but.Name)
            {
                case "buttonMainMenu":
                    Program.StartForm("MainMenu");
                    break;

                case "buttonRegisterUser":
                    RegisterUser registerUser = new RegisterUser(this);
                    registerUser.Show();
                    this.Enabled = false;
                    break;

                default:
                    break;
            }


        }

        
    }
}
