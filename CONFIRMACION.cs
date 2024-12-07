using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using Modelo_De_Negocio;
using Datos;


namespace PeluTop_Practica
{
    public partial class CONFIRMACION : Form
    {
        private lblTituloFormHijo formPrincipal;
        private Modelo_De_Negocio.MostrarFormHijo formHijo = new Modelo_De_Negocio.MostrarFormHijo();
        private ConfirmacionCita confirmacionCita;
        public CONFIRMACION(lblTituloFormHijo principal, ConfirmacionCita confirmacion)
        {
            InitializeComponent();
            formPrincipal = principal;
            confirmacionCita = confirmacion;  // Asigna la instancia recibida
            AsignarDatosPeluquero();  // Llama al método para asignar el nombre del peluquero
            AsignarDatosServicio();
        }
        // Método para asignar los datos del peluquero
        // Método para asignar los datos del peluquero
        private void AsignarDatosPeluquero()
        {
            if (confirmacionCita.Peluquero == 0)
            {
                MessageBox.Show("ID del peluquero no está configurado.");
                return;
            }

            using (var db = new PeluTopDBEntities())
            {
                var peluquero = db.Peluqueros.FirstOrDefault(p => p.IdPeluquero == confirmacionCita.Peluquero);

                if (peluquero != null)
                {
                    txtPeluquero.Text = peluquero.Nombre;
                }
                else
                {
                    txtPeluquero.Text = "Peluquero no encontrado";
                }
            }
        }

        // Método para asignar los datos del servicio
        private void AsignarDatosServicio()
        {
            if (confirmacionCita.Servicio == 0)
            {
                MessageBox.Show("ID del servicio no está configurado.");
                return;
            }

            using (var db = new PeluTopDBEntities())
            {
                var servicio = db.Servicios.FirstOrDefault(s => s.IdServicio == confirmacionCita.Servicio);

                if (servicio != null)
                {
                    txtServicio.Text = servicio.Nombre;
                    txtDuracion.Text = $"{servicio.Duracion} minutos";
                    txtPrecio.Text = servicio.Precio.ToString("C"); // Formato de moneda
                }
                else
                {
                    txtServicio.Text = "Servicio no encontrado";
                    txtDuracion.Text = "Duración no disponible";
                    txtPrecio.Text = "Precio no disponible";
                }
            }
        }

        private void btn_Confirmacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva instancia de la cita
                Datos.Citas nuevaCita = new Datos.Citas
                {
                    IdUsuario = confirmacionCita.IdUsuario, // ID del usuario logueado
                    Peluquero = confirmacionCita.Peluquero, // ID del peluquero seleccionado
                    Servicio = confirmacionCita.Servicio,   // ID del servicio seleccionado
                    Fecha = DateTime.Parse(txtFecha.Text),  // Fecha de la cita
                    Precio = decimal.Parse(txtPrecio.Text), // Convertir el precio a decimal
                    Duracion = int.Parse(txtDuracion.Text)  // Convertir la duración a entero
                };

                // Guardar la cita en la base de datos
                ConfirmacionCita modeloCita = new ConfirmacionCita();
                bool guardado = modeloCita.GuardarCita(nuevaCita);

                // Mostrar el resultado al usuario
                MessageBox.Show(guardado ? "Cita confirmada exitosamente." : "Error al confirmar la cita.");
                if (guardado) this.Close(); // Cerrar el formulario si todo salió bien
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private void btn_Atras_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS(formPrincipal, confirmacionCita);
            // Usar la referencia al formulario principal para acceder a su panel
            formHijo.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }
    }
    
}
