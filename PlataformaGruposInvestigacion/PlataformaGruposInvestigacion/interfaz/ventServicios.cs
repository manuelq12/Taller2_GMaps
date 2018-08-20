using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlataformaGruposInvestigacion.interfaz;
using PlataformaGruposInvestigacion.modelo;
using System.Windows.Forms;

namespace PlataformaGruposInvestigacion
{
    public partial class ventServicios : Form
    {
        private interfazPrincipal ventana;
        public ventServicios(interfazPrincipal principal)
        {
            ventana = principal;
            InitializeComponent();
        }

        private void ventServicios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventInicio = new interfazPrincipal();
            
            ventInicio.Visible = true;
            ventInicio.Show();
            this.Visible = false;



        }

        private void butBuscar_Click(object sender, EventArgs e)
        {

            String codigo = txtCodigo.Text;

            if (codigo == "")
            {
                MessageBox.Show("Ingrese el codigo grupo de investigación");
            }
            else
            {
                List<int> a =ventana.Buscar(codigo).ArtFrecuentados;
                String articulos = "";
                int [] n = a.Where(i=> i!=-1).ToArray();
                for(int x = 0; x < n.Length; x++)
                {
                    if(x == n.Length - 1)
                    {
                        articulos += n[x];
                    }
                    else
                    {
                        articulos += n[x] + " ";
                    }
                }
                if (ventana.Buscar(codigo) != null) { 
                txtNombre.Text = ventana.Buscar(codigo).Nombre;
                txtCodigo.Text = ventana.Buscar(codigo).Codigo;
                txtArea.Text = ventana.Buscar(codigo).AreaInvestigacion;
                txtRegion.Text = ventana.Buscar(codigo).Region;
                txtClasificacion.Text = ventana.Buscar(codigo).Clasificacion;
                txtArticulos.Text = articulos;
                txtCiudad.Text = ventana.Buscar(codigo).Ciudad;
                }else{
                    MessageBox.Show("No existe el grupo que desea buscar");
                }
            }

        }

        private void butRegistrar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String codigo = txtCodigo.Text;
            String ciudad = txtCiudad.Text;
            String clasificacion = txtClasificacion.Text;
            String articulos = txtArticulos.Text;
            String areaInvestigacion = txtArea.Text;
            String region = txtRegion.Text;

            if (nombre == "" || codigo == "" || ciudad == "" || areaInvestigacion == "" || region == "") 
            {
                MessageBox.Show("Existe un campo en el registro sin llenar");
            }else{
                ventana.AgregarGrupo(nombre, codigo, clasificacion, articulos, ciudad, areaInvestigacion, region);
            }
            limpiar limpiarBox = new limpiar();
            limpiarBox.borrarCampos(this);
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
          
            String nombre = txtNombre.Text;
            String codigo = txtCodigo.Text;
            String ciudad = txtCiudad.Text;
            String clasificacion = txtClasificacion.Text;
            String articulos = txtArticulos.Text;
            String areaInvestigacion = txtArea.Text;
            String region = txtRegion.Text;

            GrupoInvestigacion nuevo = ventana.Buscar(codigo);
            if (nuevo == null)
            {
                MessageBox.Show("El codigo de los grupos no se puede modificar");
            }
            else
            {
                var lista = articulos.Split(' ').Select(i => Int32.Parse(i));
                List<int> art = new List<int>();
                List<int> listaNueva = art.Union(lista).ToList<int>();

                nuevo.Nombre = nombre;
                nuevo.Ciudad = ciudad;
                nuevo.Clasificacion = clasificacion;
                nuevo.ArtFrecuentados = listaNueva;
                nuevo.AreaInvestigacion = areaInvestigacion;
                nuevo.Region = region;
                ventana.ActualizarGrupo(nuevo);
                limpiar limpiarBox = new limpiar();
                limpiarBox.borrarCampos(this);
                ventana.gMapControl1_Load(sender, e);
            }
        }

        
    }
}
