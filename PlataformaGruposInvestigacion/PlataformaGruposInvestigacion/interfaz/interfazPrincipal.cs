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
using PlataformaGruposInvestigacion.interfaz;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;
using System.Collections;
using GoogleMaps.LocationServices;

namespace PlataformaGruposInvestigacion
{

    public partial class interfazPrincipal : Form


    {
        private Location Locat;
        private Plataforma modelo;
        public interfazPrincipal()
        {
            Locat = new Location();
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
            this.Visible = true;

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
            modelo.AgregarGrupo(nombre, codigo, clasificacion, articulos, ciudad, area, region,0,0,0,0);

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
        //
        public void gMapControl1_Load(object sender, EventArgs e)
        {
            GMapOverlay markers = new GMapOverlay("Marcador");
            gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.SetPositionByKeywords("Cali, Colombia.");
            gMapControl1.ShowCenter = true;

            for (int i = 0; i < modelo.Grupos.Count(); i++)
            {
                double x1 = modelo.Grupos[i].x1;
                double x2 = modelo.Grupos[i].x2;
                double y1 = modelo.Grupos[i].y1;
                double y2 = modelo.Grupos[i].y2;
                if(x1!=0&& x2 != 0&& y1!=0 && y2!=0)
                {
                    double x = (x1 - x2) + x2;
                    double y = (y1 - y2) + y2;
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(y, x), GMarkerGoogleType.blue);
                    marker.IsVisible = (true);
                    markers.Markers.Add(marker);
                }
            }

            gMapControl1.Overlays.Add(markers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Botón BuscarMapa
            string codigo = Microsoft.VisualBasic.Interaction.InputBox("Ingresar el codigo del grupo que desea buscar :");
            GrupoInvestigacion a = Buscar(codigo);
            if (a == null)
            {
                MessageBox.Show("No existe el grupo que desea señalar");

            }
            else
            {   
                    var locationService = new GoogleLocationService();
                    try
                    {
                        var point = locationService.GetLatLongFromAddress(a.Region + ", " + a.Ciudad);
                        if (point != null)
                        {

                            var latitude = point.Latitude;
                            var longitude = point.Longitude;
                            GMapOverlay markersOverlay = new GMapOverlay("Marcador");
                            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(latitude, longitude),
                              GMarkerGoogleType.yellow);

                            markersOverlay.Markers.Add(marker);

                            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                            marker.ToolTipText = string.Format("Nombre:\n {0} \n Codigo: \n {1}", a.Nombre, a.Codigo);
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
