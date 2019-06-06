using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    enum ERRORS { EMAIL, PASSWORD, DATE };


    public partial class RegisterUser : Form
    {

        public RegisterUser(Form ownerForm)
        {
            this.Owner = ownerForm;

            InitializeComponent();

            buttonSignUp.Click += new EventHandler(OnButtonClick);
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            this.Owner.Enabled = true;

            UsersManagement usersManagement = this.Owner as UsersManagement;
            usersManagement.UpdateForm();
        }


        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch(button.Name)
            {
                case "buttonSignUp":

                if (!RegistrationUtility.IsUsernameValid(textBoxUsername.Text, Form1.sqlConnection))
                {
                    RegistrationUtility.OnRegisterError(ERRORS.EMAIL, labelError);
                    break;
                }
                if (!RegistrationUtility.IsPasswordValid(textBoxPassword.Text))
                {
                        RegistrationUtility.OnRegisterError(ERRORS.PASSWORD, labelError);
                    break;
                }
                    //if (!RegistrationUtility.IsDateValid(dateTimeDOB.Value, labelError))
                    //{
                    //    OnRegisterError(ERRORS.DATE);
                    //    break;
                    //}

                    //Insert new user into database
                if (AddUserToDatabase(textBoxUsername.Text, textBoxPassword.Text, dateTimeDOB.Value, Form1.sqlConnection))
                {
                    labelError.Visible = true;
                    labelError.ForeColor = Color.Green;
                    labelError.Text = "User added with success.";
                }

                break;
            }
        }

        


        private bool AddUserToDatabase(string username, string password, DateTime dob, SqlConnection sqlConnection)
        {
            
            try
            {
                sqlConnection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine("Cant add user to database. " + e.Message);
                return false;
            }

            string date = dob.Year + "-" + dob.Month + "-" + dob.Day;

            SqlCommand cmd = new SqlCommand("AddUser", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = username; ;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.Char).Value = password; ;
            cmd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value = date;

            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Command executed successfully.");
                sqlConnection.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Failed to execute commmand.");
                sqlConnection.Close();
                return false;

            }

        }  

        


    }
}
