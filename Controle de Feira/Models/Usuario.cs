using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.Models
{
    
    class Usuario
    {
        
        public string UsuarioID { get; set; }

        public string UsuarioName { get; set; }

        public string UsuarioEmail { get; set; }

        public string UsuarioSenha { get; set; }
        

    }
}
