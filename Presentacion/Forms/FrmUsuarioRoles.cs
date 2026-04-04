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
            ConfigurarGrilla(dgvUsuarios);
            ConfigurarGrilla(dgvRoles);
            // Bloqueo de seguridad: El nombre de usuario no se edita aquí
            //txtUsername.ReadOnly = true;
            //chkUserActivo.Enabled = false;

            RefrescarTodo();
        }

        private void ConfigurarGrilla(DataGridView grilla)
        {
            grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grilla.MultiSelect = false;
            grilla.ReadOnly = true;
            grilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grilla.RowHeadersVisible = false;
        }

        private void RefrescarTodo()
        {
            try
            {
                // Cargamos la grilla de usuarios
                dgvUsuarios.DataSource = _usuarioService.ListarUsuarios();

                // Cargamos el catálogo de roles disponibles en el CheckedListBox
                dgvRoles.DataSource = _rolService.ListarRoles();
                var roles = _rolService.ListarRoles().Where(r => r.activo).ToList();
                clbRoles.DataSource = null;
                clbRoles.DataSource = roles;
                clbRoles.DisplayMember = "nombre_rol";
                clbRoles.ValueMember = "id_rol";
            }
            catch (Exception ex) { MessageBox.Show("Error al refrescar datos: " + ex.Message); }
        }
        #endregion





    }
}
