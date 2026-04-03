using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conexion;
using Datos.Entidades;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class RolFomularioRepositorio
    {
        private ConexionDB conexion = new ConexionDB();

        // 1. OBTENER PERMISOS DE UN ROL ESPECÍFICO
        // Útil para saber qué Checkboxes marcar cuando seleccionamos un Rol en la lista
        public List<int> obtenerIdsFormulariosPorRol(int id_rol)
        {

            List<int> listaIds = new List<int>();
            string sql = "SELECT id_formulario FROM rol_formularios WHERE id_rol = @id_rol";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_rol", id_rol);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaIds.Add(Convert.ToInt32(reader["id_formulario"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de Datos al obtener formularios por rol: " + ex.Message);
            }
            return listaIds;
        }

        // 2. ACTUALIZAR PERMISOS (Sincronización Total)
        // Recibe el ID del rol y la lista de IDs de formularios que quedaron tildados

        public void ActualizarPermisos(int id_rol, List<int> ids_formularios)
        {
            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                // USAMOS TRANSACCIÓN: O se guardan todos los permisos o ninguno.
                MySqlTransaction tr = con.BeginTransaction();

                try
                {
                    // PASO A: Borrar todos los permisos actuales de ese rol
                    string sqlDelete = "DELETE FROM rol_formularios WHERE id_rol = @id_rol";
                    MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, con, tr);
                    cmdDelete.Parameters.AddWithValue("@id_rol", id_rol);
                    cmdDelete.ExecuteNonQuery();

                    // PASO B: Insertar los nuevos permisos (si hay alguno tildado)
                    if (ids_formularios != null && ids_formularios.Count > 0)
                    {
                        string sqlInsert = "INSERT INTO rol_formularios (id_rol, id_formulario) VALUES (@id_rol, @id_form)";

                        foreach (int id_f in ids_formularios)
                        {
                            MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, con, tr);
                            cmdInsert.Parameters.AddWithValue("@id_rol", id_rol);
                            cmdInsert.Parameters.AddWithValue("@id_form", id_f);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }

                    tr.Commit(); // Si todo salió bien, guardamos cambios
                }
                catch (Exception ex)
                {
                    tr.Rollback(); // Si algo falló, volvemos atrás para no dejar el rol sin permisos
                    throw new Exception("Error al sincronizar los permisos del rol: " + ex.Message);
                }
            }




        }

    }
}
