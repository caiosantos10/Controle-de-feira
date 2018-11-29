using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeira.Models
{
    [Table("Produtos")]
    class UsuarioModel
    {   [Key]
        public int UsuarioID { get; set; }
        public string UsuarioName { get; set; }
        public string UsuarioEmail { get; set; }
        public string UsuarioSenha { get; set; }
    }
}
