using Caliburn.Micro;
using demo.Helpers;
using demo.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace demo
{
    //tao nen file nay de chi day la diem de bat dau app
    public class Bootstrapper : BootstrapperBase
    {
        // Constructor
        public Bootstrapper()
        {
            Initialize();
            ConventionManager.AddElementConvention<PasswordBox>(
            PasswordBoxHelper.BoundPasswordProperty,
            "Password",
            "PasswordChanged");
        }
        // override the Startup must be go to MainViewModel
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
