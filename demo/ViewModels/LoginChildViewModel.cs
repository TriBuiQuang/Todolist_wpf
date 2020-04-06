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
		private string _email;
		private string _password;
		public string Email
		{
			get { return _email; }
			set 
			{
				_email = value;
				NotifyOfPropertyChange(() => Email);
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
				if (Email?.Length > 0 && Password?.Length > 0)
				{
					output = true;
				}
				return output;
			}	
		}

		public void LogIn()
		{
			if (Email == "hoang@gmail.com" && Password == "Hoang@1234")
			{
				//MessageBox.Show("Log in success");
				var conductor = this.Parent as IConductor;
				conductor.ActivateItem(new TodoChildViewModel());

			} else
			{
				MessageBox.Show("Log in fail");
			}
				
		}
	}
}
