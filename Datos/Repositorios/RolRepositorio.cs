using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Datos.Conexion;
using Datos.Entidades;


namespace Datos.Repositorios
{
    public class RolRepositorio
    {
        private ConexionDB conexion = new ConexionDB();

        public List<Rol> Listar()
        {
            List<Rol> lista = new List<Rol>();

            string sql = "SELECT id_rol, nombre_rol, activo FROM roles";

            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Rol rol = new Rol
                            {
                                id_rol = Convert.ToInt32(reader["id_rol"]),
                                nombre_rol = reader["nombre_rol"].ToString(),
                                activo = Convert.ToBoolean(reader["activo"])
                            };
                            lista.Add(rol);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar roles: " + ex.Message);
            }

            return lista;
        }

        public void Agregar(Rol rol)
        {
            string sql = "INSERT INTO roles (nombre_rol, activo) VALUES (@nombre_rol, @activo)";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre_rol", rol.nombre_rol);
                    cmd.Parameters.AddWithValue("@activo", rol.activo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar rol: " + ex.Message);
            }



        }

        public void Editar(Rol rol)
        {
            string sql = "UPDATE roles SET nombre_rol = @nombre_rol, activo = @activo WHERE id_rol = @id_rol";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre_rol", rol.nombre_rol);
                    cmd.Parameters.AddWithValue("@activo", rol.activo);
                    cmd.Parameters.AddWithValue("@id_rol", rol.id_rol);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar rol: " + ex.Message);
            }
        }

        public void EliminarLogico(int id_rol)
        {
            string sql = "UPDATE roles SET activo = 0 WHERE id_rol = @id_rol";

            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_rol", id_rol);
                    cmd.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja el rol: " + ex.Message);
            }

        }

        public bool ExisteNombre(string nombre, int idExcluir = 0)
        {
            string sql = "SELECT COUNT(*) FROM roles WHERE nombre_rol = @nombre AND id_rol != @id";
            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", idExcluir);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }


    }
}