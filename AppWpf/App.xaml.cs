using System.Globalization;
using System.Windows;

namespace AppWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("es-PE");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-PE");
        }
    }
}
