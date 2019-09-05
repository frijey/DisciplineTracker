using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discipline_Tracker
{
    class ComboBoxRegular : ComboBox
    {
        //Propiedades del Control
        public bool Obligatorio { get; set; } = true;
        public bool Deshabilitar { get; set; } = true;
        public bool Habilitar { get; set; } = true;
        public bool Limpiar { get; set; } = true;
        public int DefaultLimpiarValue { get; set; } = 0;
        public ErrorProvider errorProviver;
        public bool TabEnter { get; set; } = true;
        public Panel statusPanel = new Panel();

        //Variables de uso
        private bool startProvidingError = false;

        //Clase de Herramientas...
        Herramientas tools = new Herramientas();

        public ComboBoxRegular()
        {
        }

        public bool Validar()
        {
            startProvidingError = true;
            bool validated = InternalValidation();

            return validated;
        }

        public bool InternalValidation()
        {

            //Validar si es obligatorio...
            if (Obligatorio)
            {
                //Validar cantidad de caracteres...
                if (SelectedIndex < 0)
                {
                    SetError("Este campo es obligatorio. Debe seleccionar una opción");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                //No es obligatorio
                return true;
            }
        }

        public void RemoveErrorProvider()
        {
            if (!(errorProviver is null))
                SetError(string.Empty);

        }

        public void SetError(string errorMsg)
        {
            errorProviver.SetError(this, errorMsg);
            errorProviver.SetIconAlignment(this, ErrorIconAlignment.MiddleLeft);
            errorProviver.SetIconPadding(this, 10);

            if (!string.IsNullOrEmpty(errorMsg))
                statusPanel.BackColor = Color.Red;
            else
                CheckControlColor();
        }

        public void Clean()
        {
            startProvidingError = false;
            this.SelectedIndex = DefaultLimpiarValue;
            startProvidingError = false;
        }

        #region Overrides

        protected override void OnCreateControl()
        {
            errorProviver = new ErrorProvider();

            this.BackColor = Parent.BackColor;
            this.ForeColor = SystemColors.WindowFrame;
            this.Font = new Font("Calibri", 10f);
            this.FlatStyle = FlatStyle.Flat;
            this.DropDownStyle = ComboBoxStyle.DropDownList;

            statusPanel = new Panel()
            {
                BackColor = Color.LightBlue,
                Location = new Point(this.Location.X - 5, this.Location.Y + 25),
                Size = new Size(this.Width + 5, 1),
                TabStop = false
            };

            Parent.Controls.Add(statusPanel);

            base.OnCreateControl();

            OnEnabledChanged(null);

        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            //Mantener constancia del último valor válido...
            //Retornar al último valor válido en caso de que se reciba un valor inválido..
            if (InternalValidation())
                RemoveErrorProvider();

            if (startProvidingError)
                InternalValidation();
            base.OnSelectedIndexChanged(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            startProvidingError = true;
            //Validar();
            base.OnLostFocus(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TabEnter)
                SendKeys.Send("{TAB}");

            base.OnKeyDown(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            CheckControlColor();
            base.OnEnabledChanged(e);
        }

        #endregion

        #region Metodos Extra

        private void CheckControlColor()
        {
            //Check the status of the control whether if it's ReadOnly or Enabled false, so fade the color...
            if (this.Enabled)
            {
                statusPanel.BackColor = Color.LightBlue;
            }
            else
                statusPanel.BackColor = Color.LightGray;

        }

        #endregion

    }
}
