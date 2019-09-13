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

        //Objetos necesarios
        Tracker tracker = new Tracker();
        DataTable cursos = new DataTable();

        public FormTrackerMaster()
        {
            InitializeComponent();
        }

        private void FormTrackerMaster_Load(object sender, EventArgs e)
        {
            CargarComboBoxCursos();
            CargarComboBoxEstudiantes(0);
            chkPorCuarto_CheckedChanged(null, null);
            cmbCurso.Focus();
            cmbCurso.Select();
            dtFechaNuevaMedalla.Value = DateTime.Now;
            HabilitarDeshabilitarControlesMedalla(false);
        }

        public void CargarComboBoxCursos()
        {
            cmbCurso.ValueMember = "id_curso";
            cmbCurso.DisplayMember = "nombre_curso";
            cursos = new Curso().ListadoGeneral();
            cmbCurso.DataSource = cursos;
        }

        public void CargarComboBoxEstudiantes(int curso)
        {
            cmbEstudiante.ValueMember = "id_estudiante";
            cmbEstudiante.DisplayMember = "nombre";
            cmbEstudiante.DataSource = new Estudiante().ListadoDeEstudiantesParaCombo(curso);

            if (cmbEstudiante.Items.Count < 1)
                cmbEstudiante.Enabled = false;
            else
                cmbEstudiante.Enabled = true;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboBoxEstudiantes((int)cmbCurso.SelectedValue);
        }

        private void chkPorCuarto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPorcuarto.Checked)
            {
                chkPorSemestre.Checked = false;
                chkTodoElAño.Checked = false;

                //Add Items Cuarto
                cmbPeriodo.ValueMember = "idcuarto";
                cmbPeriodo.DisplayMember = "descripcion";
                cmbPeriodo.DataSource = tracker.ListadoPeriodo();
                cmbPeriodo.SelectedIndex = 0;
            }
        }

        private void chkPorSemestre_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPorSemestre.Checked)
            {
                chkPorcuarto.Checked = false;
                chkTodoElAño.Checked = false;

                //Add Items Semestre
                temporalDt = tracker.ListadoPeriodo();
                baseDt = temporalDt.Clone();
                baseDt.Clear();

                newDataRow = baseDt.NewRow();
                newDataRow["idcuarto"] = "1";
                newDataRow["descripcion"] = "Primer Semestre";
                newDataRow["fecha_desde"] = temporalDt.Rows[0]["fecha_desde"];
                newDataRow["fecha_hasta"] = temporalDt.Rows[1]["fecha_hasta"];

                baseDt.Rows.Add(newDataRow);

                newDataRow = baseDt.NewRow();
                newDataRow["idcuarto"] = "2";
                newDataRow["descripcion"] = "Segundo Semestre";
                newDataRow["fecha_desde"] = temporalDt.Rows[2]["fecha_desde"];
                newDataRow["fecha_hasta"] = temporalDt.Rows[3]["fecha_hasta"];

                baseDt.Rows.Add(newDataRow);


                cmbPeriodo.ValueMember = "idcuarto";
                cmbPeriodo.DisplayMember = "descripcion";
                cmbPeriodo.DataSource = baseDt;
                cmbPeriodo.SelectedIndex = 0;

            }
        }

        private void chkTodoElAño_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodoElAño.Checked)
            {
                chkPorSemestre.Checked = false;
                chkPorcuarto.Checked = false;

                //Add items Año Escolar
                temporalDt = tracker.ListadoPeriodo();
                baseDt = temporalDt.Clone();
                baseDt.Clear();

                newDataRow = baseDt.NewRow();
                newDataRow["idcuarto"] = "1";
                newDataRow["descripcion"] = "Todo el año escolar...";
                newDataRow["fecha_desde"] = temporalDt.Rows[0]["fecha_desde"];
                newDataRow["fecha_hasta"] = temporalDt.Rows[3]["fecha_hasta"];

                baseDt.Rows.Add(newDataRow);

                cmbPeriodo.ValueMember = "idcuarto";
                cmbPeriodo.DisplayMember = "descripcion";
                cmbPeriodo.DataSource = baseDt;
                cmbPeriodo.SelectedIndex = 0;
            }
        }

        private void btnProcesarclicked(object sender, EventArgs e)
        {
            tools.FuncionLoading(this, async () =>
            {
                await Task.Delay(1000);

                try
                {

                    //Llenar Datos de Medallas/Tags
                    DataRowView result = cmbPeriodo.SelectedItem as DataRowView;

                    DateTime dtIni = Convert.ToDateTime(result["fecha_desde"].ToString());
                    DateTime dtFin = Convert.ToDateTime(result["fecha_hasta"].ToString());

                    string tipo = (int)cmbEstudiante.SelectedValue > 0 ? "E" : ((int)cmbCurso.SelectedValue > 0 ? "C" : "T");
                    int idCurso = (int)cmbCurso.SelectedValue;
                    int idEstudiante = (int)cmbEstudiante.SelectedValue;
                    string fecha_ini = tools.FormatearFecha(dtIni);
                    string fecha_fin = tools.FormatearFecha(dtFin);

                    //Buscar y Formatear Meddallas...
                    DataTable totalMedallas = tracker.ListadoTotalDemeritos(tipo, idCurso, idEstudiante, fecha_ini, fecha_fin);
                    txtTotalComp.Text = totalMedallas.Rows[0][0].ToString();
                    txtTotalOrg.Text = totalMedallas.Rows[0][1].ToString();
                    txtTotalCelebraciones.Text = totalMedallas.Rows[0][2].ToString();

                    HabilitarDeshabilitarControlesMedalla((int)cmbEstudiante.SelectedValue > 0 ? true : false);

                    //Llenar Datos del Estudiante en los Labels...
                    DataTable student = new Estudiante().SEstudiante(cmbEstudiante.SelectedValue.ToString());
                    lblCurso.Text = new Curso().SCurso(student.Rows[0]["curso"].ToString()).Rows[0]["nombre_curso"].ToString();
                    lblNombreEstudiante.Text = student.Rows[0]["nombre"].ToString() + " " + student.Rows[0]["apellido"].ToString();

                }
                catch (Exception ex)
                {
                    tools.MensajeNormal(ex.Message);
                }

                return true;
            });

        }

        public void HabilitarDeshabilitarControlesMedalla(bool estado)
        {
            dtFechaNuevaMedalla.Enabled = estado;
            btnAgregarDemComp.Enabled = estado;
            btnAgregarDemOrg.Enabled = estado;
            btnAgregarCelebracion.Enabled = estado;
        }

        private void btnAgregarDemComp_Click(object sender, EventArgs e)
        {
            AgregarMedalla(TipoTagMedalla.DemeritoDeComportamiento);
        }

        public void AgregarMedalla(TipoTagMedalla tipoDeMedalla)
        {
            Form F = new AñadirMedalla((int)cmbEstudiante.SelectedValue, tools.FormatearFecha(dtFechaNuevaMedalla.Value), tipoDeMedalla);
            F.ShowDialog();

            if ((F as AñadirMedalla).guardado)
                btnProcesarclicked(null, null);

        }

        private void btnAgregarDemOrg_Click(object sender, EventArgs e)
        {
            AgregarMedalla(TipoTagMedalla.DemeritoDeOrganizacion);
        }

        private void btnAgregarCelebracion_Click(object sender, EventArgs e)
        {
            AgregarMedalla(TipoTagMedalla.Celebracion);
        }
    }
}
