// Zaripov Riyaz 220th group, 24.05.22 Figures-3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryFigures4
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        internal static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_geometryFigures geometryFigures = new form_geometryFigures();
            Application.Run(geometryFigures);
        }
    }
}
