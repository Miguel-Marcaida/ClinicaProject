using Datos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class RolFormularioService
    {
        // Instanciamos el repositorio para comunicarnos con la DB
        private RolFormularioRepositorio _repo = new RolFormularioRepositorio();

        #region Métodos de Lectura

        public List<int> ObtenerIdsFormulariosPorRol(int idRol)
        {
            if (idRol <= 0) return new List<int>();

            return _repo.obtenerIdsFormulariosPorRol(idRol);
        }

        #endregion

        #region Métodos de Escritura

        public bool ActualizarPermisos(int idRol, List<int> idsFormularios)
        {
            try
            {
                // Aquí podrías agregar lógica de negocio antes de guardar:
                // Ejemplo: Validar que no se le quiten permisos críticos al rol 'Admin'

                if (idRol <= 0) return false;

                // Delegamos la tarea pesada al repositorio
                _repo.ActualizarPermisos(idRol, idsFormularios);

                return true;
            }
            catch (Exception ex)
            {
                // Aquí podrías loguear el error si tuvieras un logger
                throw new Exception("Error en el servicio al actualizar permisos: " + ex.Message);
            }
        }

        #endregion
    }
}
