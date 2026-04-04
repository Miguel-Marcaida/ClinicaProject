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
            btnGuardar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            chkRolActivo = new CheckBox();
            txtNombreRol = new TextBox();
            pnlLista = new Panel();
            dgvUsuarios = new DataGridView();
            tabPage2 = new TabPage();
            pnlEdicionFormulario = new Panel();
            pnlBtnFormulario = new Panel();
            btnGuardarFormulario = new Button();
            btnNuevoFormulario = new Button();
            gbDatosFormularios = new GroupBox();
            lblNombreControl = new Label();
            lblEtiqueta = new Label();
            txtNombreControl = new TextBox();
            txtEtiqueta = new TextBox();
            chkFormActivo = new CheckBox();
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
            pnlEdicion.Location = new Point(355, 3);
            pnlEdicion.Name = "pnlEdicion";
            pnlEdicion.Size = new Size(434, 416);
            pnlEdicion.TabIndex = 1;
            // 
            // pnlPermiso
            // 
            pnlPermiso.Controls.Add(clbRoles);
            pnlPermiso.Controls.Add(lblPermisosRol);
            pnlPermiso.Dock = DockStyle.Fill;
            pnlPermiso.Location = new Point(0, 100);
            pnlPermiso.Name = "pnlPermiso";
            pnlPermiso.Size = new Size(434, 216);
            pnlPermiso.TabIndex = 2;
            // 
            // clbRoles
            // 
            clbRoles.CheckOnClick = true;
            clbRoles.Dock = DockStyle.Fill;
            clbRoles.FormattingEnabled = true;
            clbRoles.Location = new Point(0, 27);
            clbRoles.Name = "clbRoles";
            clbRoles.Size = new Size(434, 189);
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
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnLimpiar);
            pnlBotones.Dock = DockStyle.Bottom;
            pnlBotones.Location = new Point(0, 316);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Padding = new Padding(8);
            pnlBotones.Size = new Size(434, 100);
            pnlBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(320, 46);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 28);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkRolActivo);
            groupBox1.Controls.Add(txtNombreRol);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Usuario";
            // 
            // chkRolActivo
            // 
            chkRolActivo.AutoSize = true;
            chkRolActivo.Location = new Point(320, 38);
            chkRolActivo.Name = "chkRolActivo";
            chkRolActivo.Size = new Size(60, 19);
            chkRolActivo.TabIndex = 1;
            chkRolActivo.Text = "Activo";
            chkRolActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(16, 36);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(220, 23);
            txtNombreRol.TabIndex = 0;
            // 
            // pnlLista
            // 
            pnlLista.Controls.Add(dgvUsuarios);
            pnlLista.Dock = DockStyle.Left;
            pnlLista.Location = new Point(3, 3);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(352, 416);
            pnlLista.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.Size = new Size(352, 732);
            dgvUsuarios.TabIndex = 0;
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
            pnlBtnFormulario.Controls.Add(btnGuardarFormulario);
            pnlBtnFormulario.Controls.Add(btnNuevoFormulario);
            pnlBtnFormulario.Dock = DockStyle.Fill;
            pnlBtnFormulario.Location = new Point(513, 12);
            pnlBtnFormulario.Name = "pnlBtnFormulario";
            pnlBtnFormulario.Size = new Size(261, 109);
            pnlBtnFormulario.TabIndex = 8;
            // 
            // btnGuardarFormulario
            // 
            btnGuardarFormulario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardarFormulario.BackColor = Color.FromArgb(0, 122, 204);
            btnGuardarFormulario.FlatAppearance.BorderSize = 0;
            btnGuardarFormulario.FlatStyle = FlatStyle.Flat;
            btnGuardarFormulario.ForeColor = Color.White;
            btnGuardarFormulario.Location = new Point(128, 76);
            btnGuardarFormulario.Name = "btnGuardarFormulario";
            btnGuardarFormulario.Size = new Size(127, 28);
            btnGuardarFormulario.TabIndex = 4;
            btnGuardarFormulario.Text = "Guardar";
            btnGuardarFormulario.UseVisualStyleBackColor = false;
            // 
            // btnNuevoFormulario
            // 
            btnNuevoFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoFormulario.BackColor = Color.FromArgb(60, 60, 60);
            btnNuevoFormulario.FlatAppearance.BorderSize = 0;
            btnNuevoFormulario.FlatStyle = FlatStyle.Flat;
            btnNuevoFormulario.ForeColor = Color.White;
            btnNuevoFormulario.Location = new Point(128, 18);
            btnNuevoFormulario.Name = "btnNuevoFormulario";
            btnNuevoFormulario.Size = new Size(127, 28);
            btnNuevoFormulario.TabIndex = 5;
            btnNuevoFormulario.Text = "Nuevo";
            btnNuevoFormulario.UseVisualStyleBackColor = false;
            // 
            // gbDatosFormularios
            // 
            gbDatosFormularios.Controls.Add(lblNombreControl);
            gbDatosFormularios.Controls.Add(lblEtiqueta);
            gbDatosFormularios.Controls.Add(txtNombreControl);
            gbDatosFormularios.Controls.Add(txtEtiqueta);
            gbDatosFormularios.Controls.Add(chkFormActivo);
            gbDatosFormularios.Dock = DockStyle.Left;
            gbDatosFormularios.Location = new Point(12, 12);
            gbDatosFormularios.Name = "gbDatosFormularios";
            gbDatosFormularios.Size = new Size(501, 109);
            gbDatosFormularios.TabIndex = 7;
            gbDatosFormularios.TabStop = false;
            gbDatosFormularios.Text = "ATENCION CON LOS DATOS DEL FORMULARIO";
            // 
            // lblNombreControl
            // 
            lblNombreControl.AutoSize = true;
            lblNombreControl.Location = new Point(36, 24);
            lblNombreControl.Name = "lblNombreControl";
            lblNombreControl.Size = new Size(110, 15);
            lblNombreControl.TabIndex = 0;
            lblNombreControl.Text = "Nombre de Control";
            // 
            // lblEtiqueta
            // 
            lblEtiqueta.AutoSize = true;
            lblEtiqueta.Location = new Point(96, 75);
            lblEtiqueta.Name = "lblEtiqueta";
            lblEtiqueta.Size = new Size(50, 15);
            lblEtiqueta.TabIndex = 1;
            lblEtiqueta.Text = "Etiqueta";
            // 
            // txtNombreControl
            // 
            txtNombreControl.Location = new Point(161, 21);
            txtNombreControl.Name = "txtNombreControl";
            txtNombreControl.Size = new Size(220, 23);
            txtNombreControl.TabIndex = 2;
            // 
            // txtEtiqueta
            // 
            txtEtiqueta.Location = new Point(161, 72);
            txtEtiqueta.Name = "txtEtiqueta";
            txtEtiqueta.Size = new Size(220, 23);
            txtEtiqueta.TabIndex = 3;
            // 
            // chkFormActivo
            // 
            chkFormActivo.AutoSize = true;
            chkFormActivo.Location = new Point(400, 24);
            chkFormActivo.Name = "chkFormActivo";
            chkFormActivo.Size = new Size(60, 19);
            chkFormActivo.TabIndex = 6;
            chkFormActivo.Text = "Activo";
            chkFormActivo.UseVisualStyleBackColor = true;
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
        private Button btnGuardar;
        private Button btnLimpiar;
        private GroupBox groupBox1;
        private CheckBox chkRolActivo;
        private TextBox txtNombreRol;
        private Panel pnlLista;
        private DataGridView dgvUsuarios;
        private TabPage tabPage2;
        private Panel pnlEdicionFormulario;
        private Panel pnlBtnFormulario;
        private Button btnGuardarFormulario;
        private Button btnNuevoFormulario;
        private GroupBox gbDatosFormularios;
        private Label lblNombreControl;
        private Label lblEtiqueta;
        private TextBox txtNombreControl;
        private TextBox txtEtiqueta;
        private CheckBox chkFormActivo;
        private Panel pnlGrillaFormulario;
        private DataGridView dgvRoles;
    }
}