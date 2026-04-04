using Datos.DTOs;
using Datos.Entidades;
using Datos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class UsuarioService
    {
        private UsuarioRepositorio repo = new UsuarioRepositorio();

        #region Autenticación
        public Usuario Login(string user, string pass)
        {
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                throw new ArgumentException("El nombre de usuario y la contraseña no pueden estar vacíos.");
            }

            Usuario usuario = repo.ValidarUsuario(user, pass);

            if (usuario == null)
            {
                throw new UnauthorizedAccessException("Usuario o contraseña incorrectos.");
            }

            // Usamos el activo del Usuario (el de la cuenta de acceso)
            if (!usuario.activo)
            {
                throw new UnauthorizedAccessException("El usuario no está activo. Contacta al administrador.");
            }

            usuario.permisos = repo.ObtenerPermisos(usuario.id_usuario);
            return usuario;
        }
        #endregion



        #region Gestión de Usuarios (ABM)

        public void GuardarUsuario(Usuario nuevoUsuario)
        {
            try
            {
                // 1. Validaciones de Negocio Básicas
                if (string.IsNullOrWhiteSpace(nuevoUsuario.dni))
                    throw new Exception("El DNI es obligatorio.");

                if (string.IsNullOrWhiteSpace(nuevoUsuario.username))
                    throw new Exception("El nombre de usuario es obligatorio.");

                if (string.IsNullOrWhiteSpace(nuevoUsuario.password_hash))
                    throw new Exception("La contraseña es obligatoria.");

                // 2. Aquí iría el Hashing en el futuro
                // nuevoUsuario.password_hash = Encriptar(nuevoUsuario.password_hash);

                // 3. Llamada al Repositorio (El que hace la transacción Persona -> Usuario)
                repo.InsertarUsuarioCompleto(nuevoUsuario);
            }
            catch (Exception ex)
            {
                // Re-lanzamos para que la UI lo atrape
                throw new Exception("Error en el servicio al guardar: " + ex.Message);
            }
        }

        public void ModificarUsuario(Usuario user, bool cambiaPassword)
        {
            // Aquí podrías agregar validaciones de negocio antes de mandar al repo
            if (string.IsNullOrWhiteSpace(user.nombre) || string.IsNullOrWhiteSpace(user.apellido))
            {
                throw new Exception("El nombre y apellido son obligatorios para la actualización.");
            }

            // Si todo está ok, llamamos al repo
            repo.ModificarUsuarioCompleto(user, cambiaPassword);
        }

        public void EliminarUsuario(int idU, int idP)
        {
            repo.EliminarLogico(idU, idP);
        }
        public List<UsuarioDTO> ObtenerListadoParaGrilla()
        {
            try
            {
                // Simplemente le pedimos al repo la lista procesada
                return repo.ListarUsuariosSistema();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al obtener el listado: " + ex.Message);
            }
        }

        public Usuario BuscarPorId(int id)
        {
            return repo.ObtenerPorId(id);
        }

        public List<Usuario> ListarUsuarios()
        {
            try
            {
                return repo.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al listar usuarios: " + ex.Message);
            }
        }

        public List<UsuarioDTO> BuscarUsuarios(string criterio)
        {
            // Aquí podrías agregar lógica de negocio si hiciera falta, 
            // por ejemplo, validar que el criterio no tenga caracteres raros.
            if (string.IsNullOrWhiteSpace(criterio)) return ObtenerListadoParaGrilla();

            return repo.BuscarUsuarios(criterio);
        }

        #endregion
    }
}
