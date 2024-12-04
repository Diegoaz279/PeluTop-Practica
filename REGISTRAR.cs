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
    public partial class REGISTRAR : Form
    {
        public REGISTRAR()
        {
            InitializeComponent();
        }

        private void REGISTRAR_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btniNGRESAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario Registrado con éxito");
            this.Dispose();
            // Abre el formulario de login y cierra el formulario de registro
            fmlLogin fmlLogin = new fmlLogin();
            fmlLogin.ShowDialog();       
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btniNGRESAR_Click_1(object sender, EventArgs e)
        {

        }
    }
}
