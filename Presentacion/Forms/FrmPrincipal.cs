
using Datos.Conexion;
using Datos.Entidades;
using Negocio.Soporte;
using Presentacion.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {

        private Point mouseLocation;
        public FrmPrincipal()
        {
            InitializeComponent();
            // Configuraciones estéticas iniciales
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Evita que al maximizar tape la barra de tareas
        
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
            // Ocultamos los labels de bienvenida antes de cargar el form
            lblBienvenida.Visible = false;
            lblDetalleCuerpo.Visible = false;
            //if (picUser != null) picUser.Visible = false;

            if (this.pnlContenedor.Controls.Count > 0)
                this.pnlContenedor.Controls.Clear();

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            fh.BackColor = Color.Red;

            this.pnlContenedor.Controls.Add(fh);
            //this.pnlContenedor.Tag = fh;
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {


            // Seguridad
            btnPacientes.Visible = SesionUsuario.TienePermiso("btnPacientes");
            btnMedicos.Visible = SesionUsuario.TienePermiso("btnMedicos");
            btnTurnos.Visible = SesionUsuario.TienePermiso("btnTurnos");

            // Mostramos la barra superior
            if (SesionUsuario.UsuarioLogueado != null)
            {
                lblUsuario.Text = $"👤 {SesionUsuario.UsuarioLogueado.username.ToUpper()}";
                lblUsuario.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblUsuario.ForeColor = Color.White;
            }

            // Llamamos a la bienvenida
            MostrarBienvenida();
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
            lblModulo.Text = "GESTIÓN DE PACIENTES";
            ResaltarBotonActivo(btnPacientes);

            // Al abrir el form, el método AbrirFormularioEnPanel ya limpia el panel
            AbrirFormularioEnPanel(new FrmPacientes());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // 1. Limpiamos la sesión en memoria
                SesionUsuario.UsuarioLogueado = null;

                // 2. Cerramos este formulario y abrimos el Login
                this.Hide(); // O this.Close() según cómo lances el Main
                FrmLogin login = new FrmLogin();
                login.Show();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ResaltarBotonActivo(btnInicio);
            lblModulo.Text = "INICIO";

            // Simplemente llamamos al método maestro
            MostrarBienvenida();
        }

        #endregion


        #region metodos
        private void ResaltarBotonActivo(Button boton)
        {
            // Resetear todos los botones a color normal (Negro/Gris)
            btnInicio.BackColor = Color.FromArgb(30, 30, 30);
            btnPacientes.BackColor = Color.FromArgb(30, 30, 30);
            // ... repetir para los otros

            // Resaltar el que tocamos (Un gris un poco más claro o el color de tu logo)
            boton.BackColor = Color.FromArgb(50, 50, 50);
        }



        private void MostrarBienvenida()
        {
            this.pnlContenedor.Controls.Clear();

            if (!pnlContenedor.Controls.Contains(lblBienvenida))
            {
                this.pnlContenedor.Controls.Add(lblBienvenida);
                this.pnlContenedor.Controls.Add(lblDetalleCuerpo);
            }

            if (SesionUsuario.UsuarioLogueado != null)
            {
                // 1. Lógica de saludo
                string saludo = DateTime.Now.Hour < 12 ? "Buenos días," :
                                DateTime.Now.Hour < 20 ? "Buenas tardes," : "Buenas noches,";
                string nombreUsuario = SesionUsuario.UsuarioLogueado.username.ToUpper();

                // 2. FORMATO DEL TÍTULO (El "Impacto")
                // Usamos saltos de línea y tabulaciones sutiles para dar aire
                lblBienvenida.Text = $"{saludo}\n{nombreUsuario}";
                lblBienvenida.Font = new Font("Segoe UI Semibold", 28, FontStyle.Bold);
                lblBienvenida.ForeColor = Color.FromArgb(45, 45, 48); // Un gris casi negro, muy elegante
                lblBienvenida.AutoSize = true;
                lblBienvenida.Location = new Point(250, 80); // Ajustá estas coordenadas a tu gusto

                // 3. FORMATO DEL DETALLE (La "Info")
                string fechaActual = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
                string rol = SesionUsuario.UsuarioLogueado.nombre_rol.ToUpper();

                lblDetalleCuerpo.Text = $"SISTEMA DE GESTIÓN CLÍNICA  |  {rol}\n{fechaActual}";
                lblDetalleCuerpo.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                lblDetalleCuerpo.ForeColor = Color.DarkGray;
                lblDetalleCuerpo.AutoSize = true;

                // Lo ubicamos unos píxeles debajo del nombre
                lblDetalleCuerpo.Location = new Point(255, lblBienvenida.Bottom + 15);
            }

            lblBienvenida.Visible = true;
            lblDetalleCuerpo.Visible = true;
            lblBienvenida.BringToFront();
            lblDetalleCuerpo.BringToFront();
        }

        #endregion



    }
}
