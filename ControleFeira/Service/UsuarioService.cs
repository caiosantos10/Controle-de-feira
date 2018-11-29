using ControleFeira.Models;
using ControleFeira.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFeira.Service
{
    class UsuarioService : IEntityService <UsuarioModel>
    {
        public void deleteItem(UsuarioModel item)
        {
            using (var ctx = new ControleFeiraContext())
            {
                ctx.Entry(item).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public List<UsuarioModel> getAll()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();

            using (var ctx = new ControleFeiraContext())
            {
                ctx.Usuarios.ToList().ForEach(user => usuarios.Add(user));
            }

            return usuarios;
        }

        public UsuarioModel getItemById(int id)
        {
            using (var ctx = new ControleFeiraContext())
            {
                return ctx.Usuarios.FirstOrDefault(u => u.UsuarioID.Equals(id));
            }

        }

        public void saveItem(UsuarioModel item)
        {
            using (var ctx = new ControleFeiraContext())
            {
                ctx.Usuarios.Add(item);
                ctx.SaveChanges();
            }
        }

        public UsuarioModel gerUserByUsername(string email)
        {
            using (var ctx = new ControleFeiraContext())
            {
                return ctx.Usuarios.FirstOrDefault(u => u.UsuarioEmail.Equals(email));
            }
        }

        public bool validaCadastroUser(UsuarioModel user)
        {
            if (gerUserByUsername(user.UsuarioEmail) == null)
                return true;
            else
            {
                return false;
            }
        }

        public bool validaLoginUser(UsuarioModel user)
        {
            var userResult = gerUserByUsername(user.UsuarioEmail);
            if (userResult != null)
            {
                return userResult.UsuarioSenha.Equals(user.UsuarioSenha);
            }

            return false;
        }



    }
}
