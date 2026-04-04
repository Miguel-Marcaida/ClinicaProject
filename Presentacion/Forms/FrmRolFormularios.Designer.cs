namespace Presentacion.Forms
{
    partial class FrmRolFormularios
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
            tbcGestionRoles = new TabControl();
            tabPage1 = new TabPage();
            pnlEdicion = new Panel();
            pnlPermiso = new Panel();
            clbFormularios = new CheckedListBox();
            lblPermisosRol = new Label();
            pnlBotones = new Panel();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            groupBox1 = new GroupBox();
            chkRolActivo = new CheckBox();
            txtNombreRol = new TextBox();
            pnlLista = new Panel();
            dgvRoles = new DataGridView();
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
            dgvFormulario = new DataGridView();
            tbcGestionRoles.SuspendLayout();
            tabPage1.SuspendLayout();
            pnlEdicion.SuspendLayout();
            pnlPermiso.SuspendLayout();
            pnlBotones.SuspendLayout();
            groupBox1.SuspendLayout();
            pnlLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            tabPage2.SuspendLayout();
            pnlEdicionFormulario.SuspendLayout();
            pnlBtnFormulario.SuspendLayout();
            gbDatosFormularios.SuspendLayout();
            pnlGrillaFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFormulario).BeginInit();
            SuspendLayout();
            // 
            // tbcGestionRoles
            // 
            tbcGestionRoles.Controls.Add(tabPage1);
            tbcGestionRoles.Controls.Add(tabPage2);
            tbcGestionRoles.Dock = DockStyle.Fill;
            tbcGestionRoles.Location = new Point(0, 0);
            tbcGestionRoles.Name = "tbcGestionRoles";
            tbcGestionRoles.SelectedIndex = 0;
            tbcGestionRoles.Size = new Size(800, 450);
            tbcGestionRoles.TabIndex = 0;
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
            tabPage1.Text = "Gestion de Roles";
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
            pnlPermiso.Controls.Add(clbFormularios);
            pnlPermiso.Controls.Add(lblPermisosRol);
            pnlPermiso.Dock = DockStyle.Fill;
            pnlPermiso.Location = new Point(0, 100);
            pnlPermiso.Name = "pnlPermiso";
            pnlPermiso.Size = new Size(434, 216);
            pnlPermiso.TabIndex = 2;
            // 
            // clbFormularios
            // 
            clbFormularios.CheckOnClick = true;
            clbFormularios.Dock = DockStyle.Fill;
            clbFormularios.FormattingEnabled = true;
            clbFormularios.Location = new Point(0, 27);
            clbFormularios.Name = "clbFormularios";
            clbFormularios.Size = new Size(434, 189);
            clbFormularios.TabIndex = 1;
            // 
            // lblPermisosRol
            // 
            lblPermisosRol.AutoSize = true;
            lblPermisosRol.Dock = DockStyle.Top;
            lblPermisosRol.ForeColor = Color.FromArgb(45, 45, 48);
            lblPermisosRol.Location = new Point(0, 0);
            lblPermisosRol.Name = "lblPermisosRol";
            lblPermisosRol.Padding = new Padding(8, 6, 0, 6);
            lblPermisosRol.Size = new Size(102, 27);
            lblPermisosRol.TabIndex = 0;
            lblPermisosRol.Text = "Permisos del Rol";
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
            btnGuardar.Location = new Point(332, 54);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 28);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLimpiar.BackColor = Color.FromArgb(60, 60, 60);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(16, 54);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 28);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
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
            groupBox1.Text = "Datos del Rol";
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
            pnlLista.Controls.Add(dgvRoles);
            pnlLista.Dock = DockStyle.Left;
            pnlLista.Location = new Point(3, 3);
            pnlLista.Name = "pnlLista";
            pnlLista.Size = new Size(352, 416);
            pnlLista.TabIndex = 0;
            // 
            // dgvRoles
            // 
            dgvRoles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoles.Location = new Point(0, 0);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.RowHeadersVisible = false;
            dgvRoles.Size = new Size(352, 416);
            dgvRoles.TabIndex = 0;
            dgvRoles.CellClick += dgvRoles_CellClick;
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
            tabPage2.Text = "Gestion Formulario";
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
            btnGuardarFormulario.Location = new Point(67, 67);
            btnGuardarFormulario.Name = "btnGuardarFormulario";
            btnGuardarFormulario.Size = new Size(127, 28);
            btnGuardarFormulario.TabIndex = 4;
            btnGuardarFormulario.Text = "Guardar";
            btnGuardarFormulario.UseVisualStyleBackColor = false;
            btnGuardarFormulario.Click += btnGuardarFormulario_Click;
            // 
            // btnNuevoFormulario
            // 
            btnNuevoFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoFormulario.BackColor = Color.FromArgb(60, 60, 60);
            btnNuevoFormulario.FlatAppearance.BorderSize = 0;
            btnNuevoFormulario.FlatStyle = FlatStyle.Flat;
            btnNuevoFormulario.ForeColor = Color.White;
            btnNuevoFormulario.Location = new Point(67, 18);
            btnNuevoFormulario.Name = "btnNuevoFormulario";
            btnNuevoFormulario.Size = new Size(127, 28);
            btnNuevoFormulario.TabIndex = 5;
            btnNuevoFormulario.Text = "Nuevo";
            btnNuevoFormulario.UseVisualStyleBackColor = false;
            btnNuevoFormulario.Click += btnNuevoFormulario_Click;
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
            pnlGrillaFormulario.Controls.Add(dgvFormulario);
            pnlGrillaFormulario.Dock = DockStyle.Fill;
            pnlGrillaFormulario.Location = new Point(3, 3);
            pnlGrillaFormulario.Name = "pnlGrillaFormulario";
            pnlGrillaFormulario.Size = new Size(786, 416);
            pnlGrillaFormulario.TabIndex = 0;
            // 
            // dgvFormulario
            // 
            dgvFormulario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFormulario.Dock = DockStyle.Fill;
            dgvFormulario.Location = new Point(0, 0);
            dgvFormulario.Name = "dgvFormulario";
            dgvFormulario.Size = new Size(786, 416);
            dgvFormulario.TabIndex = 0;
            dgvFormulario.CellClick += dgvFormulario_CellClick;
            // 
            // FrmRolFormularios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcGestionRoles);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRolFormularios";
            Text = "FrmGestionRoles";
            Load += FrmGestionRoles_Load;
            tbcGestionRoles.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            pnlEdicion.ResumeLayout(false);
            pnlPermiso.ResumeLayout(false);
            pnlPermiso.PerformLayout();
            pnlBotones.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            tabPage2.ResumeLayout(false);
            pnlEdicionFormulario.ResumeLayout(false);
            pnlBtnFormulario.ResumeLayout(false);
            gbDatosFormularios.ResumeLayout(false);
            gbDatosFormularios.PerformLayout();
            pnlGrillaFormulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFormulario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbcGestionRoles;
        private TabPage tabPage1;
        private Panel pnlEdicion;
        private Panel pnlLista;
        private DataGridView dgvRoles;
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Panel pnlBotones;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private CheckBox chkRolActivo;
        private TextBox txtNombreRol;
        private Panel pnlPermiso;
        private CheckedListBox clbFormularios;
        private Label lblPermisosRol;
        private Panel pnlEdicionFormulario;
        private Panel pnlGrillaFormulario;
        private Button btnGuardarFormulario;
        private TextBox txtEtiqueta;
        private TextBox txtNombreControl;
        private Label lblEtiqueta;
        private Label lblNombreControl;
        private DataGridView dgvFormulario;
        private CheckBox chkFormActivo;
        private Button btnNuevoFormulario;
        private GroupBox gbDatosFormularios;
        private Panel pnlBtnFormulario;
    }
}