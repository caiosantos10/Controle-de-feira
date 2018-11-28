using ControleFeira.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeira
{
    class ControleFeiraContext : DbContext
    {
        public ControleFeiraContext() : base("ControleFeira")
        {
            Database.SetInitializer<ControleFeiraContext>(new DropCreateDatabaseIfModelChanges<ControleFeiraContext>());
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
