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
    public partial class fmlLogin : Form
    {
        public fmlLogin()
        {
            InitializeComponent();       
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            REGISTRAR registrar = new REGISTRAR();
            registrar.ShowDialog();
           
        }
        private void btniNGRESAR_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
            lblTituloFormHijo MenuPrincipal = new lblTituloFormHijo();
            MenuPrincipal.ShowDialog();
           
        }

    }
   
}
