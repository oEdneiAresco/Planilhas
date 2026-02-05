using Aldeia.Mercosul.Planilhas.UI;
using QuestPDF.Infrastructure;
using System;
using QuestPDF.Infrastructure;
using System.Windows.Forms;

namespace Aldeia.Mercosul.Planilhas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmHome());
            QuestPDF.Settings.License = LicenseType.Community;

        }
    }
}
