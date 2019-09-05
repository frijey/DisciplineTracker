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
    public partial class LoadingScreen : Form
    {
        Func<Task<bool>> thisDinamicFunction;

        public LoadingScreen(Func<Task<bool>> FunctionUntilLoad)
        {
            InitializeComponent();
            thisDinamicFunction = FunctionUntilLoad;
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            functionAsyncExcecuter();
        }

        public async Task<bool> functionAsyncExcecuter()
        {
            await thisDinamicFunction();
            this.Close();
            return true;
        }

    }
}
