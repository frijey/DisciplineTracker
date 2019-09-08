using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Discipline_Tracker
{

    public enum TiposDeValidacion
    {
        Normal,
        Entero,
        Decimal,
        Email
    }

    public class TextBoxRegular : TextBox
    {
        //Propiedades del Control
        public bool Obligatorio { get; set; } = true;
        public bool Deshabilitar { get; set; } = true;
        public bool Habilitar { get; set; } = true;
        public bool Limpiar { get; set; } = true;
        public string DefaultLimpiarValue { get; set; } = "";
        public ErrorProvider errorProviver;
        public TiposDeValidacion TipoDeValidacion { get; set; } = TiposDeValidacion.Normal;
        public bool CantidadMinima { get; set; } = false;
        public int CantMin { get; set; } = 0;
        public bool FormatoDinero { get; set; } = false;
        public bool TabEnter { get; set; } = true;
        public bool ForceUpperCase { get; set; } = true;
        public Panel statusPanel = new Panel();

        //Variables de uso
        public string LastValidValue = "";
        private string temporalString = "";
        private bool startProvidingError = false;

        //Clase de Herramientas...
        Herramientas tools = new Herramientas();

        public TextBoxRegular()
        {
        }

        public bool Validar()
        {
            startProvidingError = true;
            bool validated = InternalValidation();

            return validated;
        }

        public bool InternalValidation(string t = null, bool validarCaracteres = true)
        {
            if (t is null)
                t = this.Text;

            //Validar si es obligatorio...
            if (Obligatorio && !string.IsNullOrEmpty(t.Trim()))
            {
                //Validar cantidad de caracteres...
                if ((CantidadMinima && t.Length < CantMin) && validarCaracteres)
                {
                    SetError($"Debe colocar un mínimo de {this.CantMin} caracteres");
                    return false;
                }

                //Validar valor del TextBox
                if (TipoDeValidacion == TiposDeValidacion.Normal)
                {
                    return true;
                }
                else if (TipoDeValidacion == TiposDeValidacion.Entero)
                {
                    if (tools.IsEnteroValido(t))
                        return true;
                    else
                    {
                        if (startProvidingError)
                            SetError("Formato incorrecto");

                        return false;
                    }
                }
                else if (TipoDeValidacion == TiposDeValidacion.Decimal)
                {
                    if (tools.IsDoubleValido(t))
                        return true;
                    else
                    {
                        if (startProvidingError)
                            SetError("Formato incorrecto");
                        return false;
                    }
                }
                else if (TipoDeValidacion == TiposDeValidacion.Email)
                {
                    if (EmailValido())
                        return true;
                    else
                    {
                        if (startProvidingError)
                            SetError("Formato de correo incorrecto");
                        return false;
                    }
                }
                else
                {
                    //Error inesperado
                    return true;
                }

            }
            else if (Obligatorio && string.IsNullOrEmpty(t))
            {
                //Es obligatorio y está vacío
                SetError("Este campo es obligatorio");
                return false;
            }
            else
            {
                //No es obligatorio
                return true;
            }
        }

        private bool EmailValido()
        {
            Regex r = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return r.IsMatch(this.Text);
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

        public double GetValue()
        {
            if (TipoDeValidacion == TiposDeValidacion.Entero || TipoDeValidacion == TiposDeValidacion.Decimal)
                return Convert.ToDouble(this.Text);
            else
                return 0;
        }

        public void Clean()
        {
            startProvidingError = false;
            this.Text = DefaultLimpiarValue;
            startProvidingError = false;
        }

        #region Overrides

        protected override void OnCreateControl()
        {
            try
            {
                errorProviver = new ErrorProvider();

                this.BackColor = Parent.BackColor;
                this.ForeColor = SystemColors.WindowFrame;
                this.Font = new Font("Calibri", 10f);
                this.BorderStyle = BorderStyle.None;
                this.Multiline = false;

                if (ForceUpperCase)
                    this.CharacterCasing = CharacterCasing.Upper;
                else
                    this.CharacterCasing = CharacterCasing.Normal;

                statusPanel = new Panel()
                {
                    BackColor = Color.LightBlue,
                    Location = new Point(this.Location.X - 5, this.Location.Y + 18),
                    Size = new Size(this.Width + 5, 1),
                    TabStop = false
                };

                if (this.Visible)
                    Parent.Controls.Add(statusPanel);

            }
            catch { }

            base.OnCreateControl();
            OnEnabledChanged(null);

        }

        protected override void OnTextChanged(EventArgs e)
        {
            //Mantener constancia del último valor válido...
            //Retornar al último valor válido en caso de que se reciba un valor inválido..
            if (FormatoDinero)
            {
                temporalString = this.Text.Replace(Herramientas.moneda, "").Replace(" ", "").Trim();
                if (InternalValidation(temporalString, false))
                {
                    LastValidValue = this.Text;
                    RemoveErrorProvider();
                }
                else
                    this.Text = LastValidValue;
            }
            else
            {
                if (TipoDeValidacion != TiposDeValidacion.Email)
                {
                    if (!string.IsNullOrEmpty(this.Text))
                    {
                        if (InternalValidation(this.Text, false))
                        {
                            LastValidValue = this.Text;
                            RemoveErrorProvider();
                        }
                        else
                            this.Text = LastValidValue;
                    }
                }
                else
                {
                    if (InternalValidation(this.Text, false))
                        RemoveErrorProvider();
                }
            }

            if (startProvidingError)
                InternalValidation();

            base.OnTextChanged(e);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            if ((TipoDeValidacion == TiposDeValidacion.Entero || TipoDeValidacion == TiposDeValidacion.Decimal) && Focused)
                this.Text = GetValue().ToString();

            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {

            if (TipoDeValidacion == TiposDeValidacion.Decimal && !Focused)
            {
                this.Text = tools.FormatoDecimal(this.Text);
            }

            startProvidingError = true;
            //Validar();

            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (TipoDeValidacion == TiposDeValidacion.Entero || TipoDeValidacion == TiposDeValidacion.Decimal)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                    e.Handled = true;

                // only allow one decimal point
                if (e.KeyChar == '.' && TipoDeValidacion == TiposDeValidacion.Decimal)
                {
                    if (!this.Text.Contains(""))
                        e.Handled = false;
                    else
                    {
                        e.Handled = true;
                        this.SelectionStart = this.Text.IndexOf("") + 1;
                    }
                }
                else
                {
                    if (e.KeyChar == '.')
                        e.Handled = true;
                }
            }

            base.OnKeyPress(e);
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

        protected override void OnReadOnlyChanged(EventArgs e)
        {
            CheckControlColor();
            base.OnReadOnlyChanged(e);
        }

        #endregion

        #region Metodos Extra

        private void CheckControlColor()
        {
            //Check the status of the control whether if it's ReadOnly or Enabled false, so fade the color...
            if (this.Enabled)
            {
                if (this.ReadOnly)
                    statusPanel.BackColor = Color.FromArgb(200, 240, 255);
                else
                    statusPanel.BackColor = Color.LightBlue;
            }
            else
                statusPanel.BackColor = Color.LightGray;

        }

        #endregion

    }
}
