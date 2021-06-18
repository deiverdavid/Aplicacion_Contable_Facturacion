namespace Platillas_Sistema_Facturacion
{
    partial class Frmlogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblinformacion = new System.Windows.Forms.Label();
            this.pnliniciosesion = new System.Windows.Forms.Panel();
            this.btncancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btncontinuar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtcontraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pnlFondo.SuspendLayout();
            this.pnliniciosesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(210)))), ((int)(((byte)(202)))));
            this.pnlFondo.Controls.Add(this.lblinformacion);
            this.pnlFondo.Controls.Add(this.pnliniciosesion);
            this.pnlFondo.Controls.Add(this.piclogo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1000, 570);
            this.pnlFondo.TabIndex = 0;
            // 
            // lblinformacion
            // 
            this.lblinformacion.AutoSize = true;
            this.lblinformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblinformacion.Location = new System.Drawing.Point(65, 329);
            this.lblinformacion.Name = "lblinformacion";
            this.lblinformacion.Size = new System.Drawing.Size(341, 29);
            this.lblinformacion.TabIndex = 2;
            this.lblinformacion.Text = "Inicia sesión o crea una cuenta";
            // 
            // pnliniciosesion
            // 
            this.pnliniciosesion.BackColor = System.Drawing.Color.Teal;
            this.pnliniciosesion.Controls.Add(this.btncancelar);
            this.pnliniciosesion.Controls.Add(this.btncontinuar);
            this.pnliniciosesion.Controls.Add(this.txtcontraseña);
            this.pnliniciosesion.Controls.Add(this.txtusuario);
            this.pnliniciosesion.Controls.Add(this.lbltitulo);
            this.pnliniciosesion.Location = new System.Drawing.Point(511, 26);
            this.pnliniciosesion.Name = "pnliniciosesion";
            this.pnliniciosesion.Size = new System.Drawing.Size(454, 516);
            this.pnliniciosesion.TabIndex = 1;
            // 
            // btncancelar
            // 
            this.btncancelar.Depth = 0;
            this.btncancelar.Location = new System.Drawing.Point(50, 403);
            this.btncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Primary = true;
            this.btncancelar.Size = new System.Drawing.Size(165, 40);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btncontinuar
            // 
            this.btncontinuar.Depth = 0;
            this.btncontinuar.Location = new System.Drawing.Point(235, 403);
            this.btncontinuar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Primary = true;
            this.btncontinuar.Size = new System.Drawing.Size(165, 40);
            this.btncontinuar.TabIndex = 4;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Depth = 0;
            this.txtcontraseña.Hint = "Ingrese su contraseña";
            this.txtcontraseña.Location = new System.Drawing.Point(59, 243);
            this.txtcontraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.SelectedText = "";
            this.txtcontraseña.SelectionLength = 0;
            this.txtcontraseña.SelectionStart = 0;
            this.txtcontraseña.Size = new System.Drawing.Size(326, 28);
            this.txtcontraseña.TabIndex = 3;
            this.txtcontraseña.UseSystemPasswordChar = false;
            this.txtcontraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcontraseña_KeyPress);
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtusuario.Hint = "Ingrese su usuario";
            this.txtusuario.Location = new System.Drawing.Point(59, 147);
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(326, 28);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(52, 40);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(241, 38);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Inicio de sesión";
            // 
            // piclogo
            // 
            this.piclogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.piclogo.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.Logo256;
            this.piclogo.InitialImage = null;
            this.piclogo.Location = new System.Drawing.Point(107, 66);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(256, 256);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            // 
            // Frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 570);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmlogin";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.pnliniciosesion.ResumeLayout(false);
            this.pnliniciosesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnliniciosesion;
        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label lblinformacion;
        private System.Windows.Forms.Label lbltitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontraseña;
        private MaterialSkin.Controls.MaterialRaisedButton btncancelar;
        private MaterialSkin.Controls.MaterialRaisedButton btncontinuar;
    }
}

