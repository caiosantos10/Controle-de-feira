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
    class CadastroViewModel 
    {
        private UsuarioService _usuario;
        private string name;
        private string senha;
        private string confirmSenha;

        public string ConfirmSenha
        {
            get { return confirmSenha; }
            set
            {
                confirmSenha = value;
            }
        }

        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
            }
        }


        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }



    }
}
