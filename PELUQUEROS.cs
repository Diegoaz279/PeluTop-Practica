using System;
using System.Drawing;
using System.Windows.Forms;
using static PeluTop_Practica.lblTituloFormHijo;

namespace PeluTop_Practica
{
    public partial class PELUQUEROS : Form
    {
        private lblTituloFormHijo formPrincipal;
        private Modelo_De_Negocio.Metodos metodos = new Modelo_De_Negocio.Metodos();

        public PELUQUEROS(lblTituloFormHijo principal)
        {
            InitializeComponent();
            formPrincipal = principal; // Guarda la referencia al formulario principal
        }
        private void PELUQUEROS_Load(object sender, EventArgs e)
        {
           
        }

        private void btnPeluquero4_Click(object sender, EventArgs e)
        {
           
        }
        private void btnPeluquero4_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS();

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }
    }
}
