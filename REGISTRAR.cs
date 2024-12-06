using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_De_Negocio;

namespace PeluTop_Practica
{
    public partial class REGISTRAR : Form
    {
        public REGISTRAR()
        {
            InitializeComponent();
        }

        private void REGISTRAR_Load(object sender, EventArgs e)
        {

        }

        private void btniRegistrar_Click(object sender, EventArgs e)
        {
            // Capturar los datos del formulario
            string usuario = txtUsuario.Texts.Trim();
            string contrasena = txtContrasena.Texts.Trim();
            string nombreCompleto = txtNombre.Texts.Trim();
            string correoElectronico = txtCorreo.Texts.Trim();

            try
            {
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

                if (string.IsNullOrWhiteSpace(nombreCompleto))
                {
                    MessageBox.Show("El campo 'Nombre Completo' no puede estar vacío.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(correoElectronico))
                {
                    MessageBox.Show("El campo 'Correo Electrónico' no puede estar vacío.", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto usuario con los datos ingresados
                Datos.Usuarios nuevoUsuario = new Datos.Usuarios
                {
                    Usuario = usuario,
                    Contrasena = contrasena,
                    NombreCompleto = nombreCompleto,
                    CorreoElectronico = correoElectronico
                };

                // Llamar a la capa de negocio para registrar al usuario
                bool registrado = MetodoUsuario.RegistrarUsuario(nuevoUsuario);

                if (registrado)
                {
                    // Mensaje de éxito y redirección al formulario de login
                    MessageBox.Show("Usuario registrado exitosamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    fmlLogin login = new fmlLogin();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el usuario. Inténtelo nuevamente.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                // Manejo de errores relacionados con la base de datos
                MessageBox.Show($"Error en la base de datos: {sqlEx.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejo de errores generales
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
