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
        {// Guardar las credenciales en las propiedades estáticas
            Credenciale.UsuarioRegistrado = txtUsuarioR.Text;
            Credenciale.ContrasenaRegistrada = txtContraseñaR.Text;

            MessageBox.Show("Usuario Registrado con éxito");

            // Abre el formulario de login y cierra el formulario de registro
            fmlLogin fmlLogin = new fmlLogin();
            fmlLogin.ShowDialog();
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
