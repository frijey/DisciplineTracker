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
    public partial class DetalleDeComportamiento : FormListadoBase
    {

        //Classes
        Tracker tracker = new Tracker();
        private string tipoT;
        private int idCursoT;
        private int idEstudianteT;
        private string fecha_iniT;
        private string fecha_finT;

        public DetalleDeComportamiento(string txtDescripcion, string tipo, int idCurso, int idEstudiante, string fecha_ini, string fecha_fin)
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
            this.tipoT = tipo;
            this.idCursoT = idCurso;
            this.idEstudianteT = idEstudiante;
            this.fecha_iniT = fecha_ini;
            this.fecha_finT = fecha_fin;

            //Ocultar columnas innecesarias
            if (idEstudiante > 0)
            {
                dgvListado.Columns["curso"].Visible = false;
                dgvListado.Columns["estudiante"].Visible = false;
            }
            else if (idCurso > 0)
            {
                dgvListado.Columns["curso"].Visible = false;
            }

            txtBusqueda.Text = txtDescripcion;

        }

        private void FormListadoClientes_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar(string parametro = "")
        {
            try
            {
                //Buscar detalle de medallas
                dgvListado.DataSource = tracker.DetalleTotalDemeritos(tipoT, idCursoT, idEstudianteT, fecha_iniT, fecha_finT);
                lblTotal.Text = $"Registros: {dgvListado.Rows.Count}";
            }
            catch (Exception ex)
            {
                tools.MensajeNormal(ex.Message);
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            Buscar();
            txtBusqueda.Clear();
            txtBusqueda.Focus();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtBusqueda.Text);
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedItem = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo"].Value.ToString());
            Form F = new EditarMedalla(SelectedItem);
            F.ShowDialog();
            if ((F as EditarMedalla).guardado)
            {
                Buscar();
            }
        }
    }
}
