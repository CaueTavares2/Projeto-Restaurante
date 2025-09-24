using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteProjeto
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (Login loginForm = new Login())
            {
                // Abrir o Login de forma modal
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Login bem-sucedido, então inicia o Form1
                    Application.Run(new Form1());
                }
            }
        }
    }
}
