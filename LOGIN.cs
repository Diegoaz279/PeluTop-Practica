using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_De_Negocio;


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
            // Capturar datos del formulario
            string usuario = txtUsuarioo.Texts.Trim();
            string contrasena = txtContrasenao.Texts.Trim();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El campo 'Usuario' no puede estar vacío.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("El campo 'Contraseña' no puede estar vacío.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Crear el objeto usuario con los datos ingresados
                Datos.Usuarios usuarioLogin = new Datos.Usuarios
                {
                    Usuario = usuario,
                    Contrasena = contrasena
                };

                // Llamar al método de la capa de negocio para validar las credenciales
                bool esValido = MetodoUsuario.ValidarUsuario(usuarioLogin);

                if (esValido)
                {
                    // Si el login es exitoso, abre el menú principal
                    MessageBox.Show("¡Login exitoso! Bienvenido.", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide(); // Oculta el formulario actual
                    lblTituloFormHijo menuPrincipal = new lblTituloFormHijo(); // Formulario principal
                    menuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    // Si las credenciales son incorrectas, muestra un mensaje
                    MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente de nuevo.", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error durante el inicio de sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
   
}
