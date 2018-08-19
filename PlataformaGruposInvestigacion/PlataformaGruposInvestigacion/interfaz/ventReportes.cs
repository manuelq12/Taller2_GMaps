using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PlataformaGruposInvestigacion
{
    public partial class ventReportes : Form
    {
        private interfazPrincipal principal;

        public ventReportes(interfazPrincipal p)
        {
            principal = p;
            InitializeComponent();
        }

        private void ventReportes_Load(object sender, EventArgs e)
        {
            //modelo.Plataforma a = new modelo.Plataforma();
            //a.cargarGruposInvestigacion();
            //a.cargarArticulos();
            //dataGridView1.DataSource = a.Grupos;
            //a.BuscarGrupo("COL0116073");
            MessageBox.Show("La siguiente plataforma muestra los primero 3 de cada categoria seleccionada");

        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            modelo.Plataforma mundo = principal.darMundo();
            String[] ciudadesMas = new string[3];
            int[] cantidadMas = new int[3];
            List<String> ciudades = new List<String>();
            mundo.Grupos.ForEach(i => ciudades.Add(i.Ciudad));
            ciudades.RemoveAll(a => a.Equals(""));
            String aux = "Nada";
            int contador = 0;
            MessageBox.Show("Espere 5 seg mientras la nueva informacion es analizada");
            for (int i = 0; i < ciudades.Count; i++)
            {
                if( ciudades.Count(a => a.Equals(ciudades[i]))> contador)
                {
                    aux= ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }

            ciudadesMas[0] = aux;
            cantidadMas[0] = contador;
            contador = 0;
            ciudades.RemoveAll(a => a.Equals(aux));
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {

                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }

            ciudadesMas[1] = aux;
            cantidadMas[1] = contador;
            ciudades.RemoveAll(a => a.Equals(aux));
            contador = 0;
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {
                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }

            ciudadesMas[2] = aux;
            cantidadMas[2] = contador;
            for (int i = 0; i < ciudadesMas.Length; i++)
            {
                Series serie = grafico1.Series.Add(ciudadesMas[i]);
                serie.Label = cantidadMas[i].ToString();
                serie.Points.Add(cantidadMas[i]);

            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {

        }

        private void btnRegiones_Click(object sender, EventArgs e)
        {
            grafico1.Series.Clear();
            modelo.Plataforma mundo = principal.darMundo();
            String[] regionesMas = new string[3];
            int[] cantidadMas = new int[3];
            List<String> ciudades = new List<String>();
            mundo.Grupos.ForEach(i => ciudades.Add(i.Region));
            ciudades.RemoveAll(a => a.Equals(""));
            String aux = "Nada";
            int contador = 0;
            MessageBox.Show("Espere 5 seg mientras la nueva informacion es analizada");
            for (int i = 0; i < ciudades.Count; i++)
            {
                if( ciudades.Count(a => a.Equals(ciudades[i]))> contador)
                {
                    aux= ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            regionesMas[0] = aux;
            cantidadMas[0] = contador;
            contador = 0;
            ciudades.RemoveAll(a => a.Equals(aux));
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {

                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            regionesMas[1] = aux;
            cantidadMas[1] = contador;
            ciudades.RemoveAll(a => a.Equals(aux));
            contador = 0;
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {
                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            regionesMas[2] = aux;
            cantidadMas[2] = contador;
            for (int i = 0; i < regionesMas.Length; i++)
            {
                Series serie = grafico1.Series.Add(regionesMas[i]);
                serie.Label = cantidadMas[i].ToString();
                serie.Points.Add(cantidadMas[i]);

            }
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            grafico1.Series.Clear();
            modelo.Plataforma mundo = principal.darMundo();
            String[] AreasMas = new string[3];
            int[] cantidadMas = new int[3];
            List<String> ciudades = new List<String>();
            mundo.Grupos.ForEach(i => ciudades.Add(i.AreaInvestigacion));
            ciudades.RemoveAll(a => a.Equals(""));
            String aux = "Nada";
            int contador = 0;
            MessageBox.Show("Espere 5 seg mientras la nueva informacion es analizada");
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {
                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            AreasMas[0] = aux;
            cantidadMas[0] = contador;
            contador = 0;
            ciudades.RemoveAll(a => a.Equals(aux));
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {

                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            AreasMas[1] = aux;
            cantidadMas[1] = contador;
            ciudades.RemoveAll(a => a.Equals(aux));
            contador = 0;
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {
                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            AreasMas[2] = aux;
            cantidadMas[2] = contador;
            for (int i = 0; i < AreasMas.Length; i++)
            {
                Series serie = grafico1.Series.Add(AreasMas[i]);
                serie.Label = cantidadMas[i].ToString();
                serie.Points.Add(cantidadMas[i]);

            }
        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {
            grafico1.Series.Clear();
            modelo.Plataforma mundo = principal.darMundo();
            String[] clasiMas = new string[3];
            int[] cantidadMas = new int[3];
            List<String> ciudades = new List<String>();
            mundo.Grupos.ForEach(i => ciudades.Add(i.Clasificacion));
            ciudades.RemoveAll(a => a.Equals(""));
            String aux = "Nada";
            int contador = 0;
            MessageBox.Show("Espere 5 seg mientras la nueva informacion es analizada");
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {
                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            clasiMas[0] = aux;
            cantidadMas[0] = contador;
            contador = 0;
            ciudades.RemoveAll(a => a.Equals(aux));
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {

                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            clasiMas[1] = aux;
            cantidadMas[1] = contador;
            ciudades.RemoveAll(a => a.Equals(aux));
            contador = 0;
            for (int i = 0; i < ciudades.Count; i++)
            {
                if (ciudades.Count(a => a.Equals(ciudades[i])) > contador)
                {
                    aux = ciudades[i];
                    contador = ciudades.Count(a => a.Equals(ciudades[i]));
                }
            }
            clasiMas[2] = aux;
            cantidadMas[2] = contador;
            for (int i = 0; i < clasiMas.Length; i++)
            {
                Series serie = grafico1.Series.Add(clasiMas[i]);
                serie.Label = cantidadMas[i].ToString();
                serie.Points.Add(cantidadMas[i]);

            }
        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            Form ventInicio = new interfazPrincipal();

            ventInicio.Visible = true;
            ventInicio.Show();
            this.Visible = false;
        }
    }
}
