using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    public partial class UsersManagement : Form
    {
        public struct UserData
        {
            public string email;
            public string password;
            public DateTime dob;
            public int productsSold;
            public int productsBought;
        }

        public UsersManagement()
        {
            InitializeComponent();

            buttonMainMenu.Click += new EventHandler(ButtonClick);
            buttonRegisterUser.Click += new EventHandler(ButtonClick);
            buttonDeleteUser.Click += new EventHandler(ButtonClick);
            buttonUpdateUserInfo.Click += new EventHandler(ButtonClick);

            buttonDeleteUser.Visible = false;
            buttonUpdateUserInfo.Visible = false;

            FillUsersTable();

        }

        public void DeleteSelectedRows()
        {

            var enu = tableUsers.SelectedRows.GetEnumerator();

            while (enu.MoveNext())
            {
                DataGridViewRow row = enu.Current as DataGridViewRow;
                string email = row.Cells[0].Value.ToString();

                DeleteUser(Form1.sqlConnection, email);
            }

        }

        private void FillUsersTable()
        {
            tableUsers.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select * from [User]", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string[] newRow = {reader.GetString(0), reader.GetDateTime(1).Date.ToShortDateString(),
                                            reader.GetInt32(3).ToString(), reader.GetInt32(4).ToString()};

                        tableUsers.Rows.Add(newRow);
                    }
                }
            }
        }

        public static UserData GetUserData(SqlConnection sqlConnection, string email)
        {
            UserData data = new UserData();
            
            try
            {
                sqlConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return data;
            }

            using (SqlCommand comm = new SqlCommand("Select * from [User] Where Email = '" + email + "'", sqlConnection))
            using (SqlDataReader reader = comm.ExecuteReader())
            {
                while(reader.Read())
                {
                    data.email = reader.GetString(0);
                    data.password = reader.GetString(2);
                    data.dob = reader.GetDateTime(1);
                    data.productsSold = reader.GetInt32(3);
                    data.productsBought = reader.GetInt32(4);
                }
            }

            sqlConnection.Close();

            return data;

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

                case "buttonUpdateUserInfo":
                    string email = tableUsers.SelectedRows[0].Cells[0].Value.ToString();
                    DateTime dob = DateTime.Parse(tableUsers.SelectedRows[0].Cells[1].FormattedValue.ToString());
                    UpdateUserInfoForm updateUserInfoForm = new UpdateUserInfoForm(this, email, dob);
                    updateUserInfoForm.Show();
                    this.Enabled = false;
                    break;

                case "buttonDeleteUser":
                    DeleteUserForm deleteUserForm = new DeleteUserForm(this);
                    deleteUserForm.Show();
                    this.Enabled = false;
                    break;

                default:
                    break;
            }


        }

        public void UpdateForm()
        {
            tableUsers.Rows.Clear();
            FillUsersTable();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);

            tableUsers.Rows.Clear();
            FillUsersTable();
        }
        
        private void tableUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (tableUsers.SelectedRows.Count <= 0)
            {
                buttonDeleteUser.Visible = false;
                buttonUpdateUserInfo.Visible = false;
            }
            if (tableUsers.SelectedRows.Count == 1)
            {
                buttonDeleteUser.Visible = true;
                buttonUpdateUserInfo.Visible = true;
            }
            else
            {
                buttonDeleteUser.Visible = true;
                buttonUpdateUserInfo.Visible = false;
            }
        }

        private bool DeleteUser(SqlConnection sqlConnection, string email)
        {
            try
            {
                sqlConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            SqlCommand comm = new SqlCommand("DeleteUser", sqlConnection);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = email;

            if (comm.ExecuteNonQuery() > 0)
            {
                sqlConnection.Close();
                return true;
            }
            else
            {
                sqlConnection.Close();
                return false;
            }

        }
    }
}
