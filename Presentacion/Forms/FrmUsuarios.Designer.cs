namespace Presentacion.Forms
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbcGestionUsuarios = new TabControl();
            tabListado = new TabPage();
            pnlGrilla = new Panel();
            dgvUsuarios = new DataGridView();
            gpBotonera = new GroupBox();
            btnVerFicha = new Button();
            btnEliminar = new Button();
            gbBusqueda = new GroupBox();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lblbuscar = new Label();
            tpDatosPersonales = new TabPage();
            pnlABM = new Panel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnNuevo = new Button();
            gbDatosCuenta = new GroupBox();
            chkActivo = new CheckBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblUserName = new Label();
            gbDatosPersonales = new GroupBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            dtpFechaNac = new DateTimePicker();
            lblFechaNac = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            lblDni = new Label();
            tbcGestionUsuarios.SuspendLayout();
            tabListado.SuspendLayout();
            pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            gpBotonera.SuspendLayout();
            gbBusqueda.SuspendLayout();
            tpDatosPersonales.SuspendLayout();
            pnlABM.SuspendLayout();
            gbDatosCuenta.SuspendLayout();
            gbDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // tbcGestionUsuarios
            // 
            tbcGestionUsuarios.Controls.Add(tabListado);
            tbcGestionUsuarios.Controls.Add(tpDatosPersonales);
            tbcGestionUsuarios.Dock = DockStyle.Fill;
            tbcGestionUsuarios.Location = new Point(0, 0);
            tbcGestionUsuarios.Name = "tbcGestionUsuarios";
            tbcGestionUsuarios.SelectedIndex = 0;
            tbcGestionUsuarios.Size = new Size(800, 450);
            tbcGestionUsuarios.TabIndex = 0;
            // 
            // tabListado
            // 
            tabListado.Controls.Add(pnlGrilla);
            tabListado.Controls.Add(gpBotonera);
            tabListado.Controls.Add(gbBusqueda);
            tabListado.Location = new Point(4, 24);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(792, 422);
            tabListado.TabIndex = 0;
            tabListado.Text = "Lista de Usuarios";
            tabListado.UseVisualStyleBackColor = true;
            // 
            // pnlGrilla
            // 
            pnlGrilla.Controls.Add(dgvUsuarios);
            pnlGrilla.Dock = DockStyle.Fill;
            pnlGrilla.Location = new Point(3, 63);
            pnlGrilla.Name = "pnlGrilla";
            pnlGrilla.Size = new Size(786, 306);
            pnlGrilla.TabIndex = 2;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(786, 306);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellDoubleClick += dgvUsuarios_CellDoubleClick;
            // 
            // gpBotonera
            // 
            gpBotonera.Controls.Add(btnVerFicha);
            gpBotonera.Controls.Add(btnEliminar);
            gpBotonera.Dock = DockStyle.Bottom;
            gpBotonera.Location = new Point(3, 369);
            gpBotonera.Name = "gpBotonera";
            gpBotonera.Size = new Size(786, 50);
            gpBotonera.TabIndex = 1;
            gpBotonera.TabStop = false;
            gpBotonera.Text = "Detalles";
            // 
            // btnVerFicha
            // 
            btnVerFicha.BackColor = Color.FromArgb(60, 60, 60);
            btnVerFicha.FlatAppearance.BorderSize = 0;
            btnVerFicha.FlatStyle = FlatStyle.Flat;
            btnVerFicha.ForeColor = Color.White;
            btnVerFicha.Location = new Point(53, 16);
            btnVerFicha.Name = "btnVerFicha";
            btnVerFicha.Size = new Size(90, 28);
            btnVerFicha.TabIndex = 0;
            btnVerFicha.Text = "Ver Ficha";
            btnVerFicha.UseVisualStyleBackColor = false;
            btnVerFicha.Click += btnVerFicha_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(60, 60, 60);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(149, 16);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 28);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Dar De Baja";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // gbBusqueda
            // 
            gbBusqueda.Controls.Add(btnBuscar);
            gbBusqueda.Controls.Add(txtBuscar);
            gbBusqueda.Controls.Add(lblbuscar);
            gbBusqueda.Dock = DockStyle.Top;
            gbBusqueda.Location = new Point(3, 3);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(786, 60);
            gbBusqueda.TabIndex = 0;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = "Criterio de busqueda";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(0, 122, 204);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(605, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(210, 23);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(370, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // lblbuscar
            // 
            lblbuscar.AutoSize = true;
            lblbuscar.Location = new Point(103, 26);
            lblbuscar.Name = "lblbuscar";
            lblbuscar.Size = new Size(76, 15);
            lblbuscar.TabIndex = 0;
            lblbuscar.Text = "DNI/Apellido";
            // 
            // tpDatosPersonales
            // 
            tpDatosPersonales.Controls.Add(pnlABM);
            tpDatosPersonales.Controls.Add(gbDatosCuenta);
            tpDatosPersonales.Controls.Add(gbDatosPersonales);
            tpDatosPersonales.Location = new Point(4, 24);
            tpDatosPersonales.Name = "tpDatosPersonales";
            tpDatosPersonales.Padding = new Padding(3);
            tpDatosPersonales.Size = new Size(792, 422);
            tpDatosPersonales.TabIndex = 1;
            tpDatosPersonales.Text = "Ficha del Usuario";
            tpDatosPersonales.UseVisualStyleBackColor = true;
            // 
            // pnlABM
            // 
            pnlABM.Controls.Add(btnGuardar);
            pnlABM.Controls.Add(btnCancelar);
            pnlABM.Controls.Add(btnNuevo);
            pnlABM.Dock = DockStyle.Bottom;
            pnlABM.Location = new Point(402, 319);
            pnlABM.Name = "pnlABM";
            pnlABM.Size = new Size(387, 100);
            pnlABM.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(132, 67);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 28);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(60, 60, 60);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(257, 67);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 28);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(60, 60, 60);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(5, 67);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(127, 28);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbDatosCuenta
            // 
            gbDatosCuenta.Controls.Add(chkActivo);
            gbDatosCuenta.Controls.Add(lblPass);
            gbDatosCuenta.Controls.Add(txtPassword);
            gbDatosCuenta.Controls.Add(txtUsername);
            gbDatosCuenta.Controls.Add(lblUserName);
            gbDatosCuenta.Dock = DockStyle.Top;
            gbDatosCuenta.Location = new Point(402, 3);
            gbDatosCuenta.Name = "gbDatosCuenta";
            gbDatosCuenta.Size = new Size(387, 218);
            gbDatosCuenta.TabIndex = 5;
            gbDatosCuenta.TabStop = false;
            gbDatosCuenta.Text = "Datos de Cuenta";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(68, 174);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(64, 19);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "ACTVO";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(68, 117);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(83, 15);
            lblPass.TabIndex = 10;
            lblPass.Text = "CONTRASEÑA";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(68, 135);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(68, 79);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 23);
            txtUsername.TabIndex = 8;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(68, 61);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(125, 15);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "NOMBRE DE USUARIO";
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(lblDireccion);
            gbDatosPersonales.Controls.Add(txtDireccion);
            gbDatosPersonales.Controls.Add(dtpFechaNac);
            gbDatosPersonales.Controls.Add(lblFechaNac);
            gbDatosPersonales.Controls.Add(lblTelefono);
            gbDatosPersonales.Controls.Add(lblEmail);
            gbDatosPersonales.Controls.Add(lblApellido);
            gbDatosPersonales.Controls.Add(lblNombre);
            gbDatosPersonales.Controls.Add(txtTelefono);
            gbDatosPersonales.Controls.Add(txtEmail);
            gbDatosPersonales.Controls.Add(txtApellido);
            gbDatosPersonales.Controls.Add(txtNombre);
            gbDatosPersonales.Controls.Add(txtDni);
            gbDatosPersonales.Controls.Add(lblDni);
            gbDatosPersonales.Dock = DockStyle.Left;
            gbDatosPersonales.Location = new Point(3, 3);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Size = new Size(399, 416);
            gbDatosPersonales.TabIndex = 0;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Datos Personales";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(33, 203);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(68, 15);
            lblDireccion.TabIndex = 13;
            lblDireccion.Text = "DIRECCION";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(33, 221);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(250, 23);
            txtDireccion.TabIndex = 4;
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(41, 371);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(250, 23);
            dtpFechaNac.TabIndex = 7;
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(41, 353);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(135, 15);
            lblFechaNac.TabIndex = 10;
            lblFechaNac.Text = "FECHA DE NACIMIENTO";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(39, 297);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(64, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "TELEFONO";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(41, 247);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "EMAIL";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(37, 152);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(60, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "APELLIDO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 98);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "NOMBRE";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(35, 314);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(37, 170);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 23);
            txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(37, 60);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(250, 23);
            txtDni.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(37, 42);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcGestionUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
            tbcGestionUsuarios.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            gpBotonera.ResumeLayout(false);
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            tpDatosPersonales.ResumeLayout(false);
            pnlABM.ResumeLayout(false);
            gbDatosCuenta.ResumeLayout(false);
            gbDatosCuenta.PerformLayout();
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGestionUsuarios;
        private TabPage tabListado;
        private TabPage tpDatosPersonales;
        private Panel pnlGrilla;
        private GroupBox gpBotonera;
        private GroupBox gbBusqueda;
        private Label lblbuscar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnVerFicha;
        private DataGridView dgvUsuarios;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnGuardar;
        private GroupBox gbDatosPersonales;
        private TextBox txtDni;
        private Label lblDni;
        private DateTimePicker dtpFechaNac;
        private Label lblFechaNac;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private GroupBox gbDatosCuenta;
        private Label lblPass;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblUserName;
        private CheckBox chkActivo;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Panel pnlABM;
        private Button btnEliminar;
    }
}