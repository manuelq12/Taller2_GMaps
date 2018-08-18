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
    public partial class interfazPrincipal : Form
    {
        public interfazPrincipal()
        {
            InitializeComponent();
        }

        private void interfazPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void butServicios_Click(object sender, EventArgs e)
        {
            //Mandar a la ventana Servicios
            Form ventServicios = new ventServicios();
            ventServicios.Visible = true;
            ventServicios.Show();
            this.Visible = false;

        }
    }
}
