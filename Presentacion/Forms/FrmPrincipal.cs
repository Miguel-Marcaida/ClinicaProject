
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
            // Validamos ANTES de hacer cualquier movimiento visual
            if (!SesionUsuario.TienePermiso(nombrePermiso))
            {
                MessageBox.Show("No tenés permisos para acceder a este módulo.",
                                "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // Ocultamos los labels de bienvenida antes de cargar el form
            lblBienvenida.Visible = false;
            lblDetalleCuerpo.Visible = false;
            //if (picUser != null) picUser.Visible = false;

            // Liberamos y limpiamos controles previos del panel
            if (this.pnlContenedor.Controls.Count > 0)
            {
                // No disponer los labels persistentes: solo eliminar/dispone los controles dinámicos
                var toRemove = this.pnlContenedor.Controls
                                .Cast<Control>()
                                .Where(c => c != lblBienvenida && c != lblDetalleCuerpo)
                                .ToList();

                foreach (var c in toRemove)
                {
                    this.pnlContenedor.Controls.Remove(c);
                    c.Dispose();
                }
            }

            // Comprobación nula y seguridad de tipo
            if (formHijo is not Form fh)
            {
                MessageBox.Show("El objeto proporcionado no es un formulario válido.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           // Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            //fh.BackColor = Color.Red;

            this.pnlContenedor.Controls.Add(fh);
            //this.pnlContenedor.Tag = fh;
            fh.BringToFront();
            fh.Show();
        }



        #endregion


       

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

            // Le pasamos el formulario Y el nombre del permiso que configuraste en la DB
            AbrirFormularioEnPanel(new FrmPacientes(), "btnPacientes");
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
            
            // No limpiamos todo: solo removemos controles dinámicos para preservar las etiquetas persistentes
            var toRemove = this.pnlContenedor.Controls
                            .Cast<Control>()
                            .Where(c => c != lblBienvenida && c != lblDetalleCuerpo)
                            .ToList();

            foreach (var c in toRemove)
            {
                this.pnlContenedor.Controls.Remove(c);
                c.Dispose();
            }

            if (!pnlContenedor.Controls.Contains(lblBienvenida))
            {
                this.pnlContenedor.Controls.Add(lblBienvenida);
            }

            if (!pnlContenedor.Controls.Contains(lblDetalleCuerpo))
            {
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
