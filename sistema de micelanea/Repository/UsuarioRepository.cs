using sistema_de_micelanea.Data;
using sistema_de_micelanea.Models;
using sistema_de_micelanea.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_de_micelanea.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _bd;

        public UsuarioRepository(ApplicationDbContext bd)
        {
            _bd = bd;
        }
        public bool ActualizarUsuario(Usuario usuario)
        {
            _bd.Usuario.Update(usuario);
            return Guardar();
        }

        public bool BorrarUsuario(Usuario usuario)
        {
            _bd.Usuario.Remove(usuario);
            return Guardar();
        }

        public bool CrearUsuario(Usuario usuario)
        {
            _bd.Usuario.Add(usuario);
            return Guardar();
        }

        public bool ExisteUsuario(string nombre)
        {
            bool valor = _bd.Usuario.Any(c => c.Nombre.ToLower().Trim() == nombre.ToLower().Trim());
            return valor;
        }

        public bool ExisteUsuario(int id)
        {
            return _bd.Usuario.Any(c => c.Id == id);
        }

        public Usuario GetUsuario(int UsuarioId)
        {
            return _bd.Usuario.FirstOrDefault(c => c.Id == UsuarioId);
        }

        public ICollection<Usuario> GetUsuario()
        {
            return _bd.Usuario.OrderBy(c => c.Nombre).ToList();
        }

        public ICollection<Usuario> GetUsuarios()
        {
            return _bd.Usuario.OrderBy(c => c.Nombre).ToList();
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }
    }
}

    

