using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ViewModels
{
    class MainViewModel : Conductor<object>
    {
		//this is contructor
		public MainViewModel()
		{
			
			LoadPageDashBoard();
		}

		public void LoadPageDashBoard()
		{
			ActivateItem(new DashboardChildViewModel());
		}
		public void LoadPageRegistration()
		{
			ActivateItem(new RegistrationChildViewModel());
		}
		public void LoadPageLogin()
		{
			ActivateItem(new LoginChildViewModel());
		}
		public void LoadPageTodo()
		{
			ActivateItem(new TodoChildViewModel());
		}
	}
}
