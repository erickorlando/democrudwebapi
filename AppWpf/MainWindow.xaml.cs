using System.Windows;

namespace AppWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Style = (Style) FindResource(typeof(Window));
        }

        private void BtnAlumnos_OnClick(object sender, RoutedEventArgs e)
        {
            var frm = new WindowAlumno();
            frm.ShowDialog();
        }

        private void BtnCursos_OnClick(object sender, RoutedEventArgs e)
        {
            var frm = new WindowCurso();
            frm.ShowDialog();
        }
    }
}
