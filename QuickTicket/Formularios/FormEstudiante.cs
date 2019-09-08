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
    public partial class FormEstudiante : FormMantBase
    {
        //Clases y Variables
        Modelo.Estudiante estudiante = new Modelo.Estudiante();

        public FormEstudiante()
        {
            InitializeComponent();
        }

        public bool Guardar()
        {
            try
            {
                //Guardar Estudiante
                if (tools.ValidarControles(this))
                {
                    estudiante.id_estudiante = isNuevoRegistro ? 0 : Convert.ToInt32(txtCodigo.Text);
                    estudiante.nombre = txtNombre.Text;
                    estudiante.apellido = txtApellido.Text;
                    estudiante.curso = (int)cmbCurso.SelectedValue;
                    estudiante.estado = chkEstado.Checked ? "A" : "I";

                    int id_nuevo_estudiante = estudiante.Sentencia(estudiante, isNuevoRegistro ? "I" : "U");
                    txtCodigo.Text = isNuevoRegistro ? id_nuevo_estudiante.ToString() : estudiante.id_estudiante.ToString();

                    tools.MensajeNormal(this, "Estudiante guardado con éxito");
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
            Form f = new FormListadoEstudiantes();
            f.ShowDialog();

            int idEstudianteSeleccionado = (f as FormListadoEstudiantes).SelectedItem;

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
            //Cargar estudiante en base a un id...
            try
            {
                string jsonEstudiante = tools.DataTableToJSONWithStringBuilder(estudiante.SEstudiante(idEstudianteACargar.ToString()));
                estudiante = JsonConvert.DeserializeObject<Estudiante>(jsonEstudiante);

                txtCodigo.Text = estudiante.id_estudiante.ToString();
                txtNombre.Text = estudiante.nombre;
                txtApellido.Text = estudiante.apellido;
                cmbCurso.SelectedValue = estudiante.curso;
                chkEstado.Checked = estudiante.estado.ToUpper() == "A" ? true : false;

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
                if (tools.MensajeOkCansel($"¿Seguro que desea eliminar el estudiante #{txtCodigo.Text}?"))
                {
                    estudiante.id_estudiante = Convert.ToInt32(txtCodigo.Text);
                    estudiante.Sentencia(estudiante, "D");
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

        private void FormEstudiante_Load(object sender, EventArgs e)
        {
            CargarComboBoxCursos();
            txtNombre.Focus();
            txtNombre.Select();
        }

        public void CargarComboBoxCursos()
        {
            cmbCurso.ValueMember = "id_curso";
            cmbCurso.DisplayMember = "nombre_curso";
            cmbCurso.DataSource = new Curso().ListadoGeneral();
        }

    }
}
