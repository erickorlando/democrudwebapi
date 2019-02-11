using DataTransferObjects.Dto;
using Logica;
using System;
using System.Windows;
using System.Windows.Input;

namespace AppWpf
{
    /// <summary>
    /// Interaction logic for WindowCurso.xaml
    /// </summary>
    public partial class WindowCurso
    {
        private readonly CursoClass _cursoClass;
        private CursoDto _curso;
        public WindowCurso()
        {
            InitializeComponent();
            Style = (Style)FindResource(typeof(Window));
            _cursoClass = new CursoClass();
            ListViewCursos.MouseDoubleClick += (s, e) => BtnEditar_OnClick(this, new RoutedEventArgs());
        }

        private void BtnListar_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;

                ListViewCursos.ItemsSource = _cursoClass.GetAllCursos();

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
            _curso = new CursoDto();
            GridControles.DataContext = _curso;
            TxtNombres.Focus();
        }

        private void BtnEditar_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Cursor = Cursors.Wait;

                if (!(ListViewCursos.SelectedItem is CursoDto seleccionado)) return;

                _curso = _cursoClass.GetCurso(seleccionado.Id);
                GridControles.DataContext = _curso;

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
                _cursoClass.Grabar(_curso);

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
                if (!(ListViewCursos.SelectedItem is CursoDto seleccionado)) return;

                _cursoClass.Eliminar(seleccionado.Id);

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
