using Caliburn.Micro;
using ControleFeira.Models;
using ControleFeira.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeira.ViewModels
{
    class CadastroViewModel  : Screen
    {
        private UsuarioService usuarioService;
        private string name;
        private string senha;
        private string confirmSenha;
        private string email;

        public CadastroViewModel()
        {
            usuarioService = new UsuarioService();
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


        public string ConfirmSenha
        {
            get { return confirmSenha; }
            set
            {
                confirmSenha = value;
                NotifyOfPropertyChange(() => ConfirmSenha);
                
            }
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

        private bool validaCadastro()
        {

            return usuarioService.validaCadastroUser(new UsuarioModel()
            {
                UsuarioName = Name,
                UsuarioSenha = Senha
            }); //Verifica se já existe um username igual no bd 
        }

        private void clearAllText()
        {
            Name = "";
            Email = "";
            Senha = "";
            ConfirmSenha = "";
        }

        public bool CanCadastrar()
        {
            if (string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Senha) && string.IsNullOrEmpty(ConfirmSenha) && !Senha.Equals(ConfirmSenha))
            {
                return false;
            }

            return true;
            
        }


        public void Cadastrar(string name)
        {
            if (validaCadastro())
            {
                usuarioService.saveItem(new UsuarioModel()
                {
                    UsuarioName = Name,
                    UsuarioEmail = Email,
                    UsuarioSenha = Senha
                });

                clearAllText();
            }
            else
            {

            }

        }

    }
}
