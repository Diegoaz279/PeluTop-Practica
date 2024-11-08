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

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.OpenChildForm(new CONFIRMACION(mainForm));
        }
    }
}
