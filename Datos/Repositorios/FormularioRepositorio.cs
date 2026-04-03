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
    public class FormularioRepositorio
    {
        private ConexionDB conexion = new ConexionDB();


        public List<Formulario> Listar()
        {
            List<Formulario> lista = new List<Formulario>();
            string sql = "SELECT id_formulario, nombre_control, etiqueta, activo FROM formularios";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Formulario formulario = new Formulario
                            {
                                id_formulario = Convert.ToInt32(reader["id_formulario"]),
                                nombre_control = reader["nombre_control"].ToString(),
                                etiqueta = reader["etiqueta"].ToString(),
                                activo = Convert.ToBoolean(reader["activo"])
                            };
                            lista.Add(formulario);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar formularios: " + ex.Message);
            }
            return lista;
        }

        public void Agregar(Formulario formulario)
        {
            string sql = "INSERT INTO formularios (nombre_control, etiqueta, activo) VALUES (@nombre_control, @etiqueta, @activo)";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre_control", formulario.nombre_control);
                    cmd.Parameters.AddWithValue("@etiqueta", formulario.etiqueta);
                    cmd.Parameters.AddWithValue("@activo", formulario.activo);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar formulario: " + ex.Message);
            }


        }

        public void Editar(Formulario formulario)
        {
            string sql = "UPDATE formularios SET nombre_control = @nombre_control, etiqueta = @etiqueta, activo = @activo WHERE id_formulario = @id_formulario";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre_control", formulario.nombre_control);
                    cmd.Parameters.AddWithValue("@etiqueta", formulario.etiqueta);
                    cmd.Parameters.AddWithValue("@activo", formulario.activo);
                    cmd.Parameters.AddWithValue("@id_formulario", formulario.id_formulario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al editar formulario: " + ex.Message);
            }

        }
        public void EliminarLogico(int idFormulario)
        {
            string sql = "UPDATE formularios SET activo = 0 WHERE id_formulario = @id_formulario";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id_formulario", idFormulario);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al dar de baja al formulario: " + ex.Message);
            }
        }

        public bool ExisteNombre(string nombreControl, int idFormulario = 0)
        {
            string sql = "SELECT COUNT(*) FROM formularios WHERE nombre_control = @nombre_control AND id_formulario != @id_formulario";
            try
            {
                using (MySqlConnection con = conexion.EstablecerConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@nombre_control", nombreControl);
                    cmd.Parameters.AddWithValue("@id_formulario", idFormulario);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar existencia de formulario: " + ex.Message);
            }

        }





    }
}
