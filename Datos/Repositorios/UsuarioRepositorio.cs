using Datos.Conexion;
using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.DTOs;


namespace Datos.Repositorios
{
    public class UsuarioRepositorio
    {
        private ConexionDB conexion = new ConexionDB();

        //seguridad

       
        public Usuario ValidarUsuario(string user, string pass)
        {
            Usuario usuarioEncontrado = null;


            string sql = "SELECT u.id_usuario, u.id_persona, u.username, u.password_hash, u.activo, r.nombre_rol " +
             "FROM usuarios u " +
             "LEFT JOIN usuario_roles ur ON u.id_usuario = ur.id_usuario " +
             "LEFT JOIN roles r ON ur.id_rol = r.id_rol " +
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

        public int InsertarUsuarioCompleto(Usuario user)
        {
            int idPersonaGenerado = 0;

            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                if (con.State != System.Data.ConnectionState.Open) con.Open();

                // Ahora sí, con la conexión abierta, iniciamos la transacción
                using (MySqlTransaction tr = con.BeginTransaction())
                {
                    try
                    {
                        // 1. INSERTAR PERSONA
                        string sqlPersona = @"INSERT INTO personas 
                    (dni, nombre, apellido, direccion, telefono, email, fecha_nacimiento, activo) 
                    VALUES (@dni, @nom, @ape, @dir, @tel, @em, @fnac, @actP);
                    SELECT LAST_INSERT_ID();";

                        MySqlCommand cmdPers = new MySqlCommand(sqlPersona, con, tr);
                        cmdPers.Parameters.AddWithValue("@dni", user.dni);
                        cmdPers.Parameters.AddWithValue("@nom", user.nombre);
                        cmdPers.Parameters.AddWithValue("@ape", user.apellido);
                        cmdPers.Parameters.AddWithValue("@dir", user.direccion);
                        cmdPers.Parameters.AddWithValue("@tel", user.telefono);
                        cmdPers.Parameters.AddWithValue("@em", user.email);
                        cmdPers.Parameters.AddWithValue("@fnac", user.fecha_nacimiento);
                        cmdPers.Parameters.AddWithValue("@actP", user.activo);

                        idPersonaGenerado = Convert.ToInt32(cmdPers.ExecuteScalar());

                        // 2. INSERTAR USUARIO
                        string sqlUsuario = @"INSERT INTO usuarios 
                    (id_persona, username, password_hash, activo) 
                    VALUES (@idPers, @user, @pass, @actU);";

                        MySqlCommand cmdUser = new MySqlCommand(sqlUsuario, con, tr);
                        cmdUser.Parameters.AddWithValue("@idPers", idPersonaGenerado);
                        cmdUser.Parameters.AddWithValue("@user", user.username);
                        cmdUser.Parameters.AddWithValue("@pass", user.password_hash);
                        cmdUser.Parameters.AddWithValue("@actU", user.activo);

                        cmdUser.ExecuteNonQuery();

                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("Error en la transacción: " + ex.Message);
                    }
                }
            }
            return idPersonaGenerado;
        }

        public void ModificarUsuarioCompleto(Usuario user, bool cambiaPassword)
        {
            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                // EstablecerConexion ya la abre
                using (MySqlTransaction tr = con.BeginTransaction())
                {
                    try
                    {
                        // 1. UPDATE PERSONA
                        string sqlPersona = @"UPDATE personas SET 
                    dni=@dni, nombre=@nom, apellido=@ape, direccion=@dir, 
                    telefono=@tel, email=@em, fecha_nacimiento=@fnac, activo=@actP 
                    WHERE id_persona=@idPers";

                        MySqlCommand cmdP = new MySqlCommand(sqlPersona, con, tr);
                        cmdP.Parameters.AddWithValue("@dni", user.dni);
                        cmdP.Parameters.AddWithValue("@nom", user.nombre);
                        cmdP.Parameters.AddWithValue("@ape", user.apellido);
                        cmdP.Parameters.AddWithValue("@dir", user.direccion);
                        cmdP.Parameters.AddWithValue("@tel", user.telefono);
                        cmdP.Parameters.AddWithValue("@em", user.email);
                        cmdP.Parameters.AddWithValue("@fnac", user.fecha_nacimiento);
                        cmdP.Parameters.AddWithValue("@actP", user.activo);
                        cmdP.Parameters.AddWithValue("@idPers", user.id_persona);
                        cmdP.ExecuteNonQuery();

                        // 2. UPDATE USUARIO (Dinámico para la contraseña)
                        string sqlUsuario = "UPDATE usuarios SET username=@user, activo=@actU";

                        if (cambiaPassword)
                            sqlUsuario += ", password_hash=@pass";

                        sqlUsuario += " WHERE id_usuario=@idUser";

                        MySqlCommand cmdU = new MySqlCommand(sqlUsuario, con, tr);
                        cmdU.Parameters.AddWithValue("@user", user.username);
                        cmdU.Parameters.AddWithValue("@actU", user.activo);
                        cmdU.Parameters.AddWithValue("@idUser", user.id_usuario);

                        if (cambiaPassword)
                            cmdU.Parameters.AddWithValue("@pass", user.password_hash);

                        cmdU.ExecuteNonQuery();

                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("Error al actualizar: " + ex.Message);
                    }
                }
            }
        }

