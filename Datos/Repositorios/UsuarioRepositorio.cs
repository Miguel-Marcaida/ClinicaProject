using Datos.Conexion;
using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class UsuarioRepositorio
    {
        private ConexionDB conexion = new ConexionDB();


        public  Usuario ValidarUsuario(string user, string pass)
        {
            Usuario usuarioEncontrado= null;


            string sql = "SELECT u.id_usuario, u.id_persona, u.username, u.password_hash, u.activo, r.nombre_rol " +
             "FROM usuarios u " +
             "INNER JOIN usuario_roles ur ON u.id_usuario = ur.id_usuario " +
             "INNER JOIN roles r ON ur.id_rol = r.id_rol " +
             "WHERE u.username = @user AND u.password_hash = @pass";

            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuarioEncontrado = new Usuario
                            {
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                id_persona = Convert.ToInt32(reader["id_persona"]),
                                username = reader["username"].ToString(),
                                password_hash = reader["password_hash"].ToString(),
                                activo = Convert.ToBoolean(reader["activo"]),
                                // Mapeamos el nombre del rol que viene del JOIN
                                nombre_rol = reader["nombre_rol"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Un error común es que falte la librería de MySQL en el proyecto Datos
                //throw new Exception("Error en la capa de Datos: " + ex.Message);
            }

            return usuarioEncontrado;
            // Aquí iría la lógica para validar el usuario contra la base de datos
            // Por ejemplo, podrías ejecutar una consulta SQL para verificar el username y password_hash
            // Luego, si es válido, devolver un objeto Usuario con los datos correspondientes
            // Este es solo un ejemplo de cómo podrías estructurar el método
            // En una implementación real, deberías manejar la conexión, consultas y posibles excepciones
            return null; // Retorna null si no se encuentra el usuario o si la contraseña es incorrecta
        }

        public List<string> ObtenerPermisos(int idUsuario)
        {
            List<string> listaPermisos = new List<string>();

            // El "Súper Join" que analizamos antes, adaptado a tus tablas
            string sql = @"SELECT f.nombre_control 
                   FROM formularios f
                   JOIN rol_formularios rf ON f.id_formulario = rf.id_formulario
                   JOIN roles r ON rf.id_rol = r.id_rol
                   JOIN usuario_roles ur ON r.id_rol = ur.id_rol
                   WHERE ur.id_usuario = @idUser AND f.activo = 1";

            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@idUser", idUsuario);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaPermisos.Add(reader["nombre_control"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener permisos: " + ex.Message);
            }

            return listaPermisos;
        }


    }
}
