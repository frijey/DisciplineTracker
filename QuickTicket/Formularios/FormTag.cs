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
    public partial class FormTag : FormMantBase
    {
        //Clases y Variables
        Modelo.Tag tag = new Modelo.Tag();

        public FormTag()
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
                    tag.id_tag = isNuevoRegistro ? 0 : Convert.ToInt32(txtCodigo.Text);
                    tag.sigla = txtSiglas.Text;
                    tag.descripcion = txtDescripcion.Text;
                    tag.tipo = (int)cmbTipoTag.SelectedValue;
                    tag.estado = chkEstado.Checked ? "A" : "I";

                    int id_nuevo_curso = tag.Sentencia(tag, isNuevoRegistro ? "I" : "U");
                    txtCodigo.Text = isNuevoRegistro ? id_nuevo_curso.ToString() : tag.id_tag.ToString();

                    tools.MensajeNormal(this, "Tag guardado con éxito");
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
            Form f = new FormListadoTags();
            f.ShowDialog();

            int idTagSeleccionado = (f as FormListadoTags).SelectedItem;

            if (idTagSeleccionado != 0)
                tools.FuncionLoading(this, async () =>
                {
                    await Task.Delay(100);
                    return await CargarTag(idTagSeleccionado); ;
                });

        }

        public void Modificar()
        {
            FormatearBotones(ProcesoBotones.Modificar);
            tools.HabilitarControles(this);
            txtSiglas.Focus();
        }

        private async Task<bool> CargarTag(int idEstudianteACargar)
        {
            //Cargar curso en base a un id...
            try
            {
                string jsonEstudiante = tools.DataTableToJSONWithStringBuilder(tag.STag(idEstudianteACargar.ToString()));
                tag = JsonConvert.DeserializeObject<Tag>(jsonEstudiante);

                txtCodigo.Text = tag.id_tag.ToString();
                txtSiglas.Text = tag.sigla;
                txtDescripcion.Text = tag.descripcion;
                cmbTipoTag.SelectedValue = tag.tipo;
                chkEstado.Checked = tag.estado.ToUpper() == "A" ? true : false;

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
            txtSiglas.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tools.MensajeOkCancel($"¿Seguro que desea eliminar el tag #{txtCodigo.Text}?"))
                {
                    tag.id_tag = Convert.ToInt32(txtCodigo.Text);
                    tag.Sentencia(tag, "D");
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
            CargarComboBoxTipoTag();
            txtSiglas.Focus();
            txtSiglas.Select();
        }

        public void CargarComboBoxTipoTag()
        {
            cmbTipoTag.ValueMember = "id_tipo_tag";
            cmbTipoTag.DisplayMember = "descripcion";
            cmbTipoTag.DataSource = new Tipo_tag().ListadoGeneral();
        }

    }
}
