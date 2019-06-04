using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_AAD_Interface
{
    public partial class ProductsManagement : Form
    {
        public ProductsManagement()
        {
            InitializeComponent();

            buttonMainMenu.Click += new EventHandler(ButtonClick);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;

            switch(button.Name)
            {
                case "buttonMainMenu":
                    Program.StartForm("MainMenu");
                    break;

                default:
                    break;
            }
        }
    }
}
