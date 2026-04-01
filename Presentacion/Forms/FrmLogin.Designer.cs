namespace Presentacion.Forms
{
    partial class FrmLogin
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
            pnlLateral = new Panel();
            lblTitulo = new Label();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnCerrar = new Button();
            lblUser = new Label();
            lblPass = new Label();
            SuspendLayout();
            // 
            // pnlLateral
            // 
            pnlLateral.BackColor = Color.FromArgb(0, 122, 204);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(120, 500);
            pnlLateral.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(144, 69);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(233, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "LOGIN DE SISTEMA";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(45, 45, 48);
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(144, 187);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(230, 29);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.FromArgb(45, 45, 48);
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.ForeColor = Color.White;
            txtPass.Location = new Point(144, 293);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(230, 29);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(285, 425);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(89, 39);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "ACCEDER";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.Gray;
            btnCerrar.Location = new Point(347, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(30, 30);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.DarkGray;
            lblUser.Location = new Point(144, 155);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(61, 15);
            lblUser.TabIndex = 6;
            lblUser.Text = "USUARIO";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.ForeColor = Color.DarkGray;
            lblPass.Location = new Point(144, 265);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(85, 15);
            lblPass.TabIndex = 7;
            lblPass.Text = "CONTRASEÑA";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(400, 500);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(btnCerrar);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(lblTitulo);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            MouseDown += FrmLogin_MouseDown;
            MouseMove += FrmLogin_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlLateral;
        private Label lblTitulo;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnCerrar;
        private Label lblUser;
        private Label lblPass;
    }
}