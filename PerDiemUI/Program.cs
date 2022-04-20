using System.Globalization;

namespace PerDiemUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            ApplicationConfiguration.Initialize();
            Application.Run(new CalculatorForm());
        }
    }
}