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
    public partial class ventServicios : Form
    {
        public ventServicios()
        {
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

            String nombre = txtNombre.Text;

            if (nombre=="")
            {
                MessageBox.Show("Ingrese el nombrel grupo de investigación");
            }

        }

        private void butRegistrar_Click(object sender, EventArgs e)
        {
            String nombre = txtNombre.Text;
            String codigo = txtCodigo.Text;
            String ciudad = txtCiudad.Text;
            String areaInvestigacion = txtArea.Text;
            String region = txtRegion.Text;

            if (nombre == "" || codigo == "" || ciudad == "" || areaInvestigacion == "" || region == "") ;
            {
                MessageBox.Show("Existe un campo en el registro sin llenar");
            }

        }

    }
}
