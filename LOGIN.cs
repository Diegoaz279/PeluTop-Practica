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

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            // Verificar las credenciales
            if (Credenciale.UsuarioRegistrado == txtUsuario.Text &&
                Credenciale.ContrasenaRegistrada == txtContraseña.Text)
            {
                lblTituloFormHijo menuPrincipal = new lblTituloFormHijo();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
            }*/

          
            this.DialogResult = DialogResult.OK; // Establece el resultado en OK
            this.Close(); // Cierra el formulario de login

        }

        private void lblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            REGISTRAR registrar = new REGISTRAR();
            registrar.ShowDialog();
            this.Hide();
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.DimGray;
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

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
    }
    public class Credenciale
    {
        // Propiedades de instancia
        public string usuario { get; set; } 
        public string contrasena { get; set; }

        // Propiedades estáticas para guardar las credenciales de registro
        public static string UsuarioRegistrado { get; set; }
        public static string ContrasenaRegistrada { get; set; }
    }
}
