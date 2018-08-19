using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlataformaGruposInvestigacion.modelo;

namespace PlataformaGruposInvestigacion
{
    public partial class interfazPrincipal : Form

    {
        private Plataforma modelo;
        public interfazPrincipal()
        {
            modelo = new Plataforma();
            InitializeComponent();
            modelo.cargarGruposInvestigacion();
            modelo.cargarArticulos();
        }

        private void interfazPrincipal_Load(object sender, EventArgs e)
        {
            
                 
        }

        private void butServicios_Click(object sender, EventArgs e)
        {
            //Mandar a la ventana Servicios
            Form ventServicios = new ventServicios(this);
            ventServicios.Visible = true;
            ventServicios.Show();
            this.Visible = false;

        }
        public GrupoInvestigacion Buscar(String codigo)
        {


            return modelo.BuscarGrupo(codigo);

        }
        public void AgregarGrupo(String nombre, String codigo, String clasificacion, String articulos, String ciudad, String area, String region){
            modelo.AgregarGrupo( nombre,  codigo,  clasificacion,  articulos,  ciudad,  area,  region);
            MessageBox.Show("Se Agrego el Grupo Correctamente.");
        }


        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali,Colombia");

        }

        private void butReportes_Click(object sender, EventArgs e)
        {
            /*  Form ventServicios = new ventServicios(this);
              ventServicios.Visible = true;
              ventServicios.Show();
              this.Visible = false;
              */

            Form ventReportes = new ventReportes();
            ventReportes.Visible = true;
            ventReportes.Show();
            this.Visible = false;
            
        }
    }
}
