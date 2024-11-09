using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PeluTop_Practica.lblTituloFormHijo;

namespace PeluTop_Practica
{
  
    public partial class PELUQUEROS : Form
    {
        private lblTituloFormHijo mainForm;
        public PELUQUEROS(lblTituloFormHijo mainFormInstance)
        {
            InitializeComponent();
            mainForm = mainFormInstance;
        }
        private void btnPeluquero1_Click(object sender, EventArgs e)
        {
            // Asigna el peluquero seleccionado a la variable estática
            SeleccionDatos.PeluqueroSeleccionado = "Juan Mauel";  // Cambia esto por el nombre real del peluquero
            mainForm.OpenChildForm(new SERVICIOS(mainForm));
        }

        private void btnPeluquero2_Click(object sender, EventArgs e)
        {
            SeleccionDatos.PeluqueroSeleccionado = "Jhon Mauel";
            mainForm.OpenChildForm(new SERVICIOS(mainForm));
        }

        private void btnPeluquero3_Click(object sender, EventArgs e)
        {
            SeleccionDatos.PeluqueroSeleccionado = "Cristian Mejia";
            mainForm.OpenChildForm(new SERVICIOS(mainForm));
        }

        private void btnPeluquero4_Click(object sender, EventArgs e)
        {
            SeleccionDatos.PeluqueroSeleccionado = "Elias Perez";
            mainForm.OpenChildForm(new SERVICIOS(mainForm));
        }
    }
}
