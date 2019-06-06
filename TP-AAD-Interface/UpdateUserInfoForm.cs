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
    public partial class UpdateUserInfoForm : Form
    {

        UsersManagement.UserData userData;

        private struct DataToChange
        {
            public bool password;
            public bool dob;
        }


        public UpdateUserInfoForm(Form ownerForm, string email, DateTime dob)
        {
            InitializeComponent();

            buttonSave.Click += new EventHandler(OnClick);

            this.Owner = ownerForm;

            userData = UsersManagement.GetUserData(Form1.sqlConnection, email);

            labelEmaillabel.Text = email;
            dateTimePicker1.Value = dob;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.Owner.Enabled = true;

            UsersManagement usersManagement = this.Owner as UsersManagement;
            usersManagement.UpdateForm();
        }

        private void OnClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            UsersManagement.UserData newUserData = userData;

            if(button == buttonSave)
            {
                //confirma os inputs para verificar quais os dados o utilizador quer mudar
                DataToChange dataToChange = ValidateUserNewInfo();

                //compara a nova e a velha password
                if(dataToChange.password)
                {

                    if (String.Compare(userData.password, textBox2.Text) != 0)
                    {
                        //se as passwords sao diferentes, confirma q a nova password é valida
                        if (!RegistrationUtility.IsPasswordValid(textBox2.Text))
                        {
                            MessageBox.Show("New Password not valid.");
                            return;
                        }
                        else
                        {
                            newUserData.password = textBox2.Text;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your new password is the same as the old one.");
                        return;
                    }
                }
                
                //comparar datas de nascimento
                if(dataToChange.dob)
                {

                    if(!RegistrationUtility.IsDateValid(dateTimePicker1.Value))
                    {
                        MessageBox.Show("Your new date isnt valid!");
                        return;
                    }
                    else
                    {
                        newUserData.dob = dateTimePicker1.Value;
                    }
                }

                if(RegistrationUtility.UpdateUserInfo(Form1.sqlConnection, newUserData))
                {
                    MessageBox.Show("User info updated.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Command failed.");
                }

            }
        }

        private DataToChange ValidateUserNewInfo()
        {
            DataToChange dataToChange;

            dataToChange.password = RegistrationUtility.IsUserTryingToSetNewPassword(textBox2.Text);

            if (dateTimePicker1.Value != userData.dob) dataToChange.dob = true;
            else dataToChange.dob = false;

            return dataToChange;

        }

       
    }
}
