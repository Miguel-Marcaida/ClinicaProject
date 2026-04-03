
using Datos.Conexion;
using Datos.Entidades;
using Negocio.Soporte;
using Presentacion.Forms;
using System.Linq;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {

        private Point mouseLocation;
        private bool _isLoggingOut = false; // flag para distinguir
        public FrmPrincipal()
        {
            InitializeComponent();
            // Configuraciones estéticas iniciales
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // Evita que al maximizar tape la barra de tareas

        }

        #region Logica para mover la ventana sin bordes

        private void Common_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void Common_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePos;
            }
        }
        // Mantenemos los handlers nombrados por el Designer pero delegan al método común.
        private void pnlBarraTItulo_MouseDown(object sender, MouseEventArgs e) => Common_MouseDown(sender, e);
        private void pnlBarraTItulo_MouseMove(object sender, MouseEventArgs e) => Common_MouseMove(sender, e);
        private void lblModulo_MouseDown(object sender, MouseEventArgs e) => Common_MouseDown(sender, e);
        private void lblModulo_MouseMove(object sender, MouseEventArgs e) => Common_MouseMove(sender, e);
        private void lblUsuario_MouseDown(object sender, MouseEventArgs e) => Common_MouseDown(sender, e);
        private void lblUsuario_MouseMove(object sender, MouseEventArgs e) => Common_MouseMove(sender, e);



        #endregion


        #region Metodos para abrir formularios dentro del panel contenedor

        private void AbrirFormularioEnPanel(object formHijo, string nombrePermiso)
        {
            /// --- NUEVO: BLOQUEO DE SEGURIDAD ---
            // Si el permiso no es vacío (por ejemplo "Inicio" no lleva permiso) 
            // y el usuario NO lo tiene, mostramos aviso y salimos.
            if (!string.IsNullOrEmpty(nombrePermiso) && !SesionUsuario.TienePermiso(nombrePermiso))
            {
                MessageBox.Show("No tiene permisos para acceder a este módulo.",
                                "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // Asegurar que el contenedor no tenga padding ni margin que introduzcan offsets
            this.pnlContenedor.Padding = Padding.Empty;
            this.pnlContenedor.Margin = Padding.Empty;

            lblBienvenida.Visible = false;
            lblDetalleCuerpo.Visible = false;

            this.pnlContenedor.SuspendLayout();
            try
            {
                var toRemove = this.pnlContenedor.Controls
                                .Cast<Control>()
                                .Where(c => c != lblBienvenida && c != lblDetalleCuerpo)
                                .ToList();

                foreach (var c in toRemove)
                {
                    this.pnlContenedor.Controls.Remove(c);
                    if (c is Form childForm)
                    {
                        try { childForm.Close(); } catch { }
                        childForm.Dispose();
                    }
                    else
                    {
                        c.Dispose();
                    }
                }

                if (formHijo is not Form fh)
                {
                    MessageBox.Show("El objeto proporcionado no es un formulario válido.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Configuración robusta para que el form ocupe exactamente el panel
                fh.TopLevel = false;
                fh.FormBorderStyle = FormBorderStyle.None;
                fh.StartPosition = FormStartPosition.Manual;
                fh.Margin = Padding.Empty;
                fh.Padding = Padding.Empty;
                fh.Parent = this.pnlContenedor;

                // Establecer Dock y bounds en orden seguro
                fh.Dock = DockStyle.Fill;
                fh.Location = Point.Empty;
                fh.Bounds = this.pnlContenedor.ClientRectangle;
                fh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                this.pnlContenedor.Controls.Add(fh);
                fh.BringToFront();
                fh.Show();
                fh.Refresh();


                // Forzar layout/repintado del contenido
                fh.PerformLayout();
                this.pnlContenedor.PerformLayout();
                this.pnlContenedor.Refresh();
            }
            finally
            {
                this.pnlContenedor.ResumeLayout();
            }
        }
        #endregion


        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si se está cerrando por logout programático, no preguntar de nuevo
            if (_isLoggingOut)
            {
                return;
            }

            if (e.CloseReason == CloseReason.UserClosing)
            {
                var resp = MessageBox.Show("¿Desea salir del sistema?", "Cerrar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resp != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            btnInicio.Visible = true; 

            // Seguridad
            btnPacientes.Visible = SesionUsuario.TienePermiso("btnPacientes");
            btnMedicos.Visible = SesionUsuario.TienePermiso("btnMedicos");
            btnTurnos.Visible = SesionUsuario.TienePermiso("btnTurnos");
            btnGestionRoles.Visible = SesionUsuario.TienePermiso("btnGestionRoles"); // <--- AGREGAR ESTA
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
            lblModulo.Text = "AGENDA DE TURNOS";
            ResaltarBotonActivo(btnTurnos);
            AbrirFormularioEnPanel(new FrmTurnos(), "btnTurnos");
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            lblModulo.Text = "GESTIÓN DE PACIENTES";
            ResaltarBotonActivo(btnPacientes);

            // Le pasamos el formulario Y el nombre del permiso que configuraste en la DB
            AbrirFormularioEnPanel(new FrmPacientes(), "btnPacientes");
        }

        private void btnGestionRoles_Click(object sender, EventArgs e)
        {
            lblModulo.Text = "CONFIGURACIÓN DE ROLES Y PERMISOS";
            ResaltarBotonActivo(btnGestionRoles);

            // Llamamos a tu método maestro. 
            // "btnGestionRoles" es el nombre que debe existir en tu tabla 'formularios'
            AbrirFormularioEnPanel(new FrmGestionRoles(), "btnGestionRoles");
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                 "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // 1. Indicamos que es logout para evitar la confirmación en FormClosing
                _isLoggingOut = true;

                // 2. Limpiamos la sesión en memoria
                SesionUsuario.CerrarSesion();

                // 3. Solo cerramos este formulario: el login original (oculto) se mostrará
                //    porque en FrmLogin registramos principal.FormClosed para mostrar el login.
                this.Close();
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
        private void ResaltarBotonActivo(Button botonSeleccionado)
        {
            // Buscamos todos los botones dentro del panel lateral
            foreach (var boton in pnlMenu.Controls.OfType<Button>())
            {
                boton.BackColor = Color.FromArgb(30, 30, 30); // Color base
            }

            // Resaltamos solo el activo
            botonSeleccionado.BackColor = Color.FromArgb(50, 50, 50);
        }

        private void MostrarBienvenida()
        {
            // Removemos dinámicos de forma segura, preservando labels
            this.pnlContenedor.SuspendLayout();
            try
            {
                var toRemove = this.pnlContenedor.Controls
                                .Cast<Control>()
                                .Where(c => c != lblBienvenida && c != lblDetalleCuerpo)
                                .ToList();

                foreach (var c in toRemove)
                {
                    this.pnlContenedor.Controls.Remove(c);
                    if (c is Form childForm)
                    {
                        try { childForm.Close(); } catch { /* ignore */ }
                        childForm.Dispose();
                    }
                    else
                    {
                        c.Dispose();
                    }
                }

                if (!pnlContenedor.Controls.Contains(lblBienvenida))
                    this.pnlContenedor.Controls.Add(lblBienvenida);

                if (!pnlContenedor.Controls.Contains(lblDetalleCuerpo))
                    this.pnlContenedor.Controls.Add(lblDetalleCuerpo);

                if (SesionUsuario.UsuarioLogueado != null)
                {
                    string saludo = DateTime.Now.Hour < 12 ? "Buenos días," :
                                    DateTime.Now.Hour < 20 ? "Buenas tardes," : "Buenas noches,";
                    string nombreUsuario = SesionUsuario.UsuarioLogueado.username.ToUpper();

                    lblBienvenida.Text = $"{saludo}\n{nombreUsuario}";
                    lblBienvenida.Font = new Font("Segoe UI Semibold", 28, FontStyle.Bold);
                    lblBienvenida.ForeColor = Color.FromArgb(45, 45, 48);
                    lblBienvenida.AutoSize = true;
                    lblBienvenida.Location = new Point(250, 80);

                    string fechaActual = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy");
                    string rol = SesionUsuario.UsuarioLogueado.nombre_rol.ToUpper();

                    lblDetalleCuerpo.Text = $"SISTEMA DE GESTIÓN CLÍNICA  |  {rol}\n{fechaActual}";
                    lblDetalleCuerpo.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    lblDetalleCuerpo.ForeColor = Color.DarkGray;
                    lblDetalleCuerpo.AutoSize = true;
                    lblDetalleCuerpo.Location = new Point(255, lblBienvenida.Bottom + 15);
                }

                lblBienvenida.Visible = true;
                lblDetalleCuerpo.Visible = true;
                lblBienvenida.BringToFront();
                lblDetalleCuerpo.BringToFront();
            }
            finally
            {
                this.pnlContenedor.ResumeLayout();
            }
        }




        #endregion




        
    }
}
