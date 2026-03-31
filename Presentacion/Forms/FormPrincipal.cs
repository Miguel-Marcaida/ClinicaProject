
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
            var conexion = new ConexionDB();
            if (conexion.ProbarConexion())
            {
                MessageBox.Show("¡Conexión Exitosa con MySQL!");
            }
            else
            {
                MessageBox.Show("Error al conectar. Revisar cadena de conexión.");
            }
        }
    }
}
