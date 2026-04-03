using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Datos.Entidades;
using Datos.Repositorios;
using Negocio.Servicios;

namespace Presentacion.Forms
{
    public partial class FrmGestionRoles : Form
    {
        #region Atributos y Constructor
        private RolService _rolService = new RolService();
        private FormularioService _formularioService = new FormularioService();
        private RolFomularioRepositorio _rolFormularioRepo = new RolFomularioRepositorio();

        private int _idRolSeleccionado = 0;
        private int _idFormularioSeleccionado = 0;

        public FrmGestionRoles()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos de Carga y Configuración
        private void FrmGestionRoles_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla(dgvRoles);
            ConfigurarGrilla(dgvFormulario);

            // --- BLOQUEO DE SOLO LECTURA ---
            // El nombre y estado del rol no se editan aquí
            txtNombreRol.ReadOnly = true;
            chkRolActivo.Enabled = false;
            // -------------------------------

            RefrescarTodo();
        }

        private void ConfigurarGrilla(DataGridView grilla)
        {
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.MultiSelect = false;
            grilla.ReadOnly = true;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false; // Estética: quita la columna vacía de la izquierda
        }

        private void RefrescarTodo()
        {
            try
            {
                dgvRoles.DataSource = _rolService.ListarRoles();
                var formularios = _formularioService.ListarFormularios();

                dgvFormulario.DataSource = null;
                dgvFormulario.DataSource = formularios;

                clbFormularios.DataSource = null;
                clbFormularios.DataSource = formularios;
                clbFormularios.DisplayMember = "etiqueta";
                clbFormularios.ValueMember = "id_formulario";
            }
            catch (Exception ex) { MessageBox.Show("Error al refrescar datos: " + ex.Message); }
        }
        #endregion

        #region Gestión de Roles y Permisos (Pestaña 1)
        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var rol = (Rol)dgvRoles.Rows[e.RowIndex].DataBoundItem;
                _idRolSeleccionado = rol.id_rol;
                txtNombreRol.Text = rol.nombre_rol;
                chkRolActivo.Checked = rol.activo;

                // Limpiar checks actuales
                for (int i = 0; i < clbFormularios.Items.Count; i++)
                    clbFormularios.SetItemChecked(i, false);

                // Buscar permisos en la DB
                List<int> idsPermisos = _rolFormularioRepo.obtenerIdsFormulariosPorRol(_idRolSeleccionado);

                // Tildar los que correspondan
                for (int i = 0; i < clbFormularios.Items.Count; i++)
                {
                    var formItem = (Formulario)clbFormularios.Items[i];
                    if (idsPermisos.Contains(formItem.id_formulario))
                        clbFormularios.SetItemChecked(i, true);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _idRolSeleccionado = 0;
            txtNombreRol.Clear();
            chkRolActivo.Checked = false;
            for (int i = 0; i < clbFormularios.Items.Count; i++)
                clbFormularios.SetItemChecked(i, false);

            dgvRoles.ClearSelection();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_idRolSeleccionado == 0)
                {
                    MessageBox.Show("Por favor, seleccione un rol de la lista para gestionar sus permisos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Recolectar IDs tildados
                List<int> idsSeleccionados = clbFormularios.CheckedItems
                    .Cast<Formulario>()
                    .Select(f => f.id_formulario)
                    .ToList();

                _rolFormularioRepo.ActualizarPermisos(_idRolSeleccionado, idsSeleccionados);

                MessageBox.Show($"Permisos de '{txtNombreRol.Text}' sincronizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarTodo();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar permisos: " + ex.Message); }
        }
        #endregion

        #region Catálogo de Formularios (Pestaña 2)
        private void dgvFormulario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var form = (Formulario)dgvFormulario.Rows[e.RowIndex].DataBoundItem;
                _idFormularioSeleccionado = form.id_formulario;
                txtNombreControl.Text = form.nombre_control;
                txtEtiqueta.Text = form.etiqueta;
                chkFormActivo.Checked = form.activo;

                btnGuardarFormulario.Text = "Actualizar";
            }
        }

        private void btnNuevoFormulario_Click(object sender, EventArgs e)
        {
            _idFormularioSeleccionado = 0;
            txtNombreControl.Clear();
            txtEtiqueta.Clear();
            chkFormActivo.Checked = true;
            btnGuardarFormulario.Text = "Guardar Nuevo";
            txtNombreControl.Focus();
        }

        private void btnGuardarFormulario_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreControl.Text) || string.IsNullOrWhiteSpace(txtEtiqueta.Text))
                {
                    MessageBox.Show("Debe completar el nombre del control y la etiqueta descriptiva.", "Validación");
                    return;
                }

                Formulario form = new Formulario
                {
                    id_formulario = _idFormularioSeleccionado,
                    nombre_control = txtNombreControl.Text.Trim(),
                    etiqueta = txtEtiqueta.Text.Trim(),
                    activo = chkFormActivo.Checked
                };

                _formularioService.GuardarFormulario(form);

                string msj = _idFormularioSeleccionado == 0 ? "Formulario añadido al catálogo." : "Datos del catálogo actualizados.";
                MessageBox.Show(msj, "Éxito");

                btnNuevoFormulario_Click(null, null);
                RefrescarTodo();
            }
            catch (Exception ex) { MessageBox.Show("Error al guardar en catálogo: " + ex.Message); }
        }
        #endregion
    }
}