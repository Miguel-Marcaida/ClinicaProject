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


            // Query usando tus nombres reales de GitHub: username, password_hash, activo
            string sql = "SELECT id_usuario, id_persona, username, password_hash, id_rol, activo " +
                         "FROM usuarios " +
                         "WHERE username = @user AND password_hash = @pass";

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
                                id_rol = Convert.ToInt32(reader["id_rol"]),
                                // Al ser BOOLEAN en MySQL, C# lo mapea directo a bool
                                activo = Convert.ToBoolean(reader["activo"])
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Un error común es que falte la librería de MySQL en el proyecto Datos
                throw new Exception("Error en la capa de Datos: " + ex.Message);
            }

            return usuarioEncontrado;
            // Aquí iría la lógica para validar el usuario contra la base de datos
            // Por ejemplo, podrías ejecutar una consulta SQL para verificar el username y password_hash
            // Luego, si es válido, devolver un objeto Usuario con los datos correspondientes
            // Este es solo un ejemplo de cómo podrías estructurar el método
            // En una implementación real, deberías manejar la conexión, consultas y posibles excepciones
            return null; // Retorna null si no se encuentra el usuario o si la contraseña es incorrecta
        }

    }
}
