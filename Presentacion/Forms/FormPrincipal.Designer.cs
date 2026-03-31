namespace Presentacion
{
    partial class FormPrincipal
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
            btnProbarConexion = new Button();
            SuspendLayout();
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.Location = new Point(160, 143);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(133, 36);
            btnProbarConexion.TabIndex = 0;
            btnProbarConexion.Text = "Probar Conexion";
            btnProbarConexion.UseVisualStyleBackColor = true;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProbarConexion);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProbarConexion;
    }
}
