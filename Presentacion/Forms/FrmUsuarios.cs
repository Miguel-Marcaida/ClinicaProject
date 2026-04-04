using Datos.DTOs;
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
    public partial class FrmUsuarios : Form
    {

        private UsuarioService _usuarioService = new UsuarioService();
        private int idUsuarioSeleccionado = 0;
        private int idPersonaSeleccionada = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void ActualizarListado()
        {
            try
            {
                List<UsuarioDTO> lista = _usuarioService.ObtenerListadoParaGrilla();

                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = lista;

                // 1. Ocultar columnas técnicas
                if (dgvUsuarios.Columns["IdUsuario"] != null) dgvUsuarios.Columns["IdUsuario"].Visible = false;
                if (dgvUsuarios.Columns["IdPersona"] != null) dgvUsuarios.Columns["IdPersona"].Visible = false;

                // 2. Estética básica
                dgvUsuarios.Columns["DNI"].Width = 80;
                dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Apellido y Nombre";
                dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
                dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // 3. LLAMAR AL FORMATO DE COLORES (Esto te faltaba integrar)
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrilla()
        {
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                // Usamos el nombre de la propiedad del DTO "Estado"
                if (row.Cells["Estado"].Value != null && row.Cells["Estado"].Value.ToString() == "Inactivo")
                {
                    // Ponemos el texto en gris y cursiva para denotar que está "apagado"
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                    row.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
                }
                else
                {
                    // Restauramos colores originales para los activos
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }


        private void LimpiarCampos()
        {
            // Datos Personales
            txtDni.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear(); // El que agregaste vos
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNac.Value = DateTime.Now.AddYears(-18); // Por defecto mayores de edad

            // Datos de Usuario
            txtUsername.Clear();
            txtPassword.Clear();
            chkActivo.Checked = true;

            idUsuarioSeleccionado = 0;
            idPersonaSeleccionada = 0;
            // Resetear foco
            txtDni.Focus();
        }

        private void CargarDatosEnFicha()
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                int idSeleccionado = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);
                Usuario u = _usuarioService.BuscarPorId(idSeleccionado);
                if (u != null)
                {
                    idUsuarioSeleccionado = u.id_usuario;
                    idPersonaSeleccionada = u.id_persona;
                    txtDni.Text = u.dni;
                    txtNombre.Text = u.nombre;
                    txtApellido.Text = u.apellido;
                    txtDireccion.Text = u.direccion; // ¡Ahora sí!
                    txtTelefono.Text = u.telefono;
                    txtEmail.Text = u.email;
                    dtpFechaNac.Value = u.fecha_nacimiento;
                    txtUsername.Text = u.username;
                    chkActivo.Checked = u.activo;
                    btnGuardar.Text = "Actualizar";
                    btnGuardar.BackColor = Color.LightSkyBlue;
                    tbcGestionUsuarios.SelectedIndex = 1;
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ActualizarListado();
            chkActivo.Checked = true; // Por defecto, al crear un nuevo usuario, estará activo
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            tbcGestionUsuarios.SelectedIndex = 0; // Vuelve a la pestaña del listado
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            idUsuarioSeleccionado = 0; // Importante: resetear a cero
            btnGuardar.Text = "Guardar";
            btnGuardar.BackColor = Color.LightGreen;
            // IMPORTANTE: Cambiamos a la pestaña 1 (Ficha) para cargar el nuevo
            tbcGestionUsuarios.SelectedIndex = 1;
            txtDni.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Cargamos el objeto con los datos de los TextBox/DTP
                Usuario user = new Usuario
                {
                    id_usuario = idUsuarioSeleccionado,
                    id_persona = idPersonaSeleccionada,
                    dni = txtDni.Text.Trim(),
                    nombre = txtNombre.Text.Trim(),
                    apellido = txtApellido.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    fecha_nacimiento = dtpFechaNac.Value,
                    username = txtUsername.Text.Trim(),
                    password_hash = txtPassword.Text, // Se envía, pero el repo decidirá si usarla
                    activo = chkActivo.Checked
                };

                // 2. Decidimos qué acción tomar según el ID
                if (idUsuarioSeleccionado == 0)
                {
                    _usuarioService.GuardarUsuario(user);
                    MessageBox.Show("Usuario registrado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Verificamos si el admin escribió algo en el campo password
                    bool modificaPass = !string.IsNullOrWhiteSpace(txtPassword.Text);

                    _usuarioService.ModificarUsuario(user, modificaPass);
                    MessageBox.Show("Usuario actualizado con éxito.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 3. Limpieza y refresco
                ActualizarListado();
                LimpiarCampos();
                idUsuarioSeleccionado = 0; // REGLA DE ORO: Resetear el ID para que la próxima sea un Alta
                idPersonaSeleccionada = 0;
                tbcGestionUsuarios.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que no hayan hecho clic en el encabezado
            if (e.RowIndex >= 0)
            {
                CargarDatosEnFicha();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                // 1. Obtener datos de la fila seleccionada
                var seleccionado = (UsuarioDTO)dgvUsuarios.CurrentRow.DataBoundItem;

                // 2. Pedir confirmación
                DialogResult result = MessageBox.Show(
                    $"¿Está seguro que desea dar de baja al usuario {seleccionado.Username}?",
                    "Confirmar Eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _usuarioService.EliminarUsuario(seleccionado.IdUsuario, seleccionado.IdPersona);
                        MessageBox.Show("Usuario dado de baja.");
                        ActualizarListado(); // Refrescar la grilla
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario de la lista.");
            }
        }

        private void btnVerFicha_Click(object sender, EventArgs e)
        {
            // Reutilizamos la lógica del doble clic si hay una fila seleccionada
            if (dgvUsuarios.CurrentRow != null)
            {
                // Llamamos al método que carga los datos (el que usa BuscarPorId)
                CargarDatosEnFicha();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario de la lista primero.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (!string.IsNullOrEmpty(busqueda))
            {
                try
                {
                    // Llamamos al Service (el que acabamos de crear)
                    var resultado = _usuarioService.BuscarUsuarios(busqueda);

                    dgvUsuarios.DataSource = null;
                    dgvUsuarios.DataSource = resultado;

                    // No te olvides de volver a aplicar el formato gris a los inactivos
                    FormatearGrilla();

                    // Ocultar IDs
                    if (dgvUsuarios.Columns["IdUsuario"] != null) dgvUsuarios.Columns["IdUsuario"].Visible = false;
                    if (dgvUsuarios.Columns["IdPersona"] != null) dgvUsuarios.Columns["IdPersona"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar: " + ex.Message);
                }
            }
            else
            {
                // Si el buscador está vacío, mostramos todos de nuevo
                ActualizarListado();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e); // Llama al botón que ya programaste
                e.SuppressKeyPress = true; // Evita el "beep" de Windows
            }
        }
    }
}
