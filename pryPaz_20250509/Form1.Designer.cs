namespace pryPaz_20250509
{
    partial class FrmMain
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
            this.cmbParcial = new System.Windows.Forms.ComboBox();
            this.pctParcial = new System.Windows.Forms.PictureBox();
            this.lblEleccion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctParcial)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbParcial
            // 
            this.cmbParcial.BackColor = System.Drawing.Color.White;
            this.cmbParcial.FormattingEnabled = true;
            this.cmbParcial.Location = new System.Drawing.Point(67, 67);
            this.cmbParcial.Name = "cmbParcial";
            this.cmbParcial.Size = new System.Drawing.Size(261, 21);
            this.cmbParcial.TabIndex = 0;
            this.cmbParcial.SelectedIndexChanged += new System.EventHandler(this.cmbParcial_SelectedIndexChanged);
            // 
            // pctParcial
            // 
            this.pctParcial.Location = new System.Drawing.Point(67, 122);
            this.pctParcial.Name = "pctParcial";
            this.pctParcial.Size = new System.Drawing.Size(362, 220);
            this.pctParcial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctParcial.TabIndex = 1;
            this.pctParcial.TabStop = false;
            this.pctParcial.Click += new System.EventHandler(this.pctParcial_Click);
            // 
            // lblEleccion
            // 
            this.lblEleccion.AutoSize = true;
            this.lblEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEleccion.Location = new System.Drawing.Point(67, 34);
            this.lblEleccion.Name = "lblEleccion";
            this.lblEleccion.Size = new System.Drawing.Size(124, 13);
            this.lblEleccion.TabIndex = 2;
            this.lblEleccion.Text = "Seleccione un heroe";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(506, 400);
            this.Controls.Add(this.lblEleccion);
            this.Controls.Add(this.pctParcial);
            this.Controls.Add(this.cmbParcial);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctParcial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParcial;
        private System.Windows.Forms.PictureBox pctParcial;
        private System.Windows.Forms.Label lblEleccion;
    }
}

