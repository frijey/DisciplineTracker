using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discipline_Tracker
{
    public partial class FormTrackerMaster : FormBase
    {
        public FormTrackerMaster()
        {
            InitializeComponent();
        }

        private void FormTrackerMaster_Load(object sender, EventArgs e)
        {
            CargarComboBoxCursos();
            CargarComboBoxEstudiantes(0);
        }

        public void CargarComboBoxCursos()
        {
            cmbCurso.ValueMember = "id_curso";
            cmbCurso.DisplayMember = "nombre_curso";
            cmbCurso.DataSource = new Curso().ListadoGeneral();
        }

        public void CargarComboBoxEstudiantes(int curso)
        {
            cmbEstudiante.ValueMember = "id_estudiante";
            cmbEstudiante.DisplayMember = "nombre";
            cmbEstudiante.DataSource = new Estudiante().ListadoDeEstudiantesPorCurso(curso);

            if (cmbEstudiante.Items.Count < 1)
                cmbEstudiante.Enabled = false;
            else
                cmbEstudiante.Enabled = true;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBoxEstudiantes((int)cmbCurso.SelectedValue);
        }
    }
}
