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

        private void btn_Peluquero1_Click(object sender, EventArgs e)
        {
            string Peluquero1;
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }  
        private void btnPeluquero4_Click(object sender, EventArgs e)
        {
            string Peluquero3;
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }
        private void btnPeluquero4_Click_1(object sender, EventArgs e)
        {
            string Peluquero4;
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }
        private void btnPeluquero2_Click(object sender, EventArgs e)
        {
            string Peluquero2;
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }
        
    }
}
