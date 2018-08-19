using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlataformaGruposInvestigacion.interfaz;
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
                if (ventana.Buscar(codigo) != null) { 
                txtNombre.Text = ventana.Buscar(codigo).Nombre;
                txtCodigo.Text = ventana.Buscar(codigo).Codigo;
                txtArea.Text = ventana.Buscar(codigo).AreaInvestigacion;
                txtRegion.Text = ventana.Buscar(codigo).Region;
                txtClasificacion.Text = ventana.Buscar(codigo).Clasificacion;
                txtArticulos.Text = ventana.Buscar(codigo).ArtFrecuentados.ToString;
                txtCiudad.Text = ventana.Buscar(codigo).Ciudad;
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

    }
}
