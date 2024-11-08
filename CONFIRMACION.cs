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
    public partial class CONFIRMACION : Form
    {
        private lblTituloFormHijo mainForm;
        public CONFIRMACION(lblTituloFormHijo mainFormInstance)
        {
            InitializeComponent();
            mainForm = mainFormInstance;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // Abre el formulario INICIO
            mainForm.OpenChildForm(new INICIO());
        }
    }
    
}
