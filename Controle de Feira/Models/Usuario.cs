using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.Models
{
    [Table("Usuarios")]
    class Usuario
    {
        [Key]
        public string UsuarioID { get; set; }

        [Column("Name", TypeName = "ntext")]
        [MaxLength(20)]
        public string UsuarioName { get; set; }

        [Column("Email", TypeName = "ntext")]
        [MaxLength(20)]
        public string UsuarioEmail { get; set; }

        [Column("Senha", TypeName = "int")]
        [MaxLength(20)]
        public string UsuarioSenha { get; set; }
        

    }
}
