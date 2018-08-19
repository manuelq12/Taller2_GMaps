using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //MessageBox.Show(a.BuscarGrupo("COL0116073").ArtFrecuentados.ToString());

        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {

        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {

        }

        private void btnRegiones_Click(object sender, EventArgs e)
        {

        }

        private void btnAreas_Click(object sender, EventArgs e)
        {

        }

        private void btnClasificacion_Click(object sender, EventArgs e)
        {

        }
    }
}
