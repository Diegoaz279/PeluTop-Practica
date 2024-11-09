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
            REGISTRAR registrar = new REGISTRAR();
            registrar.ShowDialog();
            this.Hide();
        }
        private void btniNGRESAR_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK; // Establece el resultado en OK
            this.Close(); // Cierra el formulario de login

        }

        private void txtContraseñaa__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

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
