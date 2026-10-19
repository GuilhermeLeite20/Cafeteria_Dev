using System.Globalization;

namespace CafeteriaDev
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR");

            ApplicationConfiguration.Initialize();
            Application.Run(new Views.FrmSplash());
        }
    }
}
