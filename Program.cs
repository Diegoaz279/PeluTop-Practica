using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PeluTop_Practica
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginForm = new fmlLogin();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Si el login es exitoso, inicia el formulario principal
                Application.Run(new fmlLogin());
            }

        }
    }
}
