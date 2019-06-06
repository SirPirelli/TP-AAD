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
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm(Form owner)
        {
            InitializeComponent();

            buttonSim.Click += new EventHandler(ButtonClick);
            buttonNao.Click += new EventHandler(ButtonClick);


            this.Owner = owner;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button but = sender as Button;

            switch(but.Name)
            {
                case "buttonSim":
                    UsersManagement usersManagement = Owner as UsersManagement;
                    usersManagement.DeleteSelectedRows();
                    this.Close();
                    break;

                case "buttonNao":
                    this.Close();
                    break;

                default:
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            this.Owner.Enabled = true;

            UsersManagement usersManagement = this.Owner as UsersManagement;
            usersManagement.UpdateForm();
        }
    }
}
