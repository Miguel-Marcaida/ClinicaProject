using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;//nueva libreria para leer el app.config
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Datos.Conexion
{
    public class ConexionDB
    {

        // Leemos la configuración por su nombre "CadenaClinica"
        private readonly string cadena = ConfigurationManager.ConnectionStrings["CadenaClinica"].ConnectionString;

        public MySqlConnection EstablecerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);
            try
            {
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (MySqlException ex)
            {
                // Esto te va a decir exactamente qué falló (pass, server, etc.)
                throw new Exception("Error de conexión: " + ex.Message);
            }
        }

        public void CerrarConexion(MySqlConnection conexion)
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
