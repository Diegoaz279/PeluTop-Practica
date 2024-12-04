using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Modelo_De_Negocio;



namespace PeluTop_Practica
{
    public partial class lblTituloFormHijo : Form
    {
        // Instancia de la clase de negocio
        Modelo_De_Negocio.Metodos metodos = new Modelo_De_Negocio.Metodos();
        public lblTituloFormHijo()
        {
            InitializeComponent();

            //Configuracion de la ventana
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

  
     
        //Configuración para arrastrar la ventana del formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int lParam);

        //Botón para cerrar la ventana actual
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Botón para minimizar la ventana actual
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Botón para maximizar o restaurar la ventana actual
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        //MEtodo para arrastrar la ventana al hacer clic en el panel
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
        }


        //todo Boton Inicio
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            //Crear el formulario que se desea mostrar
            INICIO inicio = new INICIO();

            //Llamar al método para mostrar el formulario en el panel panel_Conteiner
            metodos.MostrarFormularioEnPanel(inicio, panel_Conteiner);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        //todo Boton Seleccionar peluquero
        private void btn_Peluquero_Click(object sender, EventArgs e)
        {   
            // Crear el formulario que se desea mostrar
            PELUQUEROS pELUQUEROS = new PELUQUEROS(this);

            // Llamar al método para mostrar el formulario en el panel `panel_Conteiner`
            metodos.MostrarFormularioEnPanel(pELUQUEROS, panel_Conteiner);
        }

     //picture box inicio
      

        //todo Boton De Acerca De
        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            // Crear el formulario que se desea mostrar
           ACERCA_DE acercaDe = new ACERCA_DE();
           
            // Llamar al método para mostrar el formulario en el panel `panel_Conteiner`
            metodos.MostrarFormularioEnPanel(acercaDe, panel_Conteiner);
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Dispose();

            fmlLogin login = new fmlLogin();
            login.ShowDialog();
        }
    }
}
