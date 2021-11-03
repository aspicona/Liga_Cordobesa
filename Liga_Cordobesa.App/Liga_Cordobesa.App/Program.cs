using EquipoTP;
using Liga_Cordobesa.App.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liga_Cordobesa.Backend.Acceso_a_datos.Implementaciones;

namespace Liga_Cordobesa.App
{
    static class Program
    {
        public static object UsuarioDao { get; private set; }

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
