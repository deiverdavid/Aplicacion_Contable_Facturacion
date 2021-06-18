namespace Platillas_Sistema_Facturacion
{
    partial class FrmEmpleados
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
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlbusquedad = new System.Windows.Forms.Panel();
            this.btnbuscar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtBuscar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgvempleados = new System.Windows.Forms.DataGridView();
            this.btneliminar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnnuevo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.IdEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdatosadicionales = new System.Windows.Forms.TextBox();
            this.dtpRetiro = new System.Windows.Forms.DateTimePicker();
            this.lblretiro = new System.Windows.Forms.Label();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txttelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtdocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombreEmpleado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cboRolEmpleado = new System.Windows.Forms.ComboBox();
            this.lblrol = new System.Windows.Forms.Label();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblingreso = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.MensajeError = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlbusquedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).BeginInit();
            this.pnlinformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(867, 484);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(100, 45);
            this.btnsalir.TabIndex = 29;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pnlbusquedad
            // 
            this.pnlbusquedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlbusquedad.Controls.Add(this.btnbuscar);
            this.pnlbusquedad.Controls.Add(this.txtBuscar);
            this.pnlbusquedad.Controls.Add(this.dgvempleados);
            this.pnlbusquedad.Location = new System.Drawing.Point(22, 362);
            this.pnlbusquedad.Name = "pnlbusquedad";
            this.pnlbusquedad.Size = new System.Drawing.Size(695, 178);
            this.pnlbusquedad.TabIndex = 28;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Depth = 0;
            this.btnbuscar.Location = new System.Drawing.Point(542, 3);
            this.btnbuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Primary = true;
            this.btnbuscar.Size = new System.Drawing.Size(116, 28);
            this.btnbuscar.TabIndex = 30;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Depth = 0;
            this.txtBuscar.Hint = "Buscar Empleado";
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
            // dgvempleados
            // 
            this.dgvempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleados.Location = new System.Drawing.Point(17, 37);
            this.dgvempleados.Name = "dgvempleados";
            this.dgvempleados.RowHeadersWidth = 51;
            this.dgvempleados.RowTemplate.Height = 24;
            this.dgvempleados.Size = new System.Drawing.Size(664, 136);
            this.dgvempleados.TabIndex = 8;
            this.dgvempleados.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvempleados_CellMouseClick);
            // 
            // btneliminar
            // 
            this.btneliminar.Depth = 0;
            this.btneliminar.Location = new System.Drawing.Point(738, 257);
            this.btneliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Primary = true;
            this.btneliminar.Size = new System.Drawing.Size(225, 45);
            this.btneliminar.TabIndex = 27;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(738, 182);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(225, 45);
            this.btnactualizar.TabIndex = 26;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Depth = 0;
            this.btnnuevo.Location = new System.Drawing.Point(738, 113);
            this.btnnuevo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Primary = true;
            this.btnnuevo.Size = new System.Drawing.Size(225, 45);
            this.btnnuevo.TabIndex = 25;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // pnlinformacion
            // 
            this.pnlinformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinformacion.Controls.Add(this.IdEmpleado);
            this.pnlinformacion.Controls.Add(this.label2);
            this.pnlinformacion.Controls.Add(this.txtdatosadicionales);
            this.pnlinformacion.Controls.Add(this.dtpRetiro);
            this.pnlinformacion.Controls.Add(this.lblretiro);
            this.pnlinformacion.Controls.Add(this.txtemail);
            this.pnlinformacion.Controls.Add(this.txttelefono);
            this.pnlinformacion.Controls.Add(this.txtdireccion);
            this.pnlinformacion.Controls.Add(this.txtdocumento);
            this.pnlinformacion.Controls.Add(this.txtnombreEmpleado);
            this.pnlinformacion.Controls.Add(this.cboRolEmpleado);
            this.pnlinformacion.Controls.Add(this.lblrol);
            this.pnlinformacion.Controls.Add(this.dtpIngreso);
            this.pnlinformacion.Controls.Add(this.lblingreso);
            this.pnlinformacion.Location = new System.Drawing.Point(22, 35);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(695, 321);
            this.pnlinformacion.TabIndex = 24;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.Location = new System.Drawing.Point(17, 3);
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.Size = new System.Drawing.Size(38, 22);
            this.IdEmpleado.TabIndex = 27;
            this.IdEmpleado.Text = "0";
            this.IdEmpleado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Datos Adicionales";
            // 
            // txtdatosadicionales
            // 
            this.txtdatosadicionales.Location = new System.Drawing.Point(397, 232);
            this.txtdatosadicionales.Multiline = true;
            this.txtdatosadicionales.Name = "txtdatosadicionales";
            this.txtdatosadicionales.Size = new System.Drawing.Size(284, 72);
            this.txtdatosadicionales.TabIndex = 25;
            // 
            // dtpRetiro
            // 
            this.dtpRetiro.Location = new System.Drawing.Point(458, 169);
            this.dtpRetiro.Name = "dtpRetiro";
            this.dtpRetiro.Size = new System.Drawing.Size(200, 22);
            this.dtpRetiro.TabIndex = 24;
            // 
            // lblretiro
            // 
            this.lblretiro.AutoSize = true;
            this.lblretiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblretiro.Location = new System.Drawing.Point(454, 146);
            this.lblretiro.Name = "lblretiro";
            this.lblretiro.Size = new System.Drawing.Size(105, 20);
            this.lblretiro.TabIndex = 23;
            this.lblretiro.Text = "Fecha Retiro";
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "Email";
            this.txtemail.Location = new System.Drawing.Point(17, 269);
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(301, 28);
            this.txtemail.TabIndex = 22;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txttelefono
            // 
            this.txttelefono.Depth = 0;
            this.txttelefono.Hint = "Teléfono";
            this.txttelefono.Location = new System.Drawing.Point(17, 215);
            this.txttelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.SelectedText = "";
            this.txttelefono.SelectionLength = 0;
            this.txttelefono.SelectionStart = 0;
            this.txttelefono.Size = new System.Drawing.Size(301, 28);
            this.txttelefono.TabIndex = 21;
            this.txttelefono.UseSystemPasswordChar = false;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "Dirección";
            this.txtdireccion.Location = new System.Drawing.Point(17, 155);
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(301, 28);
            this.txtdireccion.TabIndex = 20;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Depth = 0;
            this.txtdocumento.Hint = "Documento";
            this.txtdocumento.Location = new System.Drawing.Point(17, 94);
            this.txtdocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.PasswordChar = '\0';
            this.txtdocumento.SelectedText = "";
            this.txtdocumento.SelectionLength = 0;
            this.txtdocumento.SelectionStart = 0;
            this.txtdocumento.Size = new System.Drawing.Size(301, 28);
            this.txtdocumento.TabIndex = 19;
            this.txtdocumento.UseSystemPasswordChar = false;
            // 
            // txtnombreEmpleado
            // 
            this.txtnombreEmpleado.Depth = 0;
            this.txtnombreEmpleado.Hint = "Nombre Empleado";
            this.txtnombreEmpleado.Location = new System.Drawing.Point(17, 31);
            this.txtnombreEmpleado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombreEmpleado.Name = "txtnombreEmpleado";
            this.txtnombreEmpleado.PasswordChar = '\0';
            this.txtnombreEmpleado.SelectedText = "";
            this.txtnombreEmpleado.SelectionLength = 0;
            this.txtnombreEmpleado.SelectionStart = 0;
            this.txtnombreEmpleado.Size = new System.Drawing.Size(301, 28);
            this.txtnombreEmpleado.TabIndex = 18;
            this.txtnombreEmpleado.UseSystemPasswordChar = false;
            // 
            // cboRolEmpleado
            // 
            this.cboRolEmpleado.FormattingEnabled = true;
            this.cboRolEmpleado.Location = new System.Drawing.Point(458, 37);
            this.cboRolEmpleado.Name = "cboRolEmpleado";
            this.cboRolEmpleado.Size = new System.Drawing.Size(200, 24);
            this.cboRolEmpleado.TabIndex = 17;
            // 
            // lblrol
            // 
            this.lblrol.AutoSize = true;
            this.lblrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrol.Location = new System.Drawing.Point(454, 14);
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(113, 20);
            this.lblrol.TabIndex = 16;
            this.lblrol.Text = "Rol Empleado";
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Location = new System.Drawing.Point(458, 100);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(200, 22);
            this.dtpIngreso.TabIndex = 11;
            // 
            // lblingreso
            // 
            this.lblingreso.AutoSize = true;
            this.lblingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingreso.Location = new System.Drawing.Point(454, 77);
            this.lblingreso.Name = "lblingreso";
            this.lblingreso.Size = new System.Drawing.Size(115, 20);
            this.lblingreso.TabIndex = 5;
            this.lblingreso.Text = "Fecha Ingreso";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(249, 3);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(439, 29);
            this.lbltitulo.TabIndex = 23;
            this.lbltitulo.Text = "ADMINISTRACIÓN DE EMPLEADOS";
            // 
            // MensajeError
            // 
            this.MensajeError.ContainerControl = this;
            // 
            // FrmEmpleados
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
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            this.pnlbusquedad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleados)).EndInit();
            this.pnlinformacion.ResumeLayout(false);
            this.pnlinformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MensajeError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private System.Windows.Forms.Panel pnlbusquedad;
        private System.Windows.Forms.DataGridView dgvempleados;
        private MaterialSkin.Controls.MaterialRaisedButton btneliminar;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialRaisedButton btnnuevo;
        private System.Windows.Forms.Panel pnlinformacion;
        private System.Windows.Forms.ComboBox cboRolEmpleado;
        private System.Windows.Forms.Label lblrol;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.Label lblingreso;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdatosadicionales;
        private System.Windows.Forms.DateTimePicker dtpRetiro;
        private System.Windows.Forms.Label lblretiro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombreEmpleado;
        private MaterialSkin.Controls.MaterialRaisedButton btnbuscar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscar;
        private System.Windows.Forms.TextBox IdEmpleado;
        private System.Windows.Forms.ErrorProvider MensajeError;
    }
}