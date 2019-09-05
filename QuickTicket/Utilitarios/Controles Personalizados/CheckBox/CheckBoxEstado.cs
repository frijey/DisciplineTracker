using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discipline_Tracker
{
    class CheckBoxEstado : CheckBox
    {
        //Propiedades del Control
        public bool Obligatorio { get; set; } = true;
        public bool Deshabilitar { get; set; } = true;
        public bool Habilitar { get; set; } = true;
        public bool Limpiar { get; set; } = true;
        public bool DefaultLimpiarValue { get; set; } = true;
        public bool TabEnter { get; set; } = true;
        public Panel statusPanel = new Panel();

        protected override ControlCollection CreateControlsInstance()
        {
            try
            {
                this.Appearance = System.Windows.Forms.Appearance.Button;
                this.AutoSize = true;
                this.BackColor = Parent.BackColor;
                this.FlatAppearance.BorderSize = 0;
                this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                this.ForeColor = System.Drawing.Color.Black;
                this.Text = "                   Activo                 ";
                this.UseVisualStyleBackColor = false;
                this.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);

                statusPanel = new Panel()
                {
                    BackColor = Color.LightBlue,
                    Location = new Point(this.Location.X, this.Location.Y + 23),
                    Size = new Size(this.Width, 1),
                    TabStop = false
                };

                Parent.Controls.Add(statusPanel);

            }
            catch { }

            return base.CreateControlsInstance();
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.Checked)
                this.Text = "                   Activo                 ";
            else
                this.Text = "             Desactivado             ";
        }
    }
}
