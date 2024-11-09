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
        private lblTituloFormHijo mainForm;
        public SERVICIOS(lblTituloFormHijo mainFormInstance)
        {
            InitializeComponent();
            mainForm = mainFormInstance;

        }
        private void btnPeluquero1_Click(object sender, EventArgs e)
        {
            // Asigna los valores seleccionados a las variables estáticas
            SeleccionDatos.ServicioSeleccionado = "Lavado De Cabeza";  // Cambia esto por el nombre real del servicio
            SeleccionDatos.PrecioSeleccionado = "RD$ 100";  // Cambia esto por el precio real
            // Navega al formulario CONFIRMACION
            mainForm.OpenChildForm(new CONFIRMACION(mainForm));
           
        }

        private void btnServicio2_Click(object sender, EventArgs e)
        {
            SeleccionDatos.ServicioSeleccionado = "Corte De Pelo";
            SeleccionDatos.PrecioSeleccionado = "RD$ 350";
            mainForm.OpenChildForm(new CONFIRMACION(mainForm));
        }

        private void btnPeluquero3_Click(object sender, EventArgs e)
        {
            SeleccionDatos.ServicioSeleccionado = "Cerquillo";
            SeleccionDatos.PrecioSeleccionado = "RD$ 200";
            mainForm.OpenChildForm(new CONFIRMACION(mainForm));
        }

        private void btnServicio4_Click(object sender, EventArgs e)
        {
            SeleccionDatos.ServicioSeleccionado = "Afeitada";
            SeleccionDatos.PrecioSeleccionado = "RD$ 250";
            mainForm.OpenChildForm(new CONFIRMACION(mainForm));
        }

        private void SERVICIOS_Load(object sender, EventArgs e)
        {

        }
    }
}
