using System;

namespace PlataformaGruposInvestigacion
{
    partial class ventReportes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCiudades = new System.Windows.Forms.Button();
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnRegiones = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnClasificacion = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            this.grafico1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.grafico1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico1.Legends.Add(legend1);
            this.grafico1.Location = new System.Drawing.Point(21, 21);
            this.grafico1.Margin = new System.Windows.Forms.Padding(1);
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(414, 315);
            this.grafico1.TabIndex = 1;
            this.grafico1.Text = "chart1";
            // 
            // btnCiudades
            // 
            this.btnCiudades.Location = new System.Drawing.Point(466, 21);
            this.btnCiudades.Margin = new System.Windows.Forms.Padding(1);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(103, 40);
            this.btnCiudades.TabIndex = 2;
            this.btnCiudades.Text = "Reporte Ciudades";
            this.btnCiudades.UseVisualStyleBackColor = true;
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(466, 88);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(1);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(103, 40);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "Reporte Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnRegiones
            // 
            this.btnRegiones.Location = new System.Drawing.Point(466, 155);
            this.btnRegiones.Margin = new System.Windows.Forms.Padding(1);
            this.btnRegiones.Name = "btnRegiones";
            this.btnRegiones.Size = new System.Drawing.Size(103, 40);
            this.btnRegiones.TabIndex = 4;
            this.btnRegiones.Text = "Reporte Regiones";
            this.btnRegiones.UseVisualStyleBackColor = true;
            this.btnRegiones.Click += new System.EventHandler(this.btnRegiones_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.Location = new System.Drawing.Point(466, 225);
            this.btnAreas.Margin = new System.Windows.Forms.Padding(1);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(103, 40);
            this.btnAreas.TabIndex = 5;
            this.btnAreas.Text = "Reporte Areas de investigación";
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Location = new System.Drawing.Point(466, 296);
            this.btnClasificacion.Margin = new System.Windows.Forms.Padding(1);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(103, 40);
            this.btnClasificacion.TabIndex = 6;
            this.btnClasificacion.Text = "Reporte Clasificación";
            this.btnClasificacion.UseVisualStyleBackColor = true;
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // butVolver
            // 
            this.butVolver.BackColor = System.Drawing.Color.Transparent;
            this.butVolver.BackgroundImage = global::PlataformaGruposInvestigacion.Properties.Resources.volver;
            this.butVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butVolver.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVolver.Location = new System.Drawing.Point(21, 351);
            this.butVolver.Margin = new System.Windows.Forms.Padding(2);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(37, 40);
            this.butVolver.TabIndex = 15;
            this.butVolver.UseVisualStyleBackColor = false;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // ventReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlataformaGruposInvestigacion.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(618, 402);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.btnClasificacion);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnRegiones);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.grafico1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ventReportes";
            this.Text = "ventReportes";
            this.Load += new System.EventHandler(this.ventReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).EndInit();
            this.ResumeLayout(false);

        }

       



        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico1;
        private System.Windows.Forms.Button btnCiudades;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnRegiones;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnClasificacion;
        private System.Windows.Forms.Button butVolver;
    }
}