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
        private void AsignarDatosPeluquero()
        {
            // Asegúrate de que el IdPeluquero es válido
            if (confirmacionCita.IdPeluquero == 0)
            {
                MessageBox.Show("ID del peluquero no está configurado.");
                return;
            }

            using (var db = new PeluTopDBEntities())  // Asegúrate de que el contexto se llama correctamente
            {
                var peluquero = db.Peluqueros.FirstOrDefault(p => p.IdPeluquero == confirmacionCita.IdPeluquero );

                if (peluquero != null)
                {
                    txtPeluquero.Text = peluquero.Nombre;  // Asumiendo que la propiedad es 'Nombre'
                }
                else
                {
                    txtPeluquero.Text = "Peluquero no encontrado";
                }
            }
        }
        private void AsignarDatosServicio()
        {
            // Verifica que el servicio esté asignado a la cita (asumiendo que confirmacionCita tiene un IdServicio)
            if (confirmacionCita.IdServicio == 0)
            {
                MessageBox.Show("ID del servicio no está configurado.");
                return;
            }

            using (var db = new PeluTopDBEntities())
            {
                var servicio = db.Servicios.FirstOrDefault(s => s.IdServicio == confirmacionCita.IdServicio);

                if (servicio != null)
                {
                    txtServicio.Text = servicio.Nombre;  // Asumiendo que la propiedad se llama 'Nombre'
                    txtPrecio.Text = servicio.Precio.ToString("C");  // Formatea el precio como moneda
                }
                else
                {
                    txtServicio.Text = "Servicio no encontrado";
                    txtPrecio.Text = "Precio no disponible";
                }
            }
        }

        private void btn_Confirmacion_Click(object sender, EventArgs e)
        {
            PantallaCargaConf pantallacarga = new PantallaCargaConf();
            formHijo.MostrarFormularioEnPanel(pantallacarga, formPrincipal.panel_Conteiner);
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
