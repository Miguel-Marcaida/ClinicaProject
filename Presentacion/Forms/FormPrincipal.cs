
using Datos.Conexion;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            // Instanciamos tu clase de la capa de Datos
            Datos.Conexion.ConexionDB conexion = new Datos.Conexion.ConexionDB();

            try
            {
                // Intentamos abrir el caño
                using (var con = conexion.EstablecerConexion())
                {
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        MessageBox.Show("✅ ¡Conexión Exitosa! C# y MySQL ya se hablan.",
                                        "Estado de la Base", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Al usar 'using', la conexión se cierra sola al terminar el bloque, es más limpio.
            }
            catch (Exception ex)
            {
                // Si algo falla (contraseña mal, servidor apagado, etc.) te lo dice acá
                MessageBox.Show("❌ Error: " + ex.Message,
                                "Fallo de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
