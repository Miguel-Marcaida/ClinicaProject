using Datos.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Servicios
{
    public class UsuarioRolService
    {
        private UsuarioRolRepositorio _repo = new UsuarioRolRepositorio();

        #region Métodos de Lectura

       
        public List<int> ObtenerIdsRolesPorUsuario(int idUsuario)
        {
            try
            {
                if (idUsuario <= 0) return new List<int>();

                return _repo.ObtenerIdsRolesPorUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en el servicio al obtener roles: " + ex.Message);
            }
        }

        #endregion

        #region Métodos de Escritura

        public bool ActualizarRolesUsuario(int idUsuario, List<int> idsRoles)
        {
            try
            {
                // Validación de Negocio: No podemos procesar un usuario inexistente
                if (idUsuario <= 0)
                {
                    throw new Exception("Debe seleccionar un usuario válido.");
                }

                // Delegamos la transacción al repositorio
                _repo.ActualizarRolesUsuario(idUsuario, idsRoles);
                return true;
            }
            catch (Exception ex)
            {
                // Re-lanzamos la excepción para que el Formulario la muestre en un MessageBox
                throw new Exception("Error en el servicio al actualizar roles: " + ex.Message);
            }
        }




        #endregion
    }
}
