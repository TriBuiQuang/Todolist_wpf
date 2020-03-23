using Caliburn.Micro;
using demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ViewModels
{
    class DashboardChildViewModel : Screen
    {
		// Don't manipulate this _firstName do it in FirstName
		// just Properties not constructor
		private string _firstName = "Tim";
		private string _lastName;
		private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();
		private PersonModel _selectedPerson;
		public DashboardChildViewModel()
		{
			People.Add(new PersonModel { FirstName = "Tim", LastName = "Corey" });
			People.Add(new PersonModel { FirstName = "Tri", LastName = "Bui Quang" });
			People.Add(new PersonModel { FirstName = "Sue", LastName = "Storm" });
		}

		public string FirstName
		{
			get { return _firstName; }
			set
			{
				_firstName = value;
				// if change the calibrun.micro will use NotifyOfPropertyChange to say the frontend it change
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string LastName
		{
			get { return _lastName; }
			set
			{
				_lastName = value;
				NotifyOfPropertyChange(() => FirstName);
				NotifyOfPropertyChange(() => FullName);
			}
		}

		public string FullName
		{
			get { return $"{ FirstName } { LastName }"; }
		}

		public BindableCollection<PersonModel> People
		{
			get { return _people; }
			set { _people = value; }
		}

		public PersonModel SelectedPerson
		{
			get { return _selectedPerson; }
			set
			{
				_selectedPerson = value;
				NotifyOfPropertyChange(() => SelectedPerson);
			}
		}

		// 2 ways to return bool
		public bool CanClearText(string firstName, string lastName) => !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
		//{
		//	return !String.IsNullOrWhiteSpace(firstName) || !String.IsNullOrWhiteSpace(lastName);
		//}

		public void ClearText(string firstName, string lastName)
		{
			FirstName = "";
			LastName = "";
		}
	}
}
