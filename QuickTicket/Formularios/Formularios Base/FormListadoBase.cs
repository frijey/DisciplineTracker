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
    public partial class FormListadoBase : FormBase
    {
        //Propiedades
        public int SelectedItem { get; set; } = 0;

        public FormListadoBase()
        {
            InitializeComponent();
        }

        private void FormListadoBase_Load(object sender, EventArgs e)
        {
            txtBusqueda.Focus();
        }
    }
}
