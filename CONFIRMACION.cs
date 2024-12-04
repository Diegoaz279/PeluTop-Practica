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

namespace PeluTop_Practica
{
    public partial class CONFIRMACION : Form
    {
        private lblTituloFormHijo formPrincipal;
        private Modelo_De_Negocio.Metodos metodos = new Modelo_De_Negocio.Metodos();
        public CONFIRMACION(lblTituloFormHijo principal)
        {
            InitializeComponent();
            formPrincipal = principal;
        }

        private async void btn_Confirmacion_Click(object sender, EventArgs e)
        {
            PantallaCargaConf asinc = new PantallaCargaConf();
            metodos.MostrarFormularioEnPanel(asinc, formPrincipal.panel_Conteiner);
          
            
        }

        private void btn_Atras_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
            SERVICIOS sERVICIOS = new SERVICIOS(formPrincipal);
            // Usar la referencia al formulario principal para acceder a su panel
            metodos.MostrarFormularioEnPanel(sERVICIOS, formPrincipal.panel_Conteiner);
        }
    }
    
}
