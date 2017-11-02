using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Recuerda.me
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (File.Exists(C.LckFile)) {
                MessageBox.Show("Ya hay una instancia de Recuerda.me en ejecución. " +
                    "Compruebe la bandeja del sistema.\r\nSi cree que esto no es así, vacíe la " +
                    "carpeta temporal (que puede encontrar en %TEMP%)", "La aplicación está en ejecución",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.Create(C.LckFile);
            AppDomain.CurrentDomain.UnhandledException += UnhandledException;
            Application.ApplicationExit += ApplicationExit;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new Latency();

            bool minimized = false;
            if (args.Length > 0)
                minimized = args[0] == "-m";

            Application.Run(new MainF(minimized));
        }

        static void UnhandledException(object sender, EventArgs e) {
            File.Delete(C.LckFile);
            Application.Exit();
        }

        static void ApplicationExit(object sender, EventArgs e) { File.Delete(C.LckFile); }
    }
}
