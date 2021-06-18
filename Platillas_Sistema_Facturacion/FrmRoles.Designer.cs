namespace Platillas_Sistema_Facturacion
{
    partial class FrmRoles
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
            this.pnlbusquedad = new System.Windows.Forms.Panel();
            this.btnbuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvrol = new System.Windows.Forms.DataGridView();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.txtdescripcionrol = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtnombrerol = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlbusquedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).BeginInit();
            this.pnlinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlbusquedad
            // 
            this.pnlbusquedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbusquedad.Controls.Add(this.btnbuscar);
            this.pnlbusquedad.Controls.Add(this.txtBuscar);
            this.pnlbusquedad.Controls.Add(this.dgvrol);
            this.pnlbusquedad.Location = new System.Drawing.Point(24, 294);
            this.pnlbusquedad.Name = "pnlbusquedad";
            this.pnlbusquedad.Size = new System.Drawing.Size(695, 246);
            this.pnlbusquedad.TabIndex = 34;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Depth = 0;
            this.btnbuscar.Location = new System.Drawing.Point(549, 3);
            this.btnbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Primary = true;
            this.btnbuscar.Size = new System.Drawing.Size(116, 41);
            this.btnbuscar.TabIndex = 30;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar Roles";
            this.txtBuscar.Location = new System.Drawing.Point(34, 3);
            this.txtBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.Size = new System.Drawing.Size(301, 28);
            this.txtBuscar.TabIndex = 27;
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // dgvrol
            // 
            this.dgvrol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrol.Location = new System.Drawing.Point(34, 50);
            this.dgvrol.Name = "dgvrol";
            this.dgvrol.RowHeadersWidth = 51;
            this.dgvrol.RowTemplate.Height = 24;
            this.dgvrol.Size = new System.Drawing.Size(349, 171);
            this.dgvrol.TabIndex = 8;
            this.dgvrol.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvrol_CellMouseClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(741, 211);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Primary = true;
            this.btneliminar.Size = new System.Drawing.Size(225, 45);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(741, 136);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(225, 45);
            this.btnactualizar.TabIndex = 32;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Depth = 0;
            this.btnnuevo.Location = new System.Drawing.Point(741, 67);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Primary = true;
            this.btnnuevo.Size = new System.Drawing.Size(225, 45);
            this.btnnuevo.TabIndex = 31;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // pnlinformacion
            // 
            this.pnlinformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinformacion.Controls.Add(this.txtdescripcionrol);
            this.pnlinformacion.Controls.Add(this.lblDescripcion);
            this.pnlinformacion.Controls.Add(this.txtnombrerol);
            this.pnlinformacion.Location = new System.Drawing.Point(24, 35);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(695, 253);
            this.pnlinformacion.TabIndex = 30;
            // 
            // txtdescripcionrol
            // 
            this.txtdescripcionrol.Location = new System.Drawing.Point(37, 125);
            this.txtdescripcionrol.Multiline = true;
            this.txtdescripcionrol.Name = "txtdescripcionrol";
            this.txtdescripcionrol.Size = new System.Drawing.Size(598, 89);
            this.txtdescripcionrol.TabIndex = 20;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(34, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(171, 17);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripción Detallada Rol";
            // 
            // txtnombrerol
            // 
            this.txtnombrerol.Depth = 0;
            this.txtnombrerol.Hint = "Id Rol ";
            this.txtnombrerol.Location = new System.Drawing.Point(34, 31);
            this.txtnombrerol.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombrerol.Name = "txtnombrerol";
            this.txtnombrerol.PasswordChar = '\0';
            this.txtnombrerol.SelectedText = "";
            this.txtnombrerol.SelectionLength = 0;
            this.txtnombrerol.SelectionStart = 0;
            this.txtnombrerol.Size = new System.Drawing.Size(301, 28);
            this.txtnombrerol.TabIndex = 18;
            this.txtnombrerol.UseSystemPasswordChar = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(339, 3);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(271, 29);
            this.lbltitulo.TabIndex = 29;
            this.lbltitulo.Text = "ROL DE EMPLEADOS";
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(850, 490);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(116, 41);
            this.btnsalir.TabIndex = 31;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 543);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.pnlbusquedad);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.pnlinformacion);
            this.Controls.Add(this.lbltitulo);
            this.Name = "FrmRoles";
            this.Text = "FrmRoles";
            this.Load += new System.EventHandler(this.FrmRoles_Load);
            this.pnlbusquedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrol)).EndInit();
            this.pnlinformacion.ResumeLayout(false);
            this.pnlinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlbusquedad;
        private MaterialSkin.Controls.MaterialRaisedButton btnbuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.DataGridView dgvrol;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnnuevo;
        private System.Windows.Forms.Panel pnlinformacion;
        private System.Windows.Forms.TextBox txtdescripcionrol;
        private System.Windows.Forms.Label lblDescripcion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombrerol;
        private System.Windows.Forms.Label lbltitulo;
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}