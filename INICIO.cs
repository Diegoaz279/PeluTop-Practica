﻿using System;
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
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
            
        }

        private void BtnCancelarCita_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Seguro que Quieres Cancerlar la Cita");
          
        }
    }
}
