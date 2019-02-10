using Logica;
using System;
using System.Windows.Forms;

namespace AppWinforms
{
    public partial class FrmAlumno : Form
    {
        private readonly AlumnoClass _alumnoClass;
        public FrmAlumno()
        {
            InitializeComponent();
            _alumnoClass = new AlumnoClass();
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
    }
}
