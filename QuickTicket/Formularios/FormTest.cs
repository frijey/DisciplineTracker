using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discipline_Tracker
{
    public partial class FormTest : Form
    {

        Herramientas tools = new Herramientas();

        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            tools.MensajeNormal(this, "SecondTest");

            //tools.FuncionLoading(this, async () =>
            //{
            //    await Task.Delay(1000);
            //    return true;
            //});

        }
    }
}
