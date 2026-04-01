using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Repositorios;

namespace Negocio.Servicios
{
    public class UsuarioService
    {
        private UsuarioRepositorio repo = new UsuarioRepositorio();

        public Usuario Login(string user, string pass)
        {
            //1-validar que el usuario y contraseña no estén vacíos
            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                throw new ArgumentException("El nombre de usuario y la contraseña no pueden estar vacíos.");
            }

            //2-llamar al repositorio para buscar el usuario en la base de datos
            Usuario usuario = repo.ValidarUsuario(user, pass);

            //3 - si el usuario no existe o la contraseña es incorrecta, lanzar una excepción
            if(usuario == null)
            {
                throw new UnauthorizedAccessException("Usuario o contraseña incorrectos.");
            }
            if(!usuario.activo)
            {
                throw new UnauthorizedAccessException("El usuario no está activo. Contacta al administrador.");
            }

            //si todo está bien, devolver el usuario encontrado
            return usuario;
        }

    }
}
