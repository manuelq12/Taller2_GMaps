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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grafico1
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico1.Legends.Add(legend1);
            this.grafico1.Location = new System.Drawing.Point(1346, 806);
            this.grafico1.Name = "grafico1";
            this.grafico1.Size = new System.Drawing.Size(72, 58);
            this.grafico1.TabIndex = 1;
            this.grafico1.Text = "chart1";
            // 
            // btnCiudades
            // 
            this.btnCiudades.Location = new System.Drawing.Point(1242, 49);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(274, 95);
            this.btnCiudades.TabIndex = 2;
            this.btnCiudades.Text = "Reporte Ciudades";
            this.btnCiudades.UseVisualStyleBackColor = true;
            this.btnCiudades.Click += new System.EventHandler(this.btnCiudades_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(1242, 211);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(274, 95);
            this.btnArticulos.TabIndex = 3;
            this.btnArticulos.Text = "Reporte Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnRegiones
            // 
            this.btnRegiones.Location = new System.Drawing.Point(1242, 370);
            this.btnRegiones.Name = "btnRegiones";
            this.btnRegiones.Size = new System.Drawing.Size(274, 95);
            this.btnRegiones.TabIndex = 4;
            this.btnRegiones.Text = "Reporte Regiones";
            this.btnRegiones.UseVisualStyleBackColor = true;
            this.btnRegiones.Click += new System.EventHandler(this.btnRegiones_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.Location = new System.Drawing.Point(1242, 537);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(274, 95);
            this.btnAreas.TabIndex = 5;
            this.btnAreas.Text = "Reporte Areas de investigación";
            this.btnAreas.UseVisualStyleBackColor = true;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Location = new System.Drawing.Point(1242, 705);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(274, 95);
            this.btnClasificacion.TabIndex = 6;
            this.btnClasificacion.Text = "Reporte Clasificación";
            this.btnClasificacion.UseVisualStyleBackColor = true;
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1174, 751);
            this.dataGridView1.TabIndex = 7;
            // 
            // ventReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 872);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClasificacion);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnRegiones);
            this.Controls.Add(this.btnArticulos);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.grafico1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ventReportes";
            this.Text = "ventReportes";
            this.Load += new System.EventHandler(this.ventReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grafico1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart grafico1;
        private System.Windows.Forms.Button btnCiudades;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnRegiones;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnClasificacion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}