using System;
using System.Windows.Forms;

namespace AppWinforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmAlumno())
            {
                frm.ShowDialog();
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmCurso())
            {
                frm.ShowDialog();
            }
        }
    }
}
