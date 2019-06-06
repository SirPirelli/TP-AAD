using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    class RegistrationUtility
    {

        static char[,] valid = {    { (char)48, (char)57 },
                                    { (char)65, (char)90 },
                                    { (char)97, (char)122}
                                };

        public static bool IsUsernameValid(string username, SqlConnection sqlConnection)
        {

            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Cant access database. " + e.Message);
                return false;
            }

            using (SqlCommand comm = new SqlCommand("Select * from [User] Where Email = '" + username + "'", sqlConnection))
            using (SqlDataReader reader = comm.ExecuteReader())
            {

                if (reader.Read())
                {
                    Console.WriteLine(reader.GetString(0));
                    sqlConnection.Close();
                    return false;
                }
                else
                {
                    Console.WriteLine("Didnt find same username");
                    sqlConnection.Close();
                    return true;
                }
            }


        }

        public static bool IsPasswordValid(string password)
        {         

            if (password.Length < 6) return false;

            foreach (char c in password)
            {
                bool validChar = false;

                for (int i = 0; i < valid.GetLongLength(0); i++)
                {
                    if (c >= valid[i, 0] && c <= valid[i, 1]) validChar = true;
                }

                if (!validChar) return false;
            }

            return true;
        }

        public static bool IsUserTryingToSetNewPassword(string passwordText)
        {
            string t = passwordText.Trim();
            if (t.Length == 0) return false;
            
            return true;

        }

        public static bool IsDateValid(DateTime date)
        {
            DateTime lowerbound = DateTime.Today.AddYears(-18);
            if (date > lowerbound) return false;

            return true;
        }

        public static bool UpdateUserInfo(SqlConnection sqlConnection, UsersManagement.UserData newUserData)
        {
            //open sqlConnection
            try
            {
                sqlConnection.Open();
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

            SqlCommand comm = new SqlCommand("UpdateUser", sqlConnection);
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@Email", SqlDbType.VarChar).Value = newUserData.email;
            comm.Parameters.AddWithValue("@Password", SqlDbType.Char).Value = newUserData.password;
            comm.Parameters.AddWithValue("@DOB", SqlDbType.DateTime2).Value = newUserData.dob;

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

        public static void OnRegisterError(ERRORS error, Label labelError)
        {
            if (labelError == null) return;

            labelError.Visible = true;
            labelError.ForeColor = Color.Red;

            switch (error)
            {
                case ERRORS.DATE:
                    labelError.Text = "User under 18. Can't register account.";
                    break;

                case ERRORS.EMAIL:
                    labelError.Text = "Email already registered.";
                    break;

                case ERRORS.PASSWORD:
                    labelError.Text = "Password too short and/or has special characters.";
                    break;
            }

        }

    }
}
