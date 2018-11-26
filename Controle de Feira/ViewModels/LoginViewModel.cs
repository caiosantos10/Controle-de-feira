using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.ViewModels
{
    public class LoginViewModel : Conductor<object>
    {
        private string name;
        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                NotifyOfPropertyChange(() => Name);
                
            }
        }

        public bool CanLogin(string name, string password)
        {
            if (String.IsNullOrWhiteSpace(name) && String.IsNullOrWhiteSpace(password))
            {
                return false;
            }
           
            else
                return true;
        }

        public void Login(string name, string password)
        {
            App.Bootstrapper.Init(new MenuViewModel());
            this.TryClose();
            
        }

       
    }
}
