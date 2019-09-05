using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Modelo;

namespace Discipline_Tracker
{
    public partial class FormCurso : FormMantBase
    {
        //Clases y Variables
        Modelo.Curso curso = new Modelo.Curso();

        public FormCurso()
        {
            InitializeComponent();
        }

        public bool Guardar()
        {
            try
            {
                //Guardar Curso
                if (tools.ValidarControles(this))
                {
                    curso.id_curso = isNuevoRegistro ? 0 : Convert.ToInt32(txtCodigo.Text);
                    curso.nombre_curso = txtNombre.Text;
                    curso.numeracion = Convert.ToInt32(txtNumeracion.Text);
                    curso.nivel = (int)cmbNivel.SelectedValue;
                    curso.profesor = (int)cmbProfesor.SelectedValue;
                    curso.estado = chkEstado.Checked ? "A" : "I";

                    int id_nuevo_curso = curso.Sentencia(curso, isNuevoRegistro ? "I" : "U");
                    txtCodigo.Text = isNuevoRegistro ? id_nuevo_curso.ToString() : curso.id_curso.ToString();

                    tools.MensajeNormal(this, "Curso guardado con éxito");
                    isNuevoRegistro = false;
                    tools.DeshabilitarControles(this);
                    FormatearBotones(ProcesoBotones.Guardar);
                    return true;
                }
            }
            catch (Exception ex)
            {
                tools.MensajeNormal(ex.Message);
            }
            return false;
        }

        private void ptbListado_Click(object sender, EventArgs e)
        {
            Form f = new FormListadoCursos();
            f.ShowDialog();

            int idEstudianteSeleccionado = (f as FormListadoCursos).SelectedItem;

            if (idEstudianteSeleccionado != 0)
                tools.FuncionLoading(this, async () =>
                {
                    await Task.Delay(100);
                    return await CargarEstudiante(idEstudianteSeleccionado); ;
                });

        }

        public void Modificar()
        {
            FormatearBotones(ProcesoBotones.Modificar);
            tools.HabilitarControles(this);
            txtNombre.Focus();
        }

        private async Task<bool> CargarEstudiante(int idEstudianteACargar)
        {
            //Cargar curso en base a un id...
            try
            {
                string jsonEstudiante = tools.DataTableToJSONWithStringBuilder(curso.SCurso(idEstudianteACargar.ToString()));
                curso = JsonConvert.DeserializeObject<Curso>(jsonEstudiante);

                txtCodigo.Text = curso.id_curso.ToString();
                txtNombre.Text = curso.nombre_curso;
                txtNumeracion.Text = curso.numeracion.ToString();
                cmbNivel.SelectedValue = curso.nivel;
                cmbProfesor.SelectedValue = curso.profesor;
                chkEstado.Checked = curso.estado.ToUpper() == "A" ? true : false;

                isNuevoRegistro = false;
                tools.DeshabilitarControles(this);
                FormatearBotones(ProcesoBotones.CancelarRegistroExistente);

            }
            catch (Exception ex)
            {
                tools.MensajeNormal(ex.Message);
            }
            return true;
        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {

            if (ButtonsStatusActual == ProcesoBotones.Guardar)
                tools.FuncionLoading(this, async () =>
                {
                    await Task.Delay(500);
                    return Guardar();
                });
            else
                Modificar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (isNuevoRegistro)
            {
                tools.LimpiarControles(this);
                tools.DeshabilitarControles(this);
                FormatearBotones(ProcesoBotones.CancelarNuevoRegistro);
            }
            else
            {
                tools.DeshabilitarControles(this);
                FormatearBotones(ProcesoBotones.CancelarRegistroExistente);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevoRegistro = true;
            tools.LimpiarControles(this);
            tools.HabilitarControles(this);
            FormatearBotones(ProcesoBotones.Nuevo);
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tools.MensajeOkCansel($"¿Seguro que desea eliminar el curso #{txtCodigo.Text}?"))
                {
                    curso.id_curso = Convert.ToInt32(txtCodigo.Text);
                    curso.Sentencia(curso, "D");
                    tools.LimpiarControles(this);
                    tools.DeshabilitarControles(this);
                    FormatearBotones(ProcesoBotones.CancelarNuevoRegistro);
                }
            }
            catch (Exception ex)
            {
                tools.MensajeNormal(ex.Message);
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkEstado.Checked)
                chkEstado.Text = "                   Activo                 ";
            else
                chkEstado.Text = "             Desactivado             ";
        }

        private void FormCurso_Load(object sender, EventArgs e)
        {
            CargarComboBoxNiveles();
            CargarComboBoxProfesores();
        }

        public void CargarComboBoxNiveles()
        {
            cmbNivel.ValueMember = "id_nivel";
            cmbNivel.DisplayMember = "descripcion";
            cmbNivel.DataSource = new Nivel().ListadoGeneral();
        }

        public void CargarComboBoxProfesores()
        {
            cmbProfesor.ValueMember = "id_profe";
            cmbProfesor.DisplayMember = "nombre_completo";
            cmbProfesor.DataSource = new Profesor().ListadoGeneral();
        }
    }
}
