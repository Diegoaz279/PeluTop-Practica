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
        private Modelo_De_Negocio.MostrarFormHijo mostrarForm = new Modelo_De_Negocio.MostrarFormHijo();
        private ConfirmacionCita confirmacionCita = new ConfirmacionCita();

        public SERVICIOS(lblTituloFormHijo principal,ConfirmacionCita confirmacion)
        {
            InitializeComponent();
            formPrincipal = principal;
            confirmacionCita = confirmacion;
        }

        private void SERVICIOS_Load(object sender, EventArgs e)
        {

        }

        private void btn_Lavado_Click(object sender, EventArgs e)
        {
            confirmacionCita.Servicio = 1;
            // Crear el formulario que se desea mostrar
            CONFIRMACION confirmacion = new CONFIRMACION(formPrincipal,confirmacionCita);
            // Usar la referencia al formulario principal para acceder a su panel
            mostrarForm.MostrarFormularioEnPanel(confirmacion, formPrincipal.panel_Conteiner);
        }

        private void btn_Servicio2_Click(object sender, EventArgs e)
        {
            confirmacionCita.Servicio = 2;
            // Crear el formulario que se desea mostrar
            CONFIRMACION confirmacion = new CONFIRMACION(formPrincipal,confirmacionCita);
            // Usar la referencia al formulario principal para acceder a su panel
            mostrarForm.MostrarFormularioEnPanel(confirmacion, formPrincipal.panel_Conteiner);
        }

        private void btn_Servicio3_Click(object sender, EventArgs e)
        {
            confirmacionCita.Servicio = 3;
            // Crear el formulario que se desea mostrar
            CONFIRMACION confirmacion = new CONFIRMACION(formPrincipal, confirmacionCita);
            // Usar la referencia al formulario principal para acceder a su panel
            mostrarForm.MostrarFormularioEnPanel(confirmacion, formPrincipal.panel_Conteiner);
        }

        private void btn_Servicio4_Click(object sender, EventArgs e)
        {
            confirmacionCita.Servicio = 4;
            // Crear el formulario que se desea mostrar
            CONFIRMACION confirmacion = new CONFIRMACION(formPrincipal,confirmacionCita);
            // Usar la referencia al formulario principal para acceder a su panel
            mostrarForm.MostrarFormularioEnPanel(confirmacion, formPrincipal.panel_Conteiner);
        }
    }
}
