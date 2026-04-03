namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            pnlLogo = new Panel();
            btnGestionRoles = new Button();
            btnConfig = new Button();
            btnMedicos = new Button();
            btnPacientes = new Button();
            btnTurnos = new Button();
            btnInicio = new Button();
            btnCerrarSesion = new Button();
            pnlContenedor = new Panel();
            lblDetalleCuerpo = new Label();
            lblBienvenida = new Label();
            pnlBarraTItulo = new Panel();
            btnCerrar = new Button();
            lblUsuario = new Label();
            lblModulo = new Label();
            pnlMenu.SuspendLayout();
            pnlContenedor.SuspendLayout();
            pnlBarraTItulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(30, 30, 30);
            pnlMenu.Controls.Add(btnGestionRoles);
            pnlMenu.Controls.Add(btnConfig);
            pnlMenu.Controls.Add(btnMedicos);
            pnlMenu.Controls.Add(btnPacientes);
            pnlMenu.Controls.Add(btnTurnos);
            pnlMenu.Controls.Add(btnInicio);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 650);
            pnlMenu.TabIndex = 1;
            // 
            // pnlLogo
            // 
            pnlLogo.BorderStyle = BorderStyle.Fixed3D;
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(230, 60);
            pnlLogo.TabIndex = 7;
            // 
            // btnGestionRoles
            // 
            btnGestionRoles.Dock = DockStyle.Top;
            btnGestionRoles.FlatAppearance.BorderSize = 0;
            btnGestionRoles.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnGestionRoles.FlatStyle = FlatStyle.Flat;
            btnGestionRoles.Font = new Font("Segoe UI", 11.25F);
            btnGestionRoles.ForeColor = Color.White;
            btnGestionRoles.Location = new Point(0, 360);
            btnGestionRoles.Name = "btnGestionRoles";
            btnGestionRoles.Padding = new Padding(15, 0, 0, 0);
            btnGestionRoles.Size = new Size(230, 60);
            btnGestionRoles.TabIndex = 9;
            btnGestionRoles.Text = "🛡️  Gestion de Roles";
            btnGestionRoles.TextAlign = ContentAlignment.MiddleLeft;
            btnGestionRoles.UseVisualStyleBackColor = true;
            btnGestionRoles.Click += btnGestionRoles_Click;
            // 
            // btnConfig
            // 
            btnConfig.Dock = DockStyle.Top;
            btnConfig.FlatAppearance.BorderSize = 0;
            btnConfig.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnConfig.FlatStyle = FlatStyle.Flat;
            btnConfig.Font = new Font("Segoe UI", 11.25F);
            btnConfig.ForeColor = Color.White;
            btnConfig.Location = new Point(0, 300);
            btnConfig.Name = "btnConfig";
            btnConfig.Padding = new Padding(15, 0, 0, 0);
            btnConfig.Size = new Size(230, 60);
            btnConfig.TabIndex = 5;
            btnConfig.Text = "⚙️  Configuración";
            btnConfig.TextAlign = ContentAlignment.MiddleLeft;
            btnConfig.UseVisualStyleBackColor = true;
            // 
            // btnMedicos
            // 
            btnMedicos.Dock = DockStyle.Top;
            btnMedicos.FlatAppearance.BorderSize = 0;
            btnMedicos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnMedicos.FlatStyle = FlatStyle.Flat;
            btnMedicos.Font = new Font("Segoe UI", 11.25F);
            btnMedicos.ForeColor = Color.White;
            btnMedicos.Location = new Point(0, 240);
            btnMedicos.Name = "btnMedicos";
            btnMedicos.Padding = new Padding(15, 0, 0, 0);
            btnMedicos.Size = new Size(230, 60);
            btnMedicos.TabIndex = 4;
            btnMedicos.Text = "\U0001fa7a  Cuerpo Médico";
            btnMedicos.TextAlign = ContentAlignment.MiddleLeft;
            btnMedicos.UseVisualStyleBackColor = true;
            // 
            // btnPacientes
            // 
            btnPacientes.Dock = DockStyle.Top;
            btnPacientes.FlatAppearance.BorderSize = 0;
            btnPacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 11.25F);
            btnPacientes.ForeColor = Color.White;
            btnPacientes.Location = new Point(0, 180);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Padding = new Padding(15, 0, 0, 0);
            btnPacientes.Size = new Size(230, 60);
            btnPacientes.TabIndex = 3;
            btnPacientes.Text = "👤  Gestión de Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientes.UseVisualStyleBackColor = true;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // btnTurnos
            // 
            btnTurnos.Dock = DockStyle.Top;
            btnTurnos.FlatAppearance.BorderSize = 0;
            btnTurnos.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnTurnos.FlatStyle = FlatStyle.Flat;
            btnTurnos.Font = new Font("Segoe UI", 11.25F);
            btnTurnos.ForeColor = Color.White;
            btnTurnos.Location = new Point(0, 120);
            btnTurnos.Name = "btnTurnos";
            btnTurnos.Padding = new Padding(15, 0, 0, 0);
            btnTurnos.Size = new Size(230, 60);
            btnTurnos.TabIndex = 2;
            btnTurnos.Text = "📅  Agenda de Turnos";
            btnTurnos.TextAlign = ContentAlignment.MiddleLeft;
            btnTurnos.UseVisualStyleBackColor = true;
            btnTurnos.Click += btnTurnos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 11.25F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Location = new Point(0, 60);
            btnInicio.Name = "btnInicio";
            btnInicio.Padding = new Padding(15, 0, 0, 0);
            btnInicio.Size = new Size(230, 60);
            btnInicio.TabIndex = 8;
            btnInicio.Text = "🏠  INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 590);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(15, 0, 0, 0);
            btnCerrarSesion.Size = new Size(230, 60);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "➔  Cerrar Sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = Color.WhiteSmoke;
            pnlContenedor.Controls.Add(lblDetalleCuerpo);
            pnlContenedor.Controls.Add(lblBienvenida);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(230, 60);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(870, 590);
            pnlContenedor.TabIndex = 2;
            // 
            // lblDetalleCuerpo
            // 
            lblDetalleCuerpo.AutoSize = true;
            lblDetalleCuerpo.Location = new Point(321, 524);
            lblDetalleCuerpo.Name = "lblDetalleCuerpo";
            lblDetalleCuerpo.Size = new Size(48, 15);
            lblDetalleCuerpo.TabIndex = 2;
            lblDetalleCuerpo.Text = "Detalles";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Roboto Bk", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(321, 428);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(186, 23);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenidos a todos";
            // 
            // pnlBarraTItulo
            // 
            pnlBarraTItulo.BackColor = Color.FromArgb(0, 122, 204);
            pnlBarraTItulo.Controls.Add(btnCerrar);
            pnlBarraTItulo.Controls.Add(lblUsuario);
            pnlBarraTItulo.Controls.Add(lblModulo);
            pnlBarraTItulo.Dock = DockStyle.Top;
            pnlBarraTItulo.ForeColor = Color.FromArgb(31, 41, 55);
            pnlBarraTItulo.Location = new Point(230, 0);
            pnlBarraTItulo.Name = "pnlBarraTItulo";
            pnlBarraTItulo.Size = new Size(870, 60);
            pnlBarraTItulo.TabIndex = 3;
            pnlBarraTItulo.MouseDown += pnlBarraTItulo_MouseDown;
            pnlBarraTItulo.MouseMove += pnlBarraTItulo_MouseMove;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(232, 17, 35);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(830, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 35);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(650, 22);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(117, 17);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario: [Nombre]";
            lblUsuario.MouseDown += lblUsuario_MouseDown;
            lblUsuario.MouseMove += lblUsuario_MouseMove;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblModulo.ForeColor = Color.White;
            lblModulo.Location = new Point(20, 18);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(71, 25);
            lblModulo.TabIndex = 0;
            lblModulo.Text = "INICIO";
            lblModulo.MouseDown += lblModulo_MouseDown;
            lblModulo.MouseMove += lblModulo_MouseMove;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1100, 650);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlBarraTItulo);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Gestion Clinica";
            FormClosing += FrmPrincipal_FormClosing;
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            pnlContenedor.PerformLayout();
            pnlBarraTItulo.ResumeLayout(false);
            pnlBarraTItulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Panel pnlContenedor;
        private Panel pnlBarraTItulo;
        private Button btnCerrar;
        private Label lblUsuario;
        private Label lblModulo;
        private Button btnCerrarSesion;
        private Button btnConfig;
        private Button btnMedicos;
        private Button btnPacientes;
        private Button btnTurnos;
        private Panel pnlLogo;
        private Label lblBienvenida;
        private Label lblDetalleCuerpo;
        private Button btnInicio;
        private Button btnGestionRoles;
    }
}
