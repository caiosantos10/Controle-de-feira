using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.Models
{
    class Context : DbContext
    {
        public Context() : base("name = ControleDeFeiraDB")
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());  
        }

        public DbSet <Usuario> Usuarios{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Write Fluent API configurations here

        }
    }
}
