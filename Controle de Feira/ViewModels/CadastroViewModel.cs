using Caliburn.Micro;
using Controle_de_Feira.Models;
using Controle_de_Feira.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.ViewModels
{
    class CadastroViewModel : Screen 
    {
        private string name;
        private string email;
        private string password;
        private string confirmPassword;
        private UsuarioService _userService;

        public CadastroViewModel()
        {
            _userService = new UsuarioService();
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set
            {
                confirmPassword = value;
                NotifyOfPropertyChange(() => ConfirmPassword);
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                NotifyOfPropertyChange(() => Email);
            }
        }

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

        public bool CanCadastrar(string name, string password)
        {
            if ((String.IsNullOrWhiteSpace(name) && String.IsNullOrWhiteSpace(password)) && (String.IsNullOrWhiteSpace(email) && String.IsNullOrWhiteSpace(confirmPassword)))
            {
                return false;
            }

            else
                return true;
        }

        public void Cadastrar(string name, string password)
        {
            _userService.saveItem(new Usuario()
            {
                UsuarioName = name,
                UsuarioSenha= password
            });

            App.Bootstrapper.Init(new LoginViewModel());
            this.TryClose();

        }
    }
}
