using Modelo_De_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeluTop_Practica
{
    public partial class SERVICIOS : Form
    {
        private lblTituloFormHijo formPrincipal;
        private Modelo_De_Negocio.Metodos metodos = new Modelo_De_Negocio.Metodos();
        public SERVICIOS(lblTituloFormHijo principal)
        {
            InitializeComponent();
            formPrincipal = principal;
           

        }
        private void btnPeluquero1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void btnServicio2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPeluquero3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnServicio4_Click(object sender, EventArgs e)
        {
            
        }

        private void SERVICIOS_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btn_Lavado_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
           CONFIRMACION cONFIRMACION = new CONFIRMACION(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(cONFIRMACION, formPrincipal.panel_Conteiner);
        }

        private void btn_Servicio2_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
            CONFIRMACION cONFIRMACION = new CONFIRMACION(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(cONFIRMACION, formPrincipal.panel_Conteiner);
        }

        private void btn_Servicio3_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
            CONFIRMACION cONFIRMACION = new CONFIRMACION(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(cONFIRMACION, formPrincipal.panel_Conteiner);
        }

        private void btn_Servicio4_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
            CONFIRMACION cONFIRMACION = new CONFIRMACION(formPrincipal);

            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(cONFIRMACION, formPrincipal.panel_Conteiner);
        }
    }
}
