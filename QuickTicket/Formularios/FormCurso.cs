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
        Modelo.Profesor profesor = new Modelo.Profesor();

        public FormCurso()
        {
            InitializeComponent();
        }

        public bool Guardar()
        {
            try
            {
                //Guardar Profesor
                if (tools.ValidarControles(this))
                {
                    profesor.id_profe = isNuevoRegistro ? 0 : Convert.ToInt32(txtCodigo.Text);
                    profesor.nombre = txtNombre.Text;
                    profesor.apellido = txtApellido.Text;
                    profesor.email = txtEmail.Text;
                    profesor.contacto = txtContacto.Text;
                    profesor.estado = chkEstado.Checked ? "A" : "I";

                    int id_nuevo_estudiante = profesor.Sentencia(profesor, isNuevoRegistro ? "I" : "U");
                    txtCodigo.Text = isNuevoRegistro ? id_nuevo_estudiante.ToString() : profesor.id_profe.ToString();

                    tools.MensajeNormal(this, "Profesor guardado con éxito");
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
            Form f = new FormListadoProfesores();
            f.ShowDialog();

            int idEstudianteSeleccionado = (f as FormListadoProfesores).SelectedItem;

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
            //Cargar profesor en base a un id...
            try
            {
                string jsonEstudiante = tools.DataTableToJSONWithStringBuilder(profesor.SProfesor(idEstudianteACargar.ToString()));
                profesor = JsonConvert.DeserializeObject<Profesor>(jsonEstudiante);

                txtCodigo.Text = profesor.id_profe.ToString();
                txtNombre.Text = profesor.nombre;
                txtApellido.Text = profesor.apellido;
                txtEmail.Text = profesor.email;
                txtContacto.Text = profesor.contacto;
                chkEstado.Checked = profesor.estado.ToUpper() == "A" ? true : false;

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
                if (tools.MensajeOkCansel($"¿Seguro que desea eliminar el profesor #{txtCodigo.Text}?"))
                {
                    profesor.id_profe = Convert.ToInt32(txtCodigo.Text);
                    profesor.Sentencia(profesor, "D");
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

    }
}
