using Datos.Entidades;
using Presentacion.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Creamos un usuario ficticio para la prueba
            //Usuario usuarioPrueba = new Usuario();
            //usuarioPrueba.username = "Miguel Marcaida";
            //usuarioPrueba.id_rol = 1; // Supongamos que 1 es Admin

            //// Iniciamos el FormPrincipal pasándole el usuario
            //Application.Run(new FormPrincipal(usuarioPrueba));



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}