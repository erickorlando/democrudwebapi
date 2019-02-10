using DataTransferObjects.Dto;
using Logica;
using System;
using System.Windows.Forms;

namespace AppWinforms
{
    public partial class FrmAlumno : Form
    {
        private readonly AlumnoClass _alumnoClass;
        private AlumnoDto _alumno;
        public FrmAlumno()
        {
            InitializeComponent();
            _alumnoClass = new AlumnoClass();

            // Si se hace doble click sobre el registro en la grilla que se ejecute el metodo de Edición
            alumnoDataGridView.CellDoubleClick += (s, e) => btnEditar.PerformClick();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                listadoAlumnosBindingSource.DataSource = _alumnoClass.GetAllAlumnos();
                listadoAlumnosBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _alumno = new AlumnoDto();
            alumnoBindingSource.DataSource = _alumno;
            alumnoBindingSource.ResetBindings(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;

                if (!(listadoAlumnosBindingSource.Current is AlumnoDto seleccionado)) return;

                _alumno = _alumnoClass.GetAlumno(seleccionado.Id);
                alumnoBindingSource.DataSource = _alumno;
                alumnoBindingSource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;

                alumnoBindingSource.EndEdit();

                _alumnoClass.Grabar(_alumno);

                MessageBox.Show(@"Registro guardado correctamente", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;

                if (!(listadoAlumnosBindingSource.Current is AlumnoDto seleccionado)) return;

                _alumnoClass.Eliminar(seleccionado.Id);

                btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
