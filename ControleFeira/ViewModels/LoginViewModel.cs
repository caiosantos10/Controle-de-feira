using ControleFeira.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeira.ViewModels
{
    class LoginViewModel
    {
        private UsuarioService usuarioService;
        private string name;
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
