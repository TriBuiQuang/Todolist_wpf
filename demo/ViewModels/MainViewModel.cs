using Caliburn.Micro;

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

        public void LoadPageCalendar()
        {
            ActivateItem(new CalendarChildViewModel());
        }

        public void LoadPageTodo()
        {
            ActivateItem(new TodoChildViewModel());
        }
    }
}
