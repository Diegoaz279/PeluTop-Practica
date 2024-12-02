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

namespace PeluTop_Practica
{
    public partial class PantallaCargaConf : Form
    {
        public PantallaCargaConf()
        {
            InitializeComponent();
        }
        private async void PantallaCargaConf_Load(object sender, EventArgs e)
        {
            Task<string> task = new Task<string>(Solicitud);
            task.Start();
            string resultado = await task;
            this.Dispose();
        }
        private string Solicitud()
        {
            Thread.Sleep(10000);
            return "Terminada La solicitud";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
