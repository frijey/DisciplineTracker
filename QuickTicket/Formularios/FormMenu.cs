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
    public partial class FormMenu : FormBase
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F = new FormEstudiante();
            F.Show();
        }

        private void ClickDown_Effect(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.Gray;

        }

        private void ClickUp_DesEffect(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
        }

        private void btnCotizacion_Click(object sender, EventArgs e)
        {
            Form F = new FormTrackerMaster();
            F.ShowDialog();
        }

        private void btnProfesoresClick(object sender, EventArgs e)
        {
            Form F = new FormProfesor();
            F.ShowDialog();
        }

        private void btnEstudiantesClick(object sender, EventArgs e)
        {
            Form F = new FormEstudiante();
            F.ShowDialog();
        }

        private void btnTagsClick(object sender, EventArgs e)
        {
            Form F = new FormTag();
            F.ShowDialog();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCursosClick(object sender, EventArgs e)
        {
            Form F = new FormCurso();
            F.ShowDialog();
        }
    }
}
