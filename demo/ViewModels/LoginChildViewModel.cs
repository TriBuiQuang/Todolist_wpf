using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace demo.ViewModels
{
    class LoginChildViewModel : Screen
    {
		private string _userName;
		private string _password;
		public string Username
		{
			get { return _userName; }
			set 
			{
				_userName = value;
				NotifyOfPropertyChange(() => Username);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public string Password
		{
			get { return _password; }
			set {
				_password = value;
				NotifyOfPropertyChange(() => Password);
				NotifyOfPropertyChange(() => CanLogIn);
			}
		}

		public bool CanLogIn
		{
			get
			{
				bool output = false;
				if (Username?.Length > 0 && Password?.Length > 0)
				{
					output = true;
				}
				return output;
			}	
		}

		public void LogIn()
		{
			if (Username == "Hoang" && Password == "123")
			{
				MessageBox.Show("Log in success");
			} else
			{
				MessageBox.Show("Log in fail");
			}
				
		}
	}
}
