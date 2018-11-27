using Controle_de_Feira.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_de_Feira.Service
{
    class UsuarioService : IEntityService<Usuario>
    {
        public void deleteItem(Usuario item)
        {
            using (var controleFeiraContext = new Context())
            {
                controleFeiraContext.Usuarios.Remove(item);
                controleFeiraContext.SaveChanges();
            }

        }

        public List<Usuario> getAll()
        {
            using (var controleFeiraContext = new Context())
            {
                return controleFeiraContext.Usuarios.ToList();
            }

        }

        public Usuario getItemById(int id)
        {
            using (var controleFeiraContext = new Context())
            {
                return controleFeiraContext.Usuarios.FirstOrDefault(u => u.UsuarioID.Equals(id));
            }

        }

        public void saveItem(Usuario item)
        {
            var user = new Usuario()
            {
                UsuarioName = item.UsuarioName,
                UsuarioSenha = item.UsuarioSenha
            };

            using (var controleFeiraContext = new Context())
            {
                controleFeiraContext.Usuarios.Add(user);
                controleFeiraContext.SaveChanges();
            }

        }
    }
}
