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

        private void btnElegir1_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new SERVICIOS(mainForm));

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
