using DataTransferObjects.Dto;
using Logica;
using System;
using System.Windows;
using System.Windows.Input;

namespace AppWpf
{
    /// <summary>
    /// Interaction logic for WindowAlumno.xaml
    /// </summary>
    public partial class WindowAlumno
    {
        private readonly AlumnoClass _alumnoClass;
        private AlumnoDto _alumno;
        public WindowAlumno()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            _alumnoClass = new AlumnoClass();
            ListViewAlumnos.MouseDoubleClick += (s, e) => BtnEditar_OnClick(this, new RoutedEventArgs());
        }

        private void BtnListar_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;

                ListViewAlumnos.ItemsSource = _alumnoClass.GetAllAlumnos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void BtnNuevo_OnClick(object sender, RoutedEventArgs e)
        {
            _alumno = new AlumnoDto();
            GridControles.DataContext = _alumno;
            TxtNombres.Focus();
        }

        private void BtnEditar_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;

                if (!(ListViewAlumnos.SelectedItem is AlumnoDto seleccionado)) return;

                _alumno = _alumnoClass.GetAlumno(seleccionado.Id);
                GridControles.DataContext = _alumno;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void BtnGrabar_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;
                _alumnoClass.Grabar(_alumno);

                MessageBox.Show(@"Registro guardado correctamente", Title, MessageBoxButton.OK, MessageBoxImage.Information);
                BtnNuevo.RaiseEvent(e);
                BtnListar.RaiseEvent(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void BtnEliminar_OnClick(object sender, RoutedEventArgs e)
        {

            try
            {
                Cursor = Cursors.Wait;
                if (!(ListViewAlumnos.SelectedItem is AlumnoDto seleccionado)) return;

                _alumnoClass.Eliminar(seleccionado.Id);

                BtnListar_OnClick(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Title, MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }
    }
}
