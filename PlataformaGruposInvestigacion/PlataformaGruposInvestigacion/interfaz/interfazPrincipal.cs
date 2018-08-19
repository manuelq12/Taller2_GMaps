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

            GrupoInvestigacion grupo = modelo.BuscarGrupo(codigo);
            if(grupo==null){
                MessageBox.Show("El grupo que desea buscar no existe");
            }else{
                return grupo;
            }


        }
        public void AgregarGrupo(String nombre, String codigo, String clasificacion, String articulos, String ciudad, String area, String region){
            modelo.AgregarGrupo( nombre,  codigo,  clasificacion,  articulos,  ciudad,  area,  region);
            MessageBox.Show("Se Agrego el Grupo Correctamente.");
        }
    }
}
