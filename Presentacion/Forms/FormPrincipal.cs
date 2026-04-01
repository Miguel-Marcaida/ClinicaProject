
using Datos.Conexion;
using Datos.Entidades;
using Presentacion.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {

        private Point mouseLocation;
        public FormPrincipal(Usuario usuarioLogueado)
        {
            InitializeComponent();
            // Seteamos el nombre del usuario que viene del Login
            lblUsuario.Text = $"Usuario: {usuarioLogueado.username}";
        }

        #region Logica para mover la ventana sin bordes

        private void pnlBarraTItulo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void pnlBarraTItulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        private void lblModulo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void lblModulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        private void lblUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void lblUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePos;
            }
        }

        #endregion


        #region Metodos para abrir formularios dentro del panel contenedor

        private void AbrirFormularioEnPanel(object formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
           
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }



        #endregion


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

        #region eventos de los botones del menú lateral
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir del sistema?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            // AbrirFormularioEnPanel(new FrmTurnos());
            lblModulo.Text = "AGENDA DE TURNOS";
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            // Aquí llamarás a tu formulario de pacientes cuando lo tengas listo:
            lblModulo.Text = "GESTIÓN DE PACIENTES";
            //lblModulo.Left = (pnlBarraTItulo.Width - lblModulo.Width) / 2; // Recentrar el título
            AbrirFormularioEnPanel(new FrmPacientes());
        }
        #endregion


       
    }
}
