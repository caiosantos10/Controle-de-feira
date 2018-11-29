using Caliburn.Micro;
using ControleFeira.Models;
using ControleFeira.Service;
using System;

namespace ControleFeira.ViewModels
{
    class LoginViewModel : Screen
    {
        private UsuarioService usuarioService;
        private string name;
        private string senha;

        public LoginViewModel()
        {
            usuarioService = new UsuarioService();
        }

        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                NotifyOfPropertyChange(() => Senha);
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
            {
                return true;
            }
                
        }

        public void Login(string name, string password)
        {
            if (validaLogin())
            { 
                App.Bootstrapper.Init(new MenuViewModel());
                this.TryClose();
            }
        }

        private bool validaLogin()
        {
            return usuarioService.validaLoginUser(new UsuarioModel() { UsuarioName = Name, UsuarioSenha = Senha });
        }


    }
}
