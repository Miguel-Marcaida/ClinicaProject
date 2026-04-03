namespace Presentacion.Forms
{
    partial class FrmGestionRoles
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
            btnNuevoFormulario = new Button();
            chkFormActivo = new CheckBox();
            btnGuardarFormulario = new Button();
            txtEtiqueta = new TextBox();
            txtNombreControl = new TextBox();
            lblEtiqueta = new Label();
            lblNombreControl = new Label();
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
            clbFormularios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbFormularios.CheckOnClick = true;
            clbFormularios.FormattingEnabled = true;
            clbFormularios.Location = new Point(21, 41);
            clbFormularios.Name = "clbFormularios";
            clbFormularios.Size = new Size(332, 148);
            clbFormularios.TabIndex = 1;
            // 
            // lblPermisosRol
            // 
            lblPermisosRol.AutoSize = true;
            lblPermisosRol.Location = new Point(36, 14);
            lblPermisosRol.Name = "lblPermisosRol";
            lblPermisosRol.Size = new Size(94, 15);
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
            pnlBotones.Size = new Size(434, 100);
            pnlBotones.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(263, 54);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(21, 54);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 23);
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
            groupBox1.Text = "groupBox1";
            // 
            // chkRolActivo
            // 
            chkRolActivo.AutoSize = true;
            chkRolActivo.Location = new Point(249, 38);
            chkRolActivo.Name = "chkRolActivo";
            chkRolActivo.Size = new Size(60, 19);
            chkRolActivo.TabIndex = 1;
            chkRolActivo.Text = "Activo";
            chkRolActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombreRol
            // 
            txtNombreRol.Location = new Point(6, 36);
            txtNombreRol.Name = "txtNombreRol";
            txtNombreRol.Size = new Size(214, 23);
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
            pnlEdicionFormulario.Controls.Add(btnNuevoFormulario);
            pnlEdicionFormulario.Controls.Add(chkFormActivo);
            pnlEdicionFormulario.Controls.Add(btnGuardarFormulario);
            pnlEdicionFormulario.Controls.Add(txtEtiqueta);
            pnlEdicionFormulario.Controls.Add(txtNombreControl);
            pnlEdicionFormulario.Controls.Add(lblEtiqueta);
            pnlEdicionFormulario.Controls.Add(lblNombreControl);
            pnlEdicionFormulario.Dock = DockStyle.Bottom;
            pnlEdicionFormulario.Location = new Point(3, 286);
            pnlEdicionFormulario.Name = "pnlEdicionFormulario";
            pnlEdicionFormulario.Size = new Size(786, 133);
            pnlEdicionFormulario.TabIndex = 1;
            // 
            // btnNuevoFormulario
            // 
            btnNuevoFormulario.Location = new Point(519, 25);
            btnNuevoFormulario.Name = "btnNuevoFormulario";
            btnNuevoFormulario.Size = new Size(127, 23);
            btnNuevoFormulario.TabIndex = 6;
            btnNuevoFormulario.Text = "Nuevo Formulario";
            btnNuevoFormulario.UseVisualStyleBackColor = true;
            btnNuevoFormulario.Click += btnNuevoFormulario_Click;
            // 
            // chkFormActivo
            // 
            chkFormActivo.AutoSize = true;
            chkFormActivo.Location = new Point(392, 25);
            chkFormActivo.Name = "chkFormActivo";
            chkFormActivo.Size = new Size(60, 19);
            chkFormActivo.TabIndex = 5;
            chkFormActivo.Text = "Activo";
            chkFormActivo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarFormulario
            // 
            btnGuardarFormulario.Location = new Point(519, 75);
            btnGuardarFormulario.Name = "btnGuardarFormulario";
            btnGuardarFormulario.Size = new Size(127, 23);
            btnGuardarFormulario.TabIndex = 4;
            btnGuardarFormulario.Text = "Guardar Formuiario";
            btnGuardarFormulario.UseVisualStyleBackColor = true;
            btnGuardarFormulario.Click += btnGuardarFormulario_Click;
            // 
            // txtEtiqueta
            // 
            txtEtiqueta.Location = new Point(142, 72);
            txtEtiqueta.Name = "txtEtiqueta";
            txtEtiqueta.Size = new Size(218, 23);
            txtEtiqueta.TabIndex = 3;
            // 
            // txtNombreControl
            // 
            txtNombreControl.Location = new Point(140, 21);
            txtNombreControl.Name = "txtNombreControl";
            txtNombreControl.Size = new Size(220, 23);
            txtNombreControl.TabIndex = 2;
            // 
            // lblEtiqueta
            // 
            lblEtiqueta.AutoSize = true;
            lblEtiqueta.Location = new Point(75, 75);
            lblEtiqueta.Name = "lblEtiqueta";
            lblEtiqueta.Size = new Size(50, 15);
            lblEtiqueta.TabIndex = 1;
            lblEtiqueta.Text = "Etiqueta";
            // 
            // lblNombreControl
            // 
            lblNombreControl.AutoSize = true;
            lblNombreControl.Location = new Point(15, 24);
            lblNombreControl.Name = "lblNombreControl";
            lblNombreControl.Size = new Size(110, 15);
            lblNombreControl.TabIndex = 0;
            lblNombreControl.Text = "Nombre de Control";
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
            // FrmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tbcGestionRoles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmGestionRoles";
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
            pnlEdicionFormulario.PerformLayout();
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
    }
}