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
    public partial class Loading : Form
    {
        Func<Task<bool>> thisDinamicFunction;

        public Loading(Func<Task<bool>> FunctionUntilLoad)
        {
            InitializeComponent();
            thisDinamicFunction = FunctionUntilLoad;
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Form loadingScr = new LoadingScreen(thisDinamicFunction);
            loadingScr.Size = new Size(100, 100);
            loadingScr.ShowDialog();
            this.Close();
        }
    }
}
