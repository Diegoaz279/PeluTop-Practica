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
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

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
            this.Dispose(); // Cierra el formulario de login
            lblTituloFormHijo MenuPrincipal = new lblTituloFormHijo();
            MenuPrincipal.ShowDialog();
           
        }

        private void txtContraseñaa__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
               
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                
            }
        }    
    }
   
}
