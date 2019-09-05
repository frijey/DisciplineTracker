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
    public partial class FormListadoCursos : FormListadoBase
    {

        //Classes
        Modelo.Curso curso = new Modelo.Curso();

        public FormListadoCursos()
        {
            InitializeComponent();
            dgvListado.AutoGenerateColumns = false;
        }

        private void FormListadoClientes_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void Buscar(string parametro = "")
        {
            try
            {
                dgvListado.DataSource = curso.ListadoGeneral(parametro);
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
            this.Close();
        }
    }
}
