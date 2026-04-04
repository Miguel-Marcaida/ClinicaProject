using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conexion;
using MySql.Data.MySqlClient;

namespace Datos.Repositorios
{
    public class UsuarioRolRepositorio
    {

        private ConexionDB conexion = new ConexionDB();

        // 1. OBTENER ROLES DE UN USUARIO ESPECÍFICO
        // Sirve para marcar los roles en el CheckedListBox al seleccionar un Usuario
        public List<int> ObtenerIdsRolesPorUsuario(int id_usuario)
        {
            List<int> listaIds = new List<int>();
            string sql = "SELECT id_rol FROM usuario_roles WHERE id_usuario = @id_usuario";

            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaIds.Add(Convert.ToInt32(reader["id_rol"]));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la capa de Datos al obtener roles por usuario: " + ex.Message);
            }
            return listaIds;
        }

        // 2. ACTUALIZAR ROLES (Sincronización Total)
        public void ActualizarRolesUsuario(int id_usuario, List<int> ids_roles)
        {
            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                MySqlTransaction tr = con.BeginTransaction();

                try
                {
                    // PASO A: Borrar todos los roles actuales de ese usuario
                    string sqlDelete = "DELETE FROM usuario_roles WHERE id_usuario = @id_usuario";
                    MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, con, tr);
                    cmdDelete.Parameters.AddWithValue("@id_usuario", id_usuario);
                    cmdDelete.ExecuteNonQuery();

                    // PASO B: Insertar los nuevos roles (si hay alguno tildado)
                    if (ids_roles != null && ids_roles.Count > 0)
                    {
                        string sqlInsert = "INSERT INTO usuario_roles (id_usuario, id_rol) VALUES (@id_usuario, @id_rol)";

                        foreach (int id_r in ids_roles)
                        {
                            MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, con, tr);
                            cmdInsert.Parameters.AddWithValue("@id_usuario", id_usuario);
                            cmdInsert.Parameters.AddWithValue("@id_rol", id_r);
                            cmdInsert.ExecuteNonQuery();
                        }
                    }

                    tr.Commit();
                }
                catch (Exception ex)
                {
                    tr.Rollback();
                    throw new Exception("Error al sincronizar los roles del usuario: " + ex.Message);
                }
            }
        }


    }
}
