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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            cmbNombre.Texts = "Diego Castillo";
        cmbPeluquero.Texts = SeleccionDatos.PeluqueroSeleccionado;
            cmbPrecio.Texts = SeleccionDatos.PrecioSeleccionado;
            cmbServicio.Texts = SeleccionDatos.ServicioSeleccionado;
        }

        private void cmbNombre_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbPeluquero_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbServicio_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPrecio_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Seguro que Quieres Cancerlar la Cita");
            cmbNombre.Texts = "";
            cmbPeluquero.Texts = "";
            cmbPrecio.Texts = "";
            cmbServicio.Texts = "";
        }
    }
}
