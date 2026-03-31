using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Conexion
{
    public class ConexionDB
    {
        private readonly string cadenaConexion = "Server=localhost;Database=clinica_db;Uid=root;Pwd='';";


        public MySqlConnection CrearConexion()
        {
            MySqlConnection cadena = new MySqlConnection();
            try
            {
                cadena.ConnectionString = cadenaConexion;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        // Método para testear si la base responde (Útil para el WinForm inicial)
        public bool ProbarConexion()
        {
            using (var conn = CrearConexion())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }


    }
}
