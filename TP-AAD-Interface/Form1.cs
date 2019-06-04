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
    public partial class Form1 : Form
    {

        static public SqlConnection sqlConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void SignIn(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            
            try
            {
                conn.Open();
                sqlConnection = conn;
                conn.Close();
                    
            }
            catch(Exception arg)
            {
                Console.WriteLine(arg.Message);
                return;
            }            

            Program.StartForm("MainMenu");
        }

       
    }
}
