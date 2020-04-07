using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace demo.ViewModels
{
    class RegistrationChildViewModel : Screen
    {
        public RegistrationChildViewModel()
        {

        }

        private string _email;
        private string _password;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyOfPropertyChange(() => Email);
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        

        public void SignUp()
        {
            if (Email == null || Password == null || Email?.Length == 0 || Password?.Length == 0)
            {
                MessageBox.Show("Plase fill all the field");
            } else if (!Regex.IsMatch(Email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Email format is wrong");
            } else if (!Regex.IsMatch(Password, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$") )
            {
                MessageBox.Show("At least one upper case english letter • At least one lower case english letter • At least one digit • At least one special character • Minimum 8 in length");
            } else
            {
                var conductor = this.Parent as IConductor;
                conductor.ActivateItem(new LoginChildViewModel());
            }

        }

        //public void btnRegistration()
        //{
        //    if (txtBoxEmail.Text.Length == 0)
        //    {
        //        errormessage.Text = "Enter an email.";
        //        txtBoxEmail.Focus();
        //    }
        //    else if (!Regex.IsMatch(txtBoxEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
        //    {
        //        errormessage.Text = "Enter a valid email.";
        //        txtBoxEmail.Select(0, txtBoxEmail.Text.Length);
        //        txtBoxEmail.Focus();
        //    }
        //    else
        //    {
        //        string firstname = txtBoxFirstName.Text;
        //        string lastname = txtBoxLastName.Text;
        //        string email = txtBoxEmail.Text;
        //        string password = passwordBox1.Password;
        //        if (passwordBox1.Password.Length == 0)
        //        {
        //            errormessage.Text = "Enter password.";
        //            passwordBox1.Focus();
        //        }
        //        else if (passwordBoxConfirm.Password.Length == 0)
        //        {
        //            errormessage.Text = "Enter Confirm password.";
        //            passwordBoxConfirm.Focus();
        //        }
        //        else if (passwordBox1.Password != passwordBoxConfirm.Password)
        //        {
        //            errormessage.Text = "Confirm password must be same as password.";
        //            passwordBoxConfirm.Focus();
        //        }
        //        else
        //        {
        //            errormessage.Text = "";
        //            string address = txtBoxAddress.Text;
        //            SqlConnection con = new SqlConnection("Data Source=TESTPURU;Initial Catalog=Data;User ID=sa;Password=wintellect");
        //            con.Open();
        //            SqlCommand cmd = new SqlCommand("Insert into Registration (FirstName,LastName,Email,Password,Address) values('" + firstname + "','" + lastname + "','" + email + "','" + password + "','" + address + "')", con);
        //            cmd.CommandType = CommandType.Text;
        //            cmd.ExecuteNonQuery();
        //            con.Close();
        //            errormessage.Text = "You have Registered successfully.";
        //            Reset();
        //        }
        //    }
        //}

        //public void btnReset() {
        //    txtBoxFirstName.Text = "";
        //    txtBoxLastName.Text = "";
        //    txtBoxEmail.Text = "";
        //    txtBoxAddress.Text = "";
        //    passwordBox1.Password = "";
        //    passwordBoxConfirm.Password = "";
        //}
    }
}
