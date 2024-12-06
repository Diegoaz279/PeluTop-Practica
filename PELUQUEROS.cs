using System;
using System.Drawing;
using System.Windows.Forms;
using static PeluTop_Practica.lblTituloFormHijo;
using Modelo_De_Negocio;
using Datos;
namespace PeluTop_Practica
{
    public partial class PELUQUEROS : Form
    {
        private lblTituloFormHijo formPrincipal;
        private Modelo_De_Negocio.MostrarFormHijo mostrarFormHijo = new Modelo_De_Negocio.MostrarFormHijo();
        private ConfirmacionCita confirmacionCita = new ConfirmacionCita();

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
            // Asigna directamente el IdPeluquero en la instancia de ConfirmacionCita
            confirmacionCita.IdPeluquero = 1;
            //instancia el formulario servicio
            SERVICIOS servicio = new SERVICIOS(formPrincipal, confirmacionCita);
            //referencia al formulario principal para acceder a su panel
            mostrarFormHijo.MostrarFormularioEnPanel(servicio, formPrincipal.panel_Conteiner);
        }  
      
        private void btnPeluquero2_Click(object sender, EventArgs e)
        {
            // Asigna directamente el IdPeluquero en la instancia de ConfirmacionCita
            confirmacionCita.IdPeluquero = 2;
            //instancia el formulario servicio
            SERVICIOS servicio = new SERVICIOS(formPrincipal,confirmacionCita);
            //referencia al formulario principal para acceder a su panel
            mostrarFormHijo.MostrarFormularioEnPanel(servicio, formPrincipal.panel_Conteiner);
        } 
        private void btnPeluquero3_Click(object sender, EventArgs e)
        {
            // Asigna directamente el IdPeluquero en la instancia de ConfirmacionCita
            confirmacionCita.IdPeluquero = 3; ;
            //instancia el formulario servicio
            SERVICIOS servicio = new SERVICIOS(formPrincipal,confirmacionCita);
            //referencia al formulario principal para acceder a su panel
            mostrarFormHijo.MostrarFormularioEnPanel(servicio, formPrincipal.panel_Conteiner);
        } 
        private void btnPeluquero4_Click_1(object sender, EventArgs e)
        {
            // Asigna directamente el IdPeluquero en la instancia de ConfirmacionCita
            confirmacionCita.IdPeluquero = 4;
            //instancia el formulario servicio
            SERVICIOS servicio = new SERVICIOS(formPrincipal, confirmacionCita);
            //referencia al formulario principal para acceder a su panel
            mostrarFormHijo.MostrarFormularioEnPanel(servicio, formPrincipal.panel_Conteiner);
        } 
    }
}
