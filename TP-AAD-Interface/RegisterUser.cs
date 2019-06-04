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
    public partial class RegisterUser : Form
    {
        enum ERRORS { EMAIL, PASSWORD, DATE};

        public RegisterUser(Form ownerForm)
        {
            this.Owner = ownerForm;

            InitializeComponent();

            buttonSignUp.Click += new EventHandler(OnButtonClick);
            this.FormClosing += new FormClosingEventHandler(OnFormClosing);
            
        }

        private void OnFormClosing(object sender, EventArgs e)
        {
            this.Owner.Enabled = true;
            
        }


        private void OnButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch(button.Name)
            {
                case "buttonSignUp":

                    if(!IsUsernameValid(textBoxUsername.Text))
                    {
                        break;
                    }
                    if(!IsPasswordValid(textBoxPassword.Text))
                    {
                        break;
                    }
                    if(!IsDateValid(dateTimeDOB.Value))
                    {
                        break;
                    }
                    
                    break;
            }
        }

        private bool IsPasswordValid(string password)
        {

            char[,] valid = {   { (char)48, (char)57 }, 
                                { (char)65, (char)90 }, 
                                { (char)97, (char)122 }
                                };
            
            foreach(char c in password)
            {
                for(int i = 0; i < valid.Length; i++)
                {
                    if (c < valid[i, 0] || c > valid[i, 1]) return false;
                }
            }

            return true;
        }

        private bool IsDateValid(DateTime date)
        {
            DateTime lowerbound = DateTime.Today.AddYears(-18);
            if (dateTimeDOB.Value > lowerbound) return false;

            return true;
        }

        private bool IsUsernameValid(string username)
        {

            using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            {
                conn.Open();

                using (SqlCommand comm = new SqlCommand("Select * from [User] Where Email = '" + username + "'", conn))
                using (SqlDataReader reader = comm.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Didnt find same username");
                        return true;
                    }
                }
            }
        }

        private bool AddUserToDatabase(string username, string password, DateTime dob)
        {
            

            //using (SqlConnection conn = new SqlConnection(Form1.connectionString))
            //{
            //    conn.Open();

            //    using (SqlCommand comm = new SqlCommand("INSERT INTO[User]([Email], [DOB], [Password], [ProductsSold], [ProductsBought], [FundsAvailable],[PointsAvailable]) VALUES('" + username + "', CAST(N'1988-06-03' AS Date), '" + password + "', 7, 0, 0, 0)", conn))
            //    using (SqlDataReader reader = comm.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            Console.WriteLine(reader.GetString(0));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Didnt find same username");
            //        }
            //    }
            //}

            return false;
        }

        private void OnRegisterError(ERRORS error)
        {

            labelError.Visible = true;

            switch(error)
            {
                case ERRORS.DATE:
                    break;

                case ERRORS.EMAIL:
                    break;

                case ERRORS.PASSWORD:
                    break;
            }

        }
        
    }
}
