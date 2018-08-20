using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.WindowsForms;
using System.Windows.Forms;
using PlataformaGruposInvestigacion.modelo;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System.Collections;
using GoogleMaps.LocationServices;

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
        public void ActualizarGrupo(GrupoInvestigacion a)
        {
            modelo.ActualizarGrupo(a);
            MessageBox.Show("Grupo Actualizado");
        }
        public GrupoInvestigacion Buscar(String codigo)
        {


            return modelo.BuscarGrupo(codigo);

        }
        public void AgregarGrupo(String nombre, String codigo, String clasificacion, String articulos, String ciudad, String area, String region)
        {
            modelo.AgregarGrupo(nombre, codigo, clasificacion, articulos, ciudad, area, region);

            MessageBox.Show("Se Agrego el Grupo Correctamente.");
        }


        //private void gMapControl1_Load(object sender, EventArgs e)
        //{
        //    gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
        //    GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
        //    gMapControl1.SetPositionByKeywords("Cali,Colombia");

        //}

        private void butReportes_Click(object sender, EventArgs e)
        {
            /*  Form ventServicios = new ventServicios(this);
              ventServicios.Visible = true;
              ventServicios.Show();
              this.Visible = false;
              */

            Form ventReportes = new ventReportes(this);
            ventReportes.Visible = true;
            ventReportes.Show();
            this.Visible = false;

        }
        public Plataforma darMundo()
        {
            return modelo;
        }

        private void butCantFrecuenciaArch_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            // Initialize map:
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia");

            for (int i = 0; i < modelo.Grupos.Capacity && i <= 10; i++)
            {
                var region = modelo.Grupos[i].Region;
                var ciudad = modelo.Grupos[i].Ciudad;
                Console.WriteLine(region + " " + ciudad);
                if (region != null && ciudad != null)
                {
                    var locationService = new GoogleLocationService();
                    try
                    {
                        var point = locationService.GetLatLongFromAddress(region + ", " + ciudad);
                        if (point != null)
                        {

                            var latitude = point.Latitude;
                            var longitude = point.Longitude;
                            GMapOverlay markersOverlay = new GMapOverlay("Marcador");
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude),
                              GMarkerGoogleType.green);
                            markersOverlay.Markers.Add(marker);

                            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            marker.ToolTipText = string.Format("Nombre:\n {0} ", modelo.Grupos[i].Nombre);
                            gMapControl1.Overlays.Add(markersOverlay);

                        }
                    }
                    catch (Exception)
                    {

                        
                    }
                   
                }
            }
        }
    }
}
