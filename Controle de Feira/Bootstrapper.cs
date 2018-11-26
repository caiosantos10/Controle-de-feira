using Caliburn.Micro;
using Controle_de_Feira.ViewModels;
using System.Windows;

namespace Controle_de_Feira
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
