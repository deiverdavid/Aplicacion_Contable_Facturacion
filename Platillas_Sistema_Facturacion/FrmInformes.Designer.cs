namespace Platillas_Sistema_Facturacion
{
    partial class FrmInformes
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
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btngenerarinforme = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlinformacion = new System.Windows.Forms.Panel();
            this.rdbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbPdf = new MaterialSkin.Controls.MaterialRadioButton();
            this.rdbPantalla = new MaterialSkin.Controls.MaterialRadioButton();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpIncio = new System.Windows.Forms.DateTimePicker();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pnlinformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(534, 396);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(225, 45);
            this.btnsalir.TabIndex = 27;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btngenerarinforme
            // 
            this.btngenerarinforme.Depth = 0;
            this.btngenerarinforme.Location = new System.Drawing.Point(194, 396);
            this.btngenerarinforme.MouseState = MaterialSkin.MouseState.HOVER;
            this.btngenerarinforme.Name = "btngenerarinforme";
            this.btngenerarinforme.Primary = true;
            this.btngenerarinforme.Size = new System.Drawing.Size(225, 45);
            this.btngenerarinforme.TabIndex = 26;
            this.btngenerarinforme.Text = "generar informe";
            this.btngenerarinforme.UseVisualStyleBackColor = true;
            // 
            // pnlinformacion
            // 
            this.pnlinformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlinformacion.Controls.Add(this.rdbExcel);
            this.pnlinformacion.Controls.Add(this.rdbPdf);
            this.pnlinformacion.Controls.Add(this.rdbPantalla);
            this.pnlinformacion.Controls.Add(this.dtpfinal);
            this.pnlinformacion.Controls.Add(this.comboBox3);
            this.pnlinformacion.Controls.Add(this.label3);
            this.pnlinformacion.Controls.Add(this.label2);
            this.pnlinformacion.Controls.Add(this.label1);
            this.pnlinformacion.Controls.Add(this.cboCliente);
            this.pnlinformacion.Controls.Add(this.dtpIncio);
            this.pnlinformacion.Controls.Add(this.lblcategoria);
            this.pnlinformacion.Location = new System.Drawing.Point(50, 103);
            this.pnlinformacion.Name = "pnlinformacion";
            this.pnlinformacion.Size = new System.Drawing.Size(888, 230);
            this.pnlinformacion.TabIndex = 24;
            // 
            // rdbExcel
            // 
            this.rdbExcel.AutoSize = true;
            this.rdbExcel.Depth = 0;
            this.rdbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbExcel.Location = new System.Drawing.Point(553, 176);
            this.rdbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.rdbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbExcel.Name = "rdbExcel";
            this.rdbExcel.Ripple = true;
            this.rdbExcel.Size = new System.Drawing.Size(71, 30);
            this.rdbExcel.TabIndex = 32;
            this.rdbExcel.TabStop = true;
            this.rdbExcel.Text = "Excel";
            this.rdbExcel.UseVisualStyleBackColor = true;
            // 
            // rdbPdf
            // 
            this.rdbPdf.AutoSize = true;
            this.rdbPdf.Depth = 0;
            this.rdbPdf.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPdf.Location = new System.Drawing.Point(387, 176);
            this.rdbPdf.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPdf.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPdf.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPdf.Name = "rdbPdf";
            this.rdbPdf.Ripple = true;
            this.rdbPdf.Size = new System.Drawing.Size(57, 30);
            this.rdbPdf.TabIndex = 31;
            this.rdbPdf.TabStop = true;
            this.rdbPdf.Text = "Pdf";
            this.rdbPdf.UseVisualStyleBackColor = true;
            // 
            // rdbPantalla
            // 
            this.rdbPantalla.AutoSize = true;
            this.rdbPantalla.Depth = 0;
            this.rdbPantalla.Font = new System.Drawing.Font("Roboto", 10F);
            this.rdbPantalla.Location = new System.Drawing.Point(219, 176);
            this.rdbPantalla.Margin = new System.Windows.Forms.Padding(0);
            this.rdbPantalla.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdbPantalla.MouseState = MaterialSkin.MouseState.HOVER;
            this.rdbPantalla.Name = "rdbPantalla";
            this.rdbPantalla.Ripple = true;
            this.rdbPantalla.Size = new System.Drawing.Size(115, 30);
            this.rdbPantalla.TabIndex = 30;
            this.rdbPantalla.TabStop = true;
            this.rdbPantalla.Text = "En pantalla";
            this.rdbPantalla.UseVisualStyleBackColor = true;
            // 
            // dtpfinal
            // 
            this.dtpfinal.Location = new System.Drawing.Point(553, 110);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(200, 22);
            this.dtpfinal.TabIndex = 29;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(623, 32);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 24);
            this.comboBox3.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(427, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fecha Final";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Inicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "SELECCIONE INFORME";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(251, 26);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(193, 24);
            this.cboCliente.TabIndex = 12;
            // 
            // dtpIncio
            // 
            this.dtpIncio.Location = new System.Drawing.Point(134, 112);
            this.dtpIncio.Name = "dtpIncio";
            this.dtpIncio.Size = new System.Drawing.Size(200, 22);
            this.dtpIncio.TabIndex = 11;
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoria.Location = new System.Drawing.Point(502, 32);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(104, 20);
            this.lblcategoria.TabIndex = 5;
            this.lblcategoria.Text = "Ordenar por:";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(201, 28);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(591, 29);
            this.lbltitulo.TabIndex = 23;
            this.lbltitulo.Text = "GENERADOR DE INFORMES DE FACTURACIÓN";
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 590);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngenerarinforme);
            this.Controls.Add(this.pnlinformacion);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInformes";
            this.Text = "FrmInformes";
            this.pnlinformacion.ResumeLayout(false);
            this.pnlinformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private MaterialSkin.Controls.MaterialRaisedButton btngenerarinforme;
        private System.Windows.Forms.Panel pnlinformacion;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DateTimePicker dtpIncio;
        private System.Windows.Forms.Label lblcategoria;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private MaterialSkin.Controls.MaterialRadioButton rdbPantalla;
        private MaterialSkin.Controls.MaterialRadioButton rdbExcel;
        private MaterialSkin.Controls.MaterialRadioButton rdbPdf;
    }
}