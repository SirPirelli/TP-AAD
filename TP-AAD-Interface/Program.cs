using System;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    static class Program
    {

        static public Form activeForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            activeForm = form;

            Application.Run(activeForm);
            
        }

        public static void StartForm(string form)
        {
            switch(form)
            {
                case "MainMenu":
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    activeForm.Hide();
                    activeForm = mainMenu;
                    break;

                case "UsersManagement":
                    UsersManagement usersManagement = new UsersManagement();
                    usersManagement.Show();
                    activeForm.Hide();
                    activeForm = usersManagement;
                    break;

                case "ProductsManagement":
                    ProductsManagement productsManagement = new ProductsManagement();
                    productsManagement.Show();
                    activeForm.Hide();
                    activeForm = productsManagement;
                    break;

                default:
                    Console.WriteLine("Cant find specified Form - " + form);
                    break;
            }
        }
    }
}
