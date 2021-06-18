namespace Platillas_Sistema_Facturacion
{
    partial class FrmAyuda
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
            this.picAyuda = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAyuda)).BeginInit();
            this.SuspendLayout();
            // 
            // picAyuda
            // 
            this.picAyuda.Image = global::Platillas_Sistema_Facturacion.Properties.Resources.imagAcercaDe1;
            this.picAyuda.Location = new System.Drawing.Point(99, 88);
            this.picAyuda.Name = "picAyuda";
            this.picAyuda.Size = new System.Drawing.Size(794, 322);
            this.picAyuda.TabIndex = 0;
            this.picAyuda.TabStop = false;
            // 
            // FrmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 543);
            this.Controls.Add(this.picAyuda);
            this.Name = "FrmAyuda";
            this.Text = "FrmAyuda";
            ((System.ComponentModel.ISupportInitialize)(this.picAyuda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAyuda;
    }
}