        public void EliminarLogico(int idUsuario, int idPersona)
        {
            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                using (MySqlTransaction tr = con.BeginTransaction())
                {
                    try
                    {
                        // Desactivamos en ambas tablas por consistencia
                        string sqlU = "UPDATE usuarios SET activo = 0 WHERE id_usuario = @idU";
                        MySqlCommand cmdU = new MySqlCommand(sqlU, con, tr);
                        cmdU.Parameters.AddWithValue("@idU", idUsuario);
                        cmdU.ExecuteNonQuery();

                        string sqlP = "UPDATE personas SET activo = 0 WHERE id_persona = @idP";
                        MySqlCommand cmdP = new MySqlCommand(sqlP, con, tr);
                        cmdP.Parameters.AddWithValue("@idP", idPersona);
                        cmdP.ExecuteNonQuery();

                        tr.Commit();
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        throw new Exception("No se pudo eliminar: " + ex.Message);
                    }
                }
            }
        }
        public List<UsuarioDTO> ListarUsuariosSistema()
        {
            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            string sql = @"SELECT u.id_usuario, p.id_persona, p.dni, 
                          CONCAT(p.apellido, ', ', p.nombre) as nombre_completo, 
                          u.username, p.email, u.activo
                   FROM usuarios u
                   INNER JOIN personas p ON u.id_persona = p.id_persona";

            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                // Solo abrimos si no está abierta ya
                if (con.State != System.Data.ConnectionState.Open) con.Open();

                MySqlCommand cmd = new MySqlCommand(sql, con);
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(new UsuarioDTO
                        {
                            IdUsuario = Convert.ToInt32(rdr["id_usuario"]),
                            IdPersona = Convert.ToInt32(rdr["id_persona"]),
                            DNI = rdr["dni"].ToString(),
                            NombreCompleto = rdr["nombre_completo"].ToString(),
                            Username = rdr["username"].ToString(),
                            Email = rdr["email"].ToString(),
                            Estado = Convert.ToBoolean(rdr["activo"]) ? "Activo" : "Inactivo"
                        });
                    }
                }
            }
            return lista;
        }

        public Usuario ObtenerPorId(int idUsuario)
        {
            Usuario u = null;
            string sql = @"SELECT u.*, p.* FROM usuarios u 
                   INNER JOIN personas p ON u.id_persona = p.id_persona 
                   WHERE u.id_usuario = @id";

            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", idUsuario);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        u = new Usuario
                        {
                            id_usuario = Convert.ToInt32(dr["id_usuario"]),
                            id_persona = Convert.ToInt32(dr["id_persona"]),
                            dni = dr["dni"].ToString(),
                            nombre = dr["nombre"].ToString(),
                            apellido = dr["apellido"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            email = dr["email"].ToString(),
                            fecha_nacimiento = Convert.ToDateTime(dr["fecha_nacimiento"]),
                            username = dr["username"].ToString(),
                            activo = Convert.ToBoolean(dr["activo"])
                        };
                    }
                }
            }
            return u;
        }

        public List<UsuarioDTO> BuscarUsuarios(string criterio)
        {
            List<UsuarioDTO> lista = new List<UsuarioDTO>();
            // Buscamos por Apellido, Nombre o DNI
            string sql = @"SELECT u.id_usuario, p.id_persona, p.dni, 
                          CONCAT(p.apellido, ', ', p.nombre) as nombre_completo, 
                          u.username, p.email, u.activo
                   FROM usuarios u
                   INNER JOIN personas p ON u.id_persona = p.id_persona
                   WHERE p.apellido LIKE @criterio 
                      OR p.nombre LIKE @criterio 
                      OR p.dni LIKE @criterio";

            using (MySqlConnection con = conexion.EstablecerConexion())
            {
                MySqlCommand cmd = new MySqlCommand(sql, con);
                // El % permite buscar coincidencias parciales
                cmd.Parameters.AddWithValue("@criterio", "%" + criterio + "%");

                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        lista.Add(new UsuarioDTO
                        {
                            IdUsuario = Convert.ToInt32(rdr["id_usuario"]),
                            IdPersona = Convert.ToInt32(rdr["id_persona"]),
                            DNI = rdr["dni"].ToString(),
                            NombreCompleto = rdr["nombre_completo"].ToString(),
                            Username = rdr["username"].ToString(),
                            Email = rdr["email"].ToString(),
                            Estado = Convert.ToBoolean(rdr["activo"]) ? "Activo" : "Inactivo"
                        });
                    }
                }
            }
            return lista;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            string sql = "SELECT u.id_usuario, u.id_persona, u.username, u.password_hash, u.activo, r.nombre_rol " +
             "FROM usuarios u " +
             "INNER JOIN usuario_roles ur ON u.id_usuario = ur.id_usuario " +
             "INNER JOIN roles r ON ur.id_rol = r.id_rol ";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Usuario
                            {
                                id_usuario = Convert.ToInt32(reader["id_usuario"]),
                                id_persona = Convert.ToInt32(reader["id_persona"]),
                                username = reader["username"].ToString(),
                                password_hash = reader["password_hash"].ToString(),
                                activo = Convert.ToBoolean(reader["activo"]),
                                 // Mapeamos el nombre del rol que viene del JOIN
                                nombre_rol = reader["nombre_rol"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar usuarios: " + ex.Message);
            }
            return lista;

        }

    }
}
