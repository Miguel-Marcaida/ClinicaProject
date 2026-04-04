namespace Presentacion.Forms
{
    partial class FrmUsuarioRoles
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
            tabPage1 = new TabPage();
            pnlEdicion = new Panel();
            pnlPermiso = new Panel();
            clbRoles = new CheckedListBox();
            lblPermisosRol = new Label();
            pnlBotones = new Panel();
            btnGuardarAsignacion = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            chkUsuarioActivo = new CheckBox();
            txtUsername = new TextBox();
            pnlLista = new Panel();
            dgvUsuarios = new DataGridView();
            tabPage2 = new TabPage();
            pnlEdicionFormulario = new Panel();
            pnlBtnFormulario = new Panel();
            btnGuardarRol = new Button();
            btnNuevoRol = new Button();
            gbDatosFormularios = new GroupBox();
            lblNombreRol = new Label();
            txtNombreRol = new TextBox();
            chkRolActivo = new CheckBox();
            pnlGrillaFormulario = new Panel();
            dgvRoles = new DataGridView();
            tbcGestionUsuarios.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlEdicion.SuspendLayout();
            pnlPermiso.SuspendLayout();
            pnlBotones.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tabPage2.SuspendLayout();
            pnlEdicionFormulario.SuspendLayout();
            pnlBtnFormulario.SuspendLayout();
            gbDatosFormularios.SuspendLayout();
            pnlGrillaFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            SuspendLayout();
            // 
            // tbcGestionUsuarios
            // 
            tbcGestionUsuarios.Controls.Add(tabPage1);
            tbcGestionUsuarios.Controls.Add(tabPage2);
            tbcGestionUsuarios.Dock = DockStyle.Fill;
            tbcGestionUsuarios.Location = new Point(0, 0);
            tbcGestionUsuarios.Name = "tbcGestionUsuarios";
            tbcGestionUsuarios.SelectedIndex = 0;
            tbcGestionUsuarios.Size = new Size(800, 450);
            tbcGestionUsuarios.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pnlEdicion);
            tabPage1.Controls.Add(pnlLista);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gestion de Usuarios";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlEdicion
            // 
            pnlEdicion.Controls.Add(pnlPermiso);
            pnlEdicion.Controls.Add(pnlBotones);
            pnlEdicion.Controls.Add(groupBox1);
            pnlEdicion.Dock = DockStyle.Fill;
            pnlEdicion.Location = new Point(503, 3);
            pnlEdicion.Name = "pnlEdicion";
            pnlEdicion.Size = new Size(286, 416);
            pnlEdicion.TabIndex = 1;
            // 
            // pnlPermiso
            // 
            pnlPermiso.Controls.Add(clbRoles);
            pnlPermiso.Controls.Add(lblPermisosRol);
            pnlPermiso.Dock = DockStyle.Fill;
            pnlPermiso.Location = new Point(0, 100);
            pnlPermiso.Name = "pnlPermiso";
            pnlPermiso.Size = new Size(286, 216);
            pnlPermiso.TabIndex = 2;
            // 
            // clbRoles
            // 
            clbRoles.CheckOnClick = true;
            clbRoles.Dock = DockStyle.Fill;
            clbRoles.FormattingEnabled = true;
            clbRoles.Location = new Point(0, 27);
            clbRoles.Name = "clbRoles";
            clbRoles.Size = new Size(286, 189);
            clbRoles.TabIndex = 1;
            // 
            // lblPermisosRol
            // 
            lblPermisosRol.AutoSize = true;
            lblPermisosRol.Dock = DockStyle.Top;
            lblPermisosRol.ForeColor = Color.FromArgb(45, 45, 48);
            lblPermisosRol.Location = new Point(0, 0);
            lblPermisosRol.Name = "lblPermisosRol";
            lblPermisosRol.Padding = new Padding(8, 6, 0, 6);
            lblPermisosRol.Size = new Size(105, 27);
            lblPermisosRol.TabIndex = 0;
            lblPermisosRol.Text = "Roles del Usuario";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnGuardarAsignacion);
            pnlBotones.Controls.Add(btnLimpiar);
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 316);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(8);
            pnlBotones.Size = new Size(286, 100);
            pnlBotones.TabIndex = 1;
            // 
            // btnGuardarAsignacion
            // 
            btnGuardarAsignacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarAsignacion.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardarAsignacion.FlatAppearance.BorderSize = 0;
            btnGuardarAsignacion.FlatStyle = FlatStyle.Flat;
            btnGuardarAsignacion.ForeColor = Color.White;
            btnGuardarAsignacion.Location = new Point(172, 46);
            btnGuardarAsignacion.Name = "btnGuardarAsignacion";
            btnGuardarAsignacion.Size = new Size(90, 28);
            btnGuardarAsignacion.TabIndex = 1;
            btnGuardarAsignacion.Text = "Guardar";
            btnGuardarAsignacion.UseVisualStyleBackColor = false;
            btnGuardarAsignacion.Click += btnGuardarAsignacion_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiar.BackColor = Color.FromArgb(60, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(24, 46);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 28);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkUsuarioActivo);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            // 
            // chkUsuarioActivo
            // 
            chkUsuarioActivo.AutoSize = true;
            chkUsuarioActivo.Location = new Point(16, 65);
            chkUsuarioActivo.Name = "chkUsuarioActivo";
            chkUsuarioActivo.Size = new Size(60, 19);
            chkUsuarioActivo.TabIndex = 1;
            chkUsuarioActivo.Text = "Activo";
            chkUsuarioActivo.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(16, 36);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 23);
            txtUsername.TabIndex = 0;
            // 
            // pnlLista
            // 
            pnlLista.Controls.Add(dgvUsuarios);
            pnlLista.Dock = DockStyle.Left;
            pnlLista.Location = new Point(3, 3);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(500, 416);
            pnlLista.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(500, 416);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnlEdicionFormulario);
            tabPage2.Controls.Add(pnlGrillaFormulario);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Gestion de Roles";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlEdicionFormulario
            // 
            pnlEdicionFormulario.Controls.Add(pnlBtnFormulario);
            pnlEdicionFormulario.Controls.Add(gbDatosFormularios);
            pnlEdicionFormulario.Dock = DockStyle.Bottom;
            pnlEdicionFormulario.Location = new Point(3, 286);
            pnlEdicionFormulario.Name = "pnlEdicionFormulario";
            pnlEdicionFormulario.Padding = new Padding(12);
            pnlEdicionFormulario.Size = new Size(786, 133);
            pnlEdicionFormulario.TabIndex = 1;
            // 
            // pnlBtnFormulario
            // 
            pnlBtnFormulario.Controls.Add(btnGuardarRol);
            pnlBtnFormulario.Controls.Add(btnNuevoRol);
            pnlBtnFormulario.Dock = DockStyle.Fill;
            pnlBtnFormulario.Location = new Point(513, 12);
            pnlBtnFormulario.Name = "pnlBtnFormulario";
            pnlBtnFormulario.Size = new Size(261, 109);
            pnlBtnFormulario.TabIndex = 8;
            // 
            // btnGuardarRol
            // 
            btnGuardarRol.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarRol.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardarRol.FlatAppearance.BorderSize = 0;
            btnGuardarRol.FlatStyle = FlatStyle.Flat;
            btnGuardarRol.ForeColor = Color.White;
            btnGuardarRol.Location = new Point(128, 76);
            btnGuardarRol.Name = "btnGuardarRol";
            btnGuardarRol.Size = new Size(127, 28);
            btnGuardarRol.TabIndex = 4;
            btnGuardarRol.Text = "Guardar";
            btnGuardarRol.UseVisualStyleBackColor = false;
            btnGuardarRol.Click += btnGuardarRol_Click;
            // 
            // btnNuevoRol
            // 
            btnNuevoRol.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoRol.BackColor = Color.FromArgb(60, 60, 60);
            btnNuevoRol.FlatAppearance.BorderSize = 0;
            btnNuevoRol.FlatStyle = FlatStyle.Flat;
            btnNuevoRol.ForeColor = Color.White;
            btnNuevoRol.Location = new Point(128, 18);
            btnNuevoRol.Name = "btnNuevoRol";
            btnNuevoRol.Size = new Size(127, 28);
            btnNuevoRol.TabIndex = 5;
            btnNuevoRol.Text = "Nuevo";
            btnNuevoRol.UseVisualStyleBackColor = false;
            btnNuevoRol.Click += btnNuevoRol_Click;
            // 
            // gbDatosFormularios
            // 
            gbDatosFormularios.Controls.Add(lblNombreRol);
            gbDatosFormularios.Controls.Add(txtNombreRol);
            gbDatosFormularios.Controls.Add(chkRolActivo);
            gbDatosFormularios.Dock = DockStyle.Left;
            gbDatosFormularios.Location = new Point(12, 12);
            gbDatosFormularios.Name = "gbDatosFormularios";
            gbDatosFormularios.Size = new Size(501, 109);
            gbDatosFormularios.TabIndex = 7;
            gbDatosFormularios.TabStop = false;
            gbDatosFormularios.Text = "Roles";
            // 
            // lblNombreRol
            // 
            lblNombreRol.AutoSize = true;
            lblNombreRol.Location = new Point(29, 49);
            lblNombreRol.Name = "lblNombreRol";
            lblNombreRol.Size = new Size(87, 15);
            lblNombreRol.TabIndex = 0;
            lblNombreRol.Text = "Nombre de Rol";
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(154, 46);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(220, 23);
            txtNombreRol.TabIndex = 2;
            // 
            // chkRolActivo
            // 
            chkRolActivo.AutoSize = true;
            chkRolActivo.Location = new Point(393, 49);
            chkRolActivo.Name = "chkRolActivo";
            chkRolActivo.Size = new Size(60, 19);
            chkRolActivo.TabIndex = 6;
            chkRolActivo.Text = "Activo";
            chkRolActivo.UseVisualStyleBackColor = true;
            // 
            // pnlGrillaFormulario
            // 
            pnlGrillaFormulario.Controls.Add(dgvRoles);
            pnlGrillaFormulario.Dock = DockStyle.Fill;
            pnlGrillaFormulario.Location = new Point(3, 3);
            pnlGrillaFormulario.Name = "pnlGrillaFormulario";
            pnlGrillaFormulario.Size = new Size(786, 416);
            pnlGrillaFormulario.TabIndex = 0;
            // 
            // dgvRoles
            // 
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Dock = DockStyle.Fill;
            dgvRoles.Location = new Point(0, 0);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.Size = new Size(786, 416);
            dgvRoles.TabIndex = 0;
            dgvRoles.CellClick += dgvRoles_CellClick;
            // 
            // FrmUsuarioRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcGestionUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarioRoles";
            Text = "FrmGestionUsuarios";
            Load += FrmGestionUsuarios_Load;
            tbcGestionUsuarios.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlEdicion.ResumeLayout(false);
            pnlPermiso.ResumeLayout(false);
            pnlPermiso.PerformLayout();
            pnlBotones.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tabPage2.ResumeLayout(false);
            pnlEdicionFormulario.ResumeLayout(false);
            pnlBtnFormulario.ResumeLayout(false);
            gbDatosFormularios.ResumeLayout(false);
            gbDatosFormularios.PerformLayout();
            pnlGrillaFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGestionUsuarios;
        private TabPage tabPage1;
        private Panel pnlEdicion;
        private Panel pnlPermiso;
        private CheckedListBox clbRoles;
        private Label lblPermisosRol;
        private Panel pnlBotones;
        private Button btnGuardarAsignacion;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private CheckBox chkUsuarioActivo;
        private TextBox txtUsername;
        private Panel pnlLista;
        private DataGridView dgvUsuarios;
        private TabPage tabPage2;
        private Panel pnlEdicionFormulario;
        private Panel pnlBtnFormulario;
        private Button btnGuardarRol;
        private Button btnNuevoRol;
        private GroupBox gbDatosFormularios;
        private Label lblNombreRol;
        private TextBox txtNombreRol;
        private CheckBox chkRolActivo;
        private Panel pnlGrillaFormulario;
        private DataGridView dgvRoles;
    }
}