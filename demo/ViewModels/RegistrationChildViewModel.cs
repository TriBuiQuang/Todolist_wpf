using Caliburn.Micro;

namespace demo.ViewModels
{
    class RegistrationChildViewModel : Screen
    {
        public RegistrationChildViewModel()
        {

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
