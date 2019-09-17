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
    public partial class EditarMedalla : Form
    {

        //Objetos Necesarios...
        Tracker_entry tracker_Entry = new Tracker_entry();
        Herramientas tools = new Herramientas();
        public int idTracker_Entryo = 0;
        public int idEstudiante = 0;
        public string fecha = "";
        public int tag = 0;
        public int tipoTag = 0;
        public string comentario = "";
        public TipoTagMedalla tipoTagMedalla = TipoTagMedalla.Celebracion;

        //Para conocer el guardado...
        public bool guardado = false;

        public EditarMedalla(int idTracker_Entry_Extranjero)
        {
            InitializeComponent();

            DataTable dt = tracker_Entry.STracker_entry(idTracker_Entry_Extranjero.ToString());

            tracker_Entry.id_tracker_entry = idTracker_Entry_Extranjero;
            tracker_Entry.id_estudiante = Convert.ToInt32(dt.Rows[0]["id_estudiante"].ToString());
            tracker_Entry.fecha = Convert.ToDateTime(dt.Rows[0]["fecha"].ToString());
            tracker_Entry.tipo_tag = Convert.ToInt32(dt.Rows[0]["tipo_tag"]);
            tracker_Entry.tag = Convert.ToInt32(dt.Rows[0]["tag"]);
            tracker_Entry.comentario = dt.Rows[0]["comentario"].ToString();

            if (tracker_Entry.tipo_tag == 1)
            {

                tipoTagMedalla = TipoTagMedalla.DemeritoDeComportamiento;
            }
            else if (tracker_Entry.tipo_tag == 2)
            {
                tipoTagMedalla = TipoTagMedalla.DemeritoDeOrganizacion;
            }
            else if (tracker_Entry.tipo_tag == 3)
            {
                tipoTagMedalla = TipoTagMedalla.Celebracion;
            }

        }

        private void EditarMedalla_Load(object sender, EventArgs e)
        {

            if (tipoTagMedalla == TipoTagMedalla.DemeritoDeComportamiento)
            {
                lblTitulo.Text = "Editar Demérito de Comportamiento";
                tipoTag = 1;
            }
            else if (tipoTagMedalla == TipoTagMedalla.DemeritoDeOrganizacion)
            {
                lblTitulo.Text = "Editar Demérito de Organización";
                tipoTag = 2;
            }
            else
            {
                lblTitulo.Text = "Editar Celebración";
                tipoTag = 3;
            }

            lblTitulo.Location = new Point((this.Width / 2 - lblTitulo.Width / 2), lblTitulo.Location.Y);
            CargarComboBoxTipoTag(tipoTag);
            cmbTag.SelectedValue = tracker_Entry.tag;
            txtComentario.Text = tracker_Entry.comentario;

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
                tracker_Entry.comentario = txtComentario.Text.Trim();
                tracker_Entry.estado = "A";
                tracker_Entry.Sentencia(tracker_Entry, "U");

                guardado = true;
                this.Close();
            }
            catch (Exception ex)
            {
                new Herramientas().MensajeNormal(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (tools.MensajeOkCancel("¿Seguro que desea eliminar esta anotación?"))
            {
                tracker_Entry.id_estudiante = idEstudiante;
                tracker_Entry.Sentencia(tracker_Entry, "D");
                guardado = true;
                this.Close();
            }
        }
    }
}
