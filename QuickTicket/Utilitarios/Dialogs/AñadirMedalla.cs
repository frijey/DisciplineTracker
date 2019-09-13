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
    public partial class AñadirMedalla : Form
    {

        //Objetos Necesarios...
        Tracker_entry tracker_Entry = new Tracker_entry();
        public int idEstudiante = 0;
        public string fecha = "";
        public int tag = 0;
        public int tipoTag = 0;
        public string comentario = "";
        public TipoTagMedalla tipoTagMedalla = TipoTagMedalla.Celebracion;

        //Para conocer el guardado...
        public bool guardado = false;

        public AñadirMedalla(int idEstudianteExtranjero, string fechaExtranjera, TipoTagMedalla tipoTagMedallaExtranjero)
        {
            InitializeComponent();
            idEstudiante = idEstudianteExtranjero;
            fecha = fechaExtranjera;
            tipoTagMedalla = tipoTagMedallaExtranjero;
        }

        private void AñadirMedalla_Load(object sender, EventArgs e)
        {

            if (tipoTagMedalla == TipoTagMedalla.DemeritoDeComportamiento)
            {
                lblTitulo.Text = "Añadir Demérito de Comportamiento";
                tipoTag = 1;
            }
            else if (tipoTagMedalla == TipoTagMedalla.DemeritoDeOrganizacion)
            {
                lblTitulo.Text = "Añadir Demérito de Organización";
                tipoTag = 2;
            }
            else
            {
                lblTitulo.Text = "Añadir Celebración";
                tipoTag = 3;
            }

            lblTitulo.Location = new Point((this.Width / 2 - lblTitulo.Width / 2), lblTitulo.Location.Y);
            CargarComboBoxTipoTag(tipoTag);

        }

        public void CargarComboBoxTipoTag(int tipo_tag)
        {
            cmbTag.ValueMember = "id_tag";
            cmbTag.DisplayMember = "descripcion";
            cmbTag.DataSource = new Tag().ListadoParaComboPorTipoTag(tipo_tag);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            guardado = false;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Guardar y Cerrar

                tracker_Entry.id_estudiante = idEstudiante;
                tracker_Entry.fecha = Convert.ToDateTime(fecha);
                tracker_Entry.tipo_tag = tipoTag;
                tracker_Entry.tag = (int)cmbTag.SelectedValue;
                tracker_Entry.comentario = txtComentario.Text.Trim();
                tracker_Entry.estado = "A";

                tracker_Entry.Sentencia(tracker_Entry, "I");

                guardado = true;
                this.Close();
            }
            catch (Exception ex)
            {
                new Herramientas().MensajeNormal(ex.Message);
            }
        }
    }
}
