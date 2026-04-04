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
    public partial class FrmUsuarioRoles : Form
    {
        #region Atributos y Constructor
        private UsuarioService _usuarioService = new UsuarioService();
        private RolService _rolService = new RolService();
        private UsuarioRolService _usuarioRolService = new UsuarioRolService();

        private int _idUsuarioSeleccionado = 0;

        public FrmUsuarioRoles()
        {
            InitializeComponent();
        }
        #endregion



        #region Eventos de Carga y Configuración
        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            //EstiloBaseGrilla(dgvUsuarios);
            //EstiloBaseGrilla(dgvRoles);
            // Bloqueo de seguridad: El nombre de usuario no se edita aquí
            txtUsername.ReadOnly = true;
            chkUsuarioActivo.Checked = false;

            RefrescarTodo();
        }

        private void EstiloBaseGrilla(DataGridView grilla)
        {
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.MultiSelect = false;
            grilla.ReadOnly = true;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
            grilla.AllowUserToAddRows = false;
        }

        private void ConfigurarColumnasUsuarios()
        {
            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (dgvUsuarios.Columns.Count > 0)
            {
                // Ocultar IDs del DTO
                if (dgvUsuarios.Columns.Contains("IdUsuario")) dgvUsuarios.Columns["IdUsuario"].Visible = false;
                if (dgvUsuarios.Columns.Contains("IdPersona")) dgvUsuarios.Columns["IdPersona"].Visible = false;

                // Renombrar
                dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre y Apellido";
                dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
            }
        }

        private void ConfigurarColumnasRoles()
        {
            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            if (dgvRoles.Columns.Count > 0)
            {
                // Ocultar ID de la Entidad Rol
                if (dgvRoles.Columns.Contains("id_rol")) dgvRoles.Columns["id_rol"].Visible = false;

                // Renombrar
                dgvRoles.Columns["nombre_rol"].HeaderText = "Nombre del Rol";
                dgvRoles.Columns["activo"].HeaderText = "Estado Activo";
            }
        }
        private void RefrescarTodo()
        {
            try
            {
                // --- GRILLA USUARIOS ---
                dgvUsuarios.DataSource = _usuarioService.ObtenerListadoParaGrilla();
                EstiloBaseGrilla(dgvUsuarios); // Estética
                ConfigurarColumnasUsuarios();  // Columnas específicas

                // --- GRILLA ROLES ---
                var listaRoles = _rolService.ListarRoles();
                dgvRoles.DataSource = listaRoles;
                EstiloBaseGrilla(dgvRoles);    // Estética
                ConfigurarColumnasRoles();     // Columnas específicas

                // --- CHECKED LIST BOX (Solo activos) ---
                var rolesActivos = listaRoles.Where(r => r.activo).ToList();
                clbRoles.DataSource = null;
                clbRoles.DataSource = rolesActivos;
                clbRoles.DisplayMember = "nombre_rol";
                clbRoles.ValueMember = "id_rol";
            }
            catch (Exception ex) { MessageBox.Show("Error al refrescar: " + ex.Message); }
        }
        #endregion





        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // IMPORTANTE: Si e.RowIndex es -1, significa que tocó la cabecera. 
            // Salimos del método para que no intente buscar una fila inexistente.
            if (e.RowIndex < 0) return;

            try
            {
                var usuarioFila = (Datos.DTOs.UsuarioDTO)dgvUsuarios.Rows[e.RowIndex].DataBoundItem;

                _idUsuarioSeleccionado = usuarioFila.IdUsuario;

                // Mapeo de datos a los controles de la pantalla
                txtUsername.Text = usuarioFila.Username;

                // Si el estado dice "Activo", tildamos el checkbox
                chkUsuarioActivo.Checked = (usuarioFila.Estado == "Activo");

                // --- LÓGICA DE ROLES (Igual que antes) ---
                for (int i = 0; i < clbRoles.Items.Count; i++)
                    clbRoles.SetItemChecked(i, false);

                List<int> idsRolesAsignados = _usuarioRolService.ObtenerIdsRolesPorUsuario(_idUsuarioSeleccionado);

                for (int i = 0; i < clbRoles.Items.Count; i++)
                {
                    var rolItem = (Datos.Entidades.Rol)clbRoles.Items[i];
                    if (idsRolesAsignados.Contains(rolItem.id_rol))
                    {
                        clbRoles.SetItemChecked(i, true);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            // Usamos los nombres exactos de tu DTO

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _idUsuarioSeleccionado = 0;
            txtUsername.Clear();
            chkUsuarioActivo.Checked = false; // Limpiamos el check

            for (int i = 0; i < clbRoles.Items.Count; i++)
                clbRoles.SetItemChecked(i, false);

            dgvUsuarios.ClearSelection();
        }

        #region pestaña 2 - Gestión de Roles



        private int _idRolSeleccionadoCatalogo = 0;
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Obtenemos el objeto Rol de la fila
            var rol = (Datos.Entidades.Rol)dgvRoles.Rows[e.RowIndex].DataBoundItem;

            _idRolSeleccionadoCatalogo = rol.id_rol;
            txtNombreRol.Text = rol.nombre_rol;
            chkRolActivo.Checked = rol.activo;

            btnGuardarRol.Text = "Actualizar";
        }

        private void btnNuevoRol_Click(object sender, EventArgs e)
        {
            _idRolSeleccionadoCatalogo = 0;
            txtNombreRol.Clear();
            chkRolActivo.Checked = true;
            btnGuardarRol.Text = "Guardar Nuevo";
            txtNombreRol.Focus();
        }

        private void btnGuardarRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreRol.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para el rol.", "Validación");
                    return;
                }

                Datos.Entidades.Rol nuevoRol = new Datos.Entidades.Rol
                {
                    id_rol = _idRolSeleccionadoCatalogo,
                    nombre_rol = txtNombreRol.Text.Trim(),
                    activo = chkRolActivo.Checked
                };

                // El Service se encarga de decidir si es Insert o Update por el ID
                _rolService.GuardarRol(nuevoRol);

                MessageBox.Show("Rol guardado correctamente.", "Éxito");
                RefrescarTodo(); // Para que impacte en la grilla y en el CheckedListBox
                btnNuevoRol_Click(null, null); // Limpiamos campos
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        #endregion




        private void btnGuardarAsignacion_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que tengamos un usuario seleccionado de la grilla
                if (_idUsuarioSeleccionado == 0)
                {
                    MessageBox.Show("Primero seleccione un usuario de la lista izquierda.", "Aviso");
                    return;
                }

                // 2. Recolectar los IDs de los roles que están tildados en el CheckedListBox
                List<int> idsRolesSeleccionados = clbRoles.CheckedItems
                    .Cast<Datos.Entidades.Rol>()
                    .Select(r => r.id_rol)
                    .ToList();

                // 3. Mandar al Service para que haga el Delete/Insert en la tabla intermedia
                bool exito = _usuarioRolService.ActualizarRolesUsuario(_idUsuarioSeleccionado, idsRolesSeleccionados);

                if (exito)
                {
                    MessageBox.Show("Roles actualizados para el usuario: " + txtUsername.Text, "Éxito");
                    // No reseteamos el ID de usuario aquí para que el usuario pueda seguir editando 
                    // si se olvidó de tildar algo.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al sincronizar roles: " + ex.Message, "Error");
            }
        }
    }
}
