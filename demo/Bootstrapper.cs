using Caliburn.Micro;
using demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace demo
{
    //tao nen file nay de chi day la diem de bat dau app
    public class Bootstrapper : BootstrapperBase
    {
        // Constructor
        public Bootstrapper()
        {
            Initialize();
        }
        // override the Startup must be go to MainViewModel
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
