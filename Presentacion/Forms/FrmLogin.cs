using Datos.Entidades;
using Negocio.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class FrmLogin : Form
    {
        private UsuarioService _usuarioService = new UsuarioService();
        public FrmLogin()
        {
            InitializeComponent();

            // Configuramos los botones para que no tengan ese borde feo de Windows
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;

            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.BorderSize = 0;

            // Centramos el título manualmente si hace falta
            lblTitulo.Left = (this.Width - lblTitulo.Width) / 2 + 50; // +50 por el panel latera
        }

        //boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void EjecutarLogin()
        {
            try
            {
                // 1. Obtenemos el usuario del servicio (trae datos y permisos)
                Usuario usuarioLogueado = _usuarioService.Login(txtUser.Text, txtPass.Text);

                // 2. ¡ESTA ES LA LÍNEA CLAVE! Guardamos el usuario en la sesión global
                // Sin esto, el resto del sistema no sabe quién entró.
                Negocio.Soporte.SesionUsuario.IniciarSesion(usuarioLogueado);

                MessageBox.Show($"Bienvenido, {usuarioLogueado.username}!", "Sistema Clínica",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 3. Abrimos el principal (ya no hace falta pasarle el usuario por parámetro 
                // porque ya está en la SesionUsuario, pero podés dejarlo si querés)
                FrmPrincipal principal = new FrmPrincipal();

                principal.FormClosed += (s, args) => Application.Exit();
                principal.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                // Mostramos el error (Usuario incorrecto, inactivo o campos vacíos)
                MessageBox.Show(ex.Message, "Error de Acceso",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPass.Clear();
                txtPass.Focus();
            }
        }
        // Evento del botón de login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            EjecutarLogin();
        }

        //evento para que al presionar Enter en el campo de contraseña se ejecute el login
        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Evita el sonido de "ding" al presionar Enter
                EjecutarLogin();
            }
        }

        // Si quieres que el formulario se pueda arrastrar desde cualquier parte, puedes usar este evento
        //
        private Point mouseLocation;
        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                this.Location = mousePos;
            }
        }
    }
}
