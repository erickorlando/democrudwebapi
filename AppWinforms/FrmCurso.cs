using DataTransferObjects.Dto;
using Logica;
using System;
using System.Windows.Forms;

namespace AppWinforms
{
    public partial class FrmCurso : Form
    {
        private readonly CursoClass _cursoClass;
        private CursoDto _curso;
        public FrmCurso()
        {
            InitializeComponent();
            _cursoClass = new CursoClass();

            // Si se hace doble click sobre el registro en la grilla que se ejecute el metodo de Edición
            cursoDtoDataGridView.CellDoubleClick += (s, e) => btnEditar.PerformClick();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                listaCursosBindingSource.DataSource = _cursoClass.GetAllCursos();
                listaCursosBindingSource.ResetBindings(false);
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
            _curso = new CursoDto();
            cursoDtoBindingSource.DataSource = _curso;
            cursoDtoBindingSource.ResetBindings(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                Cursor = Cursors.WaitCursor;

                if (!(listaCursosBindingSource.Current is CursoDto seleccionado)) return;

                _curso = _cursoClass.GetCurso(seleccionado.Id);
                cursoDtoBindingSource.DataSource = _curso;
                cursoDtoBindingSource.ResetBindings(false);
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

                cursoDtoBindingSource.EndEdit();

                _cursoClass.Grabar(_curso);

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

                if (!(listaCursosBindingSource.Current is CursoDto seleccionado)) return;

                _cursoClass.Eliminar(seleccionado.Id);

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
