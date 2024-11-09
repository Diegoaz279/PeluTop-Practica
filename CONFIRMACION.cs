using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace PeluTop_Practica
{
    public partial class CONFIRMACION : Form
    {
        private lblTituloFormHijo mainForm;
        public CONFIRMACION(lblTituloFormHijo mainFormInstance)
        {
            InitializeComponent();
            this.mainForm = mainFormInstance;
            cmbNombre.Texts = "Diego";
            cmbPeluquero.Texts = SeleccionDatos.PeluqueroSeleccionado;
            cmbPrecio.Texts = SeleccionDatos.PrecioSeleccionado;
            cmbServicio.Texts = SeleccionDatos.ServicioSeleccionado;


        }
        //Boton de aceptar
        private void btnServicio4_Click(object sender, EventArgs e)
        {
            // Abre el formulario INICIO
            mainForm.OpenChildForm(new INICIO());
            this.Dispose();
            PantallaCargaConf conf = new PantallaCargaConf();
            conf.ShowDialog();
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
            // Abre el formulario INICIO
            mainForm.OpenChildForm(new INICIO());
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {           
        }

        private void cmbServicio_OnSelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
    
}
