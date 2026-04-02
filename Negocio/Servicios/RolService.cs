using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Repositorios;

namespace Negocio.Servicios
{

    public class RolService
    {
        private RolRepositorio _rolRepositorio = new RolRepositorio();

        public List<Rol> ListarRoles()
        {
            try
            {
                return _rolRepositorio.Listar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al listar roles: " + ex.Message);
            }
        }

        public void GuardarRol(Rol rol)
        {
            try
            {
                if (string.IsNullOrEmpty(rol.nombre_rol))
                {
                    throw new Exception("El nombre del rol no puede estar vacío.");
                }

                // Validar duplicados (Pasamos el id_rol para que si es edición, no se choque consigo mismo)
                if (_rolRepositorio.ExisteNombre(rol.nombre_rol, rol.id_rol))
                {
                    throw new Exception("Ya existe un rol con ese nombre.");
                }

                if (rol.id_rol == 0)
                {
                    // Nuevo rol
                    _rolRepositorio.Agregar(rol);
                }
                else
                {
                    // Aquí podrías agregar lógica para actualizar un rol existente
                    _rolRepositorio.Editar(rol);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al guardar rol: " + ex.Message);
            }
        }


        //baja Logica: solo se marca como inactivo, no se borra de la base de datos

        public void EliminarRol(int idRol)
        {
            try
            {
                // Aquí podrías validar si el rol está siendo usado por algún usuario 
                // antes de "eliminarlo", para avisar al usuario.
                _rolRepositorio.EliminarLogico(idRol);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al eliminar rol: " + ex.Message);
            }

        }
    }
}
