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
            grafico1.Series.Clear();
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
            //Reporte Artículos
            MessageBox.Show("Espere 5 seg mientras la nueva informacion es analizada");
            grafico1.Series.Clear();
            modelo.Plataforma mundo = principal.darMundo();
            int[] articulos = new int[3];
            int[] cantidad = new int[3];
            List<int> todos = new List<int>();
            mundo.Grupos.ForEach(i => i.ArtFrecuentados.ForEach(s => todos.Add(s)));
            var group = todos.GroupBy(i => i);
            int max1 = 0;
            int id1 = 0;
            int max2 = -2;
            int id2 = 0;
            int max3 = -4;
            int id3 = 0;
            int temp = 0;
            foreach (IGrouping<int, int> n in group)
            {
                temp = n.Count();
                if (n.Key != -1)
                {
                    if (temp > max1)
                    {
                        max1 = temp;
                        id1 = n.Key;
                    }
                }
            }
            foreach (IGrouping<int, int> n in group)
            {
                temp = n.Count();
                if (n.Key != id1 && n.Key != -1)
                {
                    if (temp < max1 && temp > max2)
                    {
                        max2 = temp;
                        id2 = n.Key;
                    }
                }
            }
            foreach (IGrouping<int, int> n in group)
            {
                if (n.Key != id1 && n.Key != id2 && n.Key != -1)
                {
                    temp = n.Count();
                    if (temp < max2 && temp > max3)
                    {
                        max3 = temp;
                        id3 = n.Key;
                    }

                }
            }
            cantidad[0] = max1;
            cantidad[1] = max2;
            cantidad[2] = max3;
            articulos[0] = id1;
            articulos[1] = id2;
            articulos[2] = id3;

          for(int x = 0; x < articulos.Length; x++)
            {
                Series serie = grafico1.Series.Add(articulos[x].ToString());
                serie.Label = cantidad[x].ToString();
                serie.Points.Add(cantidad[x]);
            }





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
