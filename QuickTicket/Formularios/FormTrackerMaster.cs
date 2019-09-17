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

        //Datos para Medalla
        string tipo = "";
        int idCurso = 0;
        int idEstudiante = 0;
        string fecha_ini = "";
        string fecha_fin = "";

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
                pnlRadioCuarto.BackColor = Color.LightBlue;

                chkPorSemestre.Checked = false;
                pnlRadioSemestre.BackColor = Color.DarkGray;

                chkTodoElAño.Checked = false;
                pnlRadioAño.BackColor = Color.DarkGray;

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
                pnlRadioSemestre.BackColor = Color.LightBlue;

                chkPorcuarto.Checked = false;
                pnlRadioCuarto.BackColor = Color.DarkGray;

                chkTodoElAño.Checked = false;
                pnlRadioAño.BackColor = Color.DarkGray;

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
                pnlRadioAño.BackColor = Color.LightBlue;

                chkPorSemestre.Checked = false;
                pnlRadioSemestre.BackColor = Color.DarkGray;

                chkPorcuarto.Checked = false;
                pnlRadioCuarto.BackColor = Color.DarkGray;

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
                await Task.Delay(200);

                try
                {

                    //Llenar Datos de Medallas/Tags
                    DataRowView result = cmbPeriodo.SelectedItem as DataRowView;

                    DateTime dtIni = Convert.ToDateTime(result["fecha_desde"].ToString());
                    DateTime dtFin = Convert.ToDateTime(result["fecha_hasta"].ToString());

                    tipo = (int)cmbEstudiante.SelectedValue > 0 ? "E" : ((int)cmbCurso.SelectedValue > 0 ? "C" : "T");
                    idCurso = (int)cmbCurso.SelectedValue;
                    idEstudiante = (int)cmbEstudiante.SelectedValue;
                    fecha_ini = tools.FormatearFecha(dtIni);
                    fecha_fin = tools.FormatearFecha(dtFin);

                    //Buscar y Formatear Meddallas...
                    DataTable totalMedallas = tracker.ListadoTotalDemeritos(tipo, idCurso, idEstudiante, fecha_ini, fecha_fin);

                    double totalMComportamiento = Convert.ToDouble(totalMedallas.Rows[0][0].ToString());
                    double totalMOrganizacion = Convert.ToDouble(totalMedallas.Rows[0][1].ToString());
                    double totalMCelebracion = Convert.ToDouble(totalMedallas.Rows[0][2].ToString());

                    txtTotalComp.Text = totalMComportamiento.ToString();
                    txtTotalOrg.Text = totalMOrganizacion.ToString();
                    txtTotalCelebraciones.Text = totalMCelebracion.ToString();

                    btnVerDetalle.Enabled = totalMComportamiento + totalMOrganizacion + totalMCelebracion > 0 ? true : false;

                    HabilitarDeshabilitarControlesMedalla((int)cmbEstudiante.SelectedValue > 0 ? true : false);

                    //Llenar Datos del Estudiante en los Labels...
                    DataTable student = new Estudiante().SEstudiante(cmbEstudiante.SelectedValue.ToString());

                    if ((int)cmbEstudiante.SelectedValue > 0)
                        lblCurso.Text = new Curso().SCurso(student.Rows[0]["curso"].ToString()).Rows[0]["nombre_curso"].ToString();
                    else
                        lblCurso.Text = cmbCurso.Text;

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
            pnlEditMedallas.Visible = estado;

            dtFechaNuevaMedalla.Enabled = estado;

            btnAgregarDemComp.Enabled = estado;
            ptbComp.Enabled = estado;

            btnAgregarDemOrg.Enabled = estado;
            ptbOrg.Enabled = estado;

            btnAgregarCelebracion.Enabled = estado;
            ptbCele.Enabled = estado;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string descripciónBusqueda = "";

            //Ocultar columnas innecesarias
            if (idEstudiante > 0)
            {
                descripciónBusqueda = lblNombreEstudiante.Text + " - " + lblCurso.Text;
            }
            else if (idCurso > 0)
            {
                descripciónBusqueda = lblCurso.Text;
            }
            else
            {
                descripciónBusqueda = "Busqueda General";
            }

            Form F = new DetalleDeComportamiento(descripciónBusqueda, tipo, idCurso, idEstudiante, fecha_ini, fecha_fin);
            F.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form F = new ListadoEstudiantesMedallas();
            F.ShowDialog();
        }
    }
}
