using Caliburn.Micro;
using ControleFeira.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ControleFeira
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        private IWindowManager windowManager = new WindowManager();

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            Init(new LoginViewModel());
        }

        public void Init(object viewModel)
        {
            windowManager.ShowWindow(viewModel);
        }

    }
}
