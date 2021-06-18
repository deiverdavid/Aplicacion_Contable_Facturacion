namespace Platillas_Sistema_Facturacion
{
    partial class FrmSeguridad
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
            this.components = new System.ComponentModel.Container();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnconsultar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtclave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(749, 278);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Primary = true;
            this.btneliminar.Size = new System.Drawing.Size(225, 45);
            this.btneliminar.TabIndex = 32;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(749, 203);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(225, 45);
            this.btnactualizar.TabIndex = 31;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Depth = 0;
            this.btnconsultar.Location = new System.Drawing.Point(749, 134);
            this.btnconsultar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Primary = true;
            this.btnconsultar.Size = new System.Drawing.Size(225, 45);
            this.btnconsultar.TabIndex = 30;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // pnlinformacion
            // 
            this.pnlinformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinformacion.Controls.Add(this.label1);
            this.pnlinformacion.Controls.Add(this.txtclave);
            this.pnlinformacion.Controls.Add(this.txtusuario);
            this.pnlinformacion.Controls.Add(this.cboEmpleado);
            this.pnlinformacion.Location = new System.Drawing.Point(31, 113);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(695, 354);
            this.pnlinformacion.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Empleado";
            // 
            // txtclave
            // 
            this.txtclave.Depth = 0;
            this.txtclave.Hint = "Clave";
            this.txtclave.Location = new System.Drawing.Point(58, 182);
            this.txtclave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtclave.Name = "txtclave";
            this.txtclave.PasswordChar = '\0';
            this.txtclave.SelectedText = "";
            this.txtclave.SelectionLength = 0;
            this.txtclave.SelectionStart = 0;
            this.txtclave.Size = new System.Drawing.Size(155, 28);
            this.txtclave.TabIndex = 19;
            this.txtclave.UseSystemPasswordChar = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.Hint = "Usuario";
            this.txtusuario.Location = new System.Drawing.Point(58, 119);
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(155, 28);
            this.txtusuario.TabIndex = 18;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(170, 48);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(200, 24);
            this.cboEmpleado.TabIndex = 17;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(175, 24);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(588, 29);
            this.lbltitulo.TabIndex = 28;
            this.lbltitulo.Text = "ADMINISTRACIÓN DE USUARIOS DEL SISTEMA";
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(818, 473);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(156, 45);
            this.btnsalir.TabIndex = 33;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.pnlinformacion);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmSeguridad";
            this.Text = "FrmSeguridad";
            this.Load += new System.EventHandler(this.FrmSeguridad_Load);
            this.pnlinformacion.ResumeLayout(false);
            this.pnlinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnconsultar;
        private System.Windows.Forms.Panel pnlinformacion;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtclave;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label lbltitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}