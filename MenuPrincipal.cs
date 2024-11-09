using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MediaColor = System.Windows.Media.Color;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


namespace PeluTop_Practica
{
    public partial class lblTituloFormHijo : Form
    {
        //llenado
        private IconButton currenBtn;
        private Panel leftBorderBtn;
        private Form ActualFormHijo;

        //COnstructor
        public lblTituloFormHijo()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //structura
        public struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241); // Asegura el uso de System.Drawing.Color
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(255,0,0);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 158, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(122, 214,46);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249,88,155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24,161,251);
        }

        //Metodos
        public void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
             if (senderBtn != null)
             {
                // Desactiva el botón actual (si hay alguno activo)
                DisableButton();

                // Configura el botón seleccionado
                currenBtn = (IconButton)senderBtn;
                currenBtn.BackColor = System.Drawing.Color.FromArgb(20, 104, 177);
                currenBtn.ForeColor = color;
                currenBtn.TextAlign = ContentAlignment.MiddleCenter;
                currenBtn.IconColor = color;
                currenBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Configuración del borde izquierdo del botón activo
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currenBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconoFormHijoActual.IconChar = currenBtn.IconChar;
                iconoFormHijoActual.IconColor = color;
             }
        }
        private void DisableButton()
        {
            if (currenBtn != null)
            {
                // Restablece el estilo original del botón anterior
                currenBtn.BackColor = System.Drawing.Color.FromArgb(18, 39, 75);
                currenBtn.ForeColor = System.Drawing.Color.Gainsboro;
                currenBtn.TextAlign = ContentAlignment.MiddleLeft;
                currenBtn.IconColor = System.Drawing.Color.Gainsboro;
                currenBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currenBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        public void OpenChildForm(Form FormHijo)
        {
            // Cierra el formulario anterior
            if (ActualFormHijo != null)
            {
                ActualFormHijo.Close();
            }
            // Configura y muestra el nuevo formulario
            ActualFormHijo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(FormHijo);  // Asegúrate de agregar el formulario hijo
            panelDesktop.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            lblLabel.Text = FormHijo.Text;

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ACERCA_DE());
        }
        private void icoInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new INICIO());
        }
        private void iconPeluqueria_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            // Aquí pasa 'this', que hace referencia a la instancia actual de lblTituloFormHijo
            OpenChildForm(new PELUQUEROS(this)); // Pasa 'this' como argumento

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActualFormHijo?.Close();
            Reset();
        }
        private void Reset()
        {
            if (ActualFormHijo != null)
            {
                ActualFormHijo.Close();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
            iconoFormHijoActual.IconChar = IconChar.Home;
            iconoFormHijoActual.IconColor = System.Drawing.Color.MediumPurple;
            lblLabel.Text = "Home";
        }
        //Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int lParam);
        private void iconLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            fmlLogin fmlLogin = new fmlLogin();
            fmlLogin.ShowDialog();  
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Maximized;
            else WindowState = FormWindowState.Normal;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            ActualFormHijo?.Close();
            Reset();
        }

        private void iconoFormHijoActual_Click(object sender, EventArgs e)
        {

        }
    }
    public static class SeleccionDatos
    {
        
        public static string PeluqueroSeleccionado { get; set; }  // Guardará el nombre del peluquero
        public static string PrecioSeleccionado { get; set; }  // Guardará el precio
        public static string ServicioSeleccionado { get; set; }  // Guardará el servicio
    }
}
