﻿namespace PlataformaGruposInvestigacion
{
    partial class interfazPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.butServicios = new System.Windows.Forms.Button();
            this.butCantFrecuenciaArch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos Investigación Colombia";
            // 
            // butServicios
            // 
            this.butServicios.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butServicios.Location = new System.Drawing.Point(841, 441);
            this.butServicios.Name = "butServicios";
            this.butServicios.Size = new System.Drawing.Size(203, 47);
            this.butServicios.TabIndex = 2;
            this.butServicios.Text = "Servicios";
            this.butServicios.UseVisualStyleBackColor = true;
            this.butServicios.Click += new System.EventHandler(this.butServicios_Click);
            // 
            // butCantFrecuenciaArch
            // 
            this.butCantFrecuenciaArch.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCantFrecuenciaArch.Location = new System.Drawing.Point(841, 537);
            this.butCantFrecuenciaArch.Name = "butCantFrecuenciaArch";
            this.butCantFrecuenciaArch.Size = new System.Drawing.Size(203, 92);
            this.butCantFrecuenciaArch.TabIndex = 3;
            this.butCantFrecuenciaArch.Text = "Frecuencia archivos";
            this.butCantFrecuenciaArch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PlataformaGruposInvestigacion.Properties.Resources.google2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(854, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 170);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // interfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlataformaGruposInvestigacion.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1112, 756);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butCantFrecuenciaArch);
            this.Controls.Add(this.butServicios);
            this.Controls.Add(this.label1);
            this.Name = "interfazPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.interfazPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butServicios;
        private System.Windows.Forms.Button butCantFrecuenciaArch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
