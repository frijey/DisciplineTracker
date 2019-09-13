using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discipline_Tracker
{
    public class Herramientas
    {
        //Configuración estándar de país
        public static string moneda = "RD$";

        //Variables Necesarias Para el Agrandamiento y Achicamiento
        int desplazamientoHor = 10;
        int desplazamientoVer = 5;
        double multiplicador1 = 22.2;
        double multiplicador2 = 1.115;

        public static int SavedSizeX = 0;
        public static int SavedSizeY = 0;
        public static int SavedLocationX = 0;
        public static int SavedLocationY = 0;

        //Varibles relacionadas con la base de datos
        //string DataSource = "Server=localhost;Port=3306;Database=multimedia;Uid=root;Pwd=zxccxz";
        string DataSource = "Server=localhost;Port=3306;Database=multimedia;Uid=root;Pwd=zxccxz;";


        //Descontinuado y mejorado abajo
        //public void achicarg(Control boton)
        //{
        //    boton.Size = new System.Drawing.Size(360, 104);
        //    boton.Location = new Point(boton.Location.X + desplazamientoHor, boton.Location.Y + desplazamientoVer);
        //}

        //public void agrandarg(Control boton)
        //{
        //    boton.Size = new System.Drawing.Size(400, 116);
        //    boton.Location = new Point(boton.Location.X - desplazamientoHor, boton.Location.Y - desplazamientoVer);
        //}

        public void AchicarDinamico(Control boton)
        {
            SavedSizeX = boton.Size.Width;
            SavedSizeY = boton.Size.Height;
            SavedLocationX = boton.Location.X;
            SavedLocationY = boton.Location.Y;

            int MoveCuantityX = Convert.ToInt32(Math.Round(Convert.ToDouble(SavedSizeX) / 20));
            int MoveCuantityY = Convert.ToInt32(Math.Round(Convert.ToDouble(SavedSizeY) / 20));

            boton.Size = new System.Drawing.Size((Convert.ToInt32(Math.Round(boton.Size.Width * 0.9))), Convert.ToInt32(Math.Round(boton.Size.Height * 0.9)));
            boton.Location = new Point(boton.Location.X + MoveCuantityX, boton.Location.Y + MoveCuantityY);
        }

        public void AgrandarDinamico(Control boton)
        {
            boton.Size = new System.Drawing.Size(SavedSizeX, SavedSizeY);
            boton.Location = new Point(SavedLocationX, SavedLocationY);
        }

        //Descontinuado, mejorado arriba
        //public void achicarp(Control boton)
        //{
        //    boton.Size = new System.Drawing.Size(220, 80);
        //    boton.Location = new Point(boton.Location.X + desplazamientoHor, boton.Location.Y + desplazamientoVer);
        //}

        //public void agrandarp(Control boton)
        //{
        //    boton.Size = new System.Drawing.Size(245, 91);
        //    boton.Location = new Point(boton.Location.X - desplazamientoHor, boton.Location.Y - desplazamientoVer);
        //}

        public string CalcularEdad(DateTime fechaNacimiento)
        {
            try
            {
                if (fechaNacimiento.Month <= DateTime.Now.Month)
                {
                    if (fechaNacimiento.Month == DateTime.Now.Month)
                    {
                        if (fechaNacimiento.Day <= DateTime.Now.Day)
                        {
                            return (DateTime.Now.Year - fechaNacimiento.Year).ToString();
                        }
                        else
                        {
                            return ((DateTime.Now.Year - fechaNacimiento.Year) - (1)).ToString();
                        }
                    }
                    else
                    {
                        return (DateTime.Now.Year - fechaNacimiento.Year).ToString();
                    }
                }
                else
                {
                    return ((DateTime.Now.Year - fechaNacimiento.Year) - (1)).ToString();
                }
            }
            catch (Exception)
            {
                return "0";
            }
        }

        public void CargarFoto(string RutaFoto, PictureBox ptbFoto)
        {
            try
            {
                Bitmap Foto = new Bitmap(RutaFoto);
                ptbFoto.Image = (Image)Foto;
            }
            catch (Exception)
            {
            }
        }

        public string SeleccionarFoto(PictureBox ptbfoto, string rutaFotoActual)
        {
            try
            {
                OpenFileDialog CargarFoto = new OpenFileDialog();
                CargarFoto.Filter = "Archivos de Imagen|*.jpg;*.png";
                CargarFoto.InitialDirectory = "C:\\sonrrisa_sana\\fotos\\pacientes";
                if (CargarFoto.ShowDialog() == DialogResult.OK)
                {
                    String Ruta = CargarFoto.FileName;
                    ptbfoto.SizeMode = PictureBoxSizeMode.Zoom;
                    Bitmap Foto = new Bitmap(Ruta);
                    ptbfoto.Image = (Image)Foto;

                    return Ruta;
                }
                else
                {
                    return rutaFotoActual;
                }
            }
            catch (Exception ex)
            {
                MensajeNormal(ex.Message, "Error en carga de la foto");
                return "Error";
            }
        }

        public void MensajeNormal(string mensaje, string titulo = "Aviso")
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeNormal(Form ParentForm, string mensaje, int widthSize = 200)
        {
            ParentForm.Controls.Add(new Notify(ParentForm, mensaje, widthSize));
        }

        public string FormatearFecha(DateTime fechaDT)
        {
            string fechaform;
            int mes = fechaDT.Month;
            int dia = fechaDT.Day;
            string Ddia = "";
            string Mmes = "";
            string Aaño = fechaDT.Year.ToString();

            //Comprobar que el més o el día sea mayor que 10 para si no agregarle el cero delante
            if (mes < 10) { Mmes = "0" + mes.ToString(); } else { Mmes = mes.ToString(); }
            if (dia < 10) { Ddia = "0" + dia.ToString(); } else { Ddia = dia.ToString(); }
            fechaform = Aaño + "-" + Mmes + "-" + Ddia;

            return fechaform; //Retornar al la llamada del método; la fecha formateada
        }

        public bool MensajeOkCansel(string cuerpo = "¿Seguro que desea continuar?", string titulo = "Aviso")
        {
            bool aceptar = false;

            DialogResult Result = MessageBox.Show(cuerpo, titulo, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Result == DialogResult.OK)
            {
                aceptar = true;
            }

            return aceptar;
        }

        public DataTable OrdenarDeMenorAMayor(DataSet ds)
        {
            string IdCita, IdPaciente, HoraDesde, HoraHasta, Descripcion, Ordenia;
            DataTable dt = ds.Tables[0];

            RepeatBubbleMethod:
            bool NothingIsWorng = true;
            for (int i = 0; i < (ds.Tables[0].Rows.Count - 1); i++)
            {

                //Revisar si el valor siguiente es mayor al actual
                if (Convert.ToInt32(dt.Rows[i][5].ToString()) > Convert.ToInt32(dt.Rows[i + 1][5].ToString()))
                {
                    //Guardar Datos de la fila actual
                    IdCita = dt.Rows[i][0].ToString();
                    IdPaciente = dt.Rows[i][1].ToString();
                    HoraDesde = dt.Rows[i][2].ToString();
                    HoraHasta = dt.Rows[i][3].ToString();
                    Descripcion = dt.Rows[i][4].ToString();
                    Ordenia = dt.Rows[i][5].ToString();

                    //Reemplazar datos de la fila actual con los de la fila siguiente
                    for (int j = 0; j < 6; j++)
                    {
                        dt.Rows[i][j] = dt.Rows[i + 1][j];
                    }

                    //Cargar los datos guardados en la fila siguiente
                    dt.Rows[i + 1][0] = IdCita;
                    dt.Rows[i + 1][1] = IdPaciente;
                    dt.Rows[i + 1][2] = HoraDesde;
                    dt.Rows[i + 1][3] = HoraHasta;
                    dt.Rows[i + 1][4] = Descripcion;
                    dt.Rows[i + 1][5] = Ordenia;

                    //En Resumen: Se guarda la F1, Se pone la F2 en la F1, se carga lo guardado en la F2. [Bubble Method ;)]   
                    NothingIsWorng = false;
                }

            }

            if (!NothingIsWorng)
            {
                goto RepeatBubbleMethod;
            }
            else
            {
                //Normally go Home my Boy :)
            }

            return dt;
        }

        public string GetFEcha(DateTimePicker dtpFEcha)
        {
            string mes = dtpFEcha.Value.Month < 9 ? "0" + dtpFEcha.Value.Month.ToString() : dtpFEcha.Value.Month.ToString();
            string dia = dtpFEcha.Value.Day < 9 ? "0" + dtpFEcha.Value.Day.ToString() : dtpFEcha.Value.Day.ToString();
            return $"{dtpFEcha.Value.Year}-{mes}-{dia}";
        }

        public bool IsEnteroValido(string texto)
        {
            try
            {
                long t = Convert.ToInt64(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool IsNumeroMayorQueCero(string texto)
        {
            try
            {
                double t = Convert.ToInt64(texto);
                if (t > 0)
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        public bool IsDoubleValido(string texto)
        {
            try
            {
                double t = Convert.ToDouble(texto);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string FormatoDinero(string texto)
        {
            try
            {
                double t = Convert.ToDouble(texto);

                //Si el número es mayor que -1 o menor que 1 entonces agregarle el cero delante.. 
                //para que no quede RD$ .25 ()=> RD$ 0.25
                if (t > -1 && t < 1)
                    return $"{moneda} 0{t.ToString("###.###.00")}";
                else return $"{moneda} {t.ToString("###.###.00")}";
            }
            catch
            {
                return "RD$ 0.00";
            }
        }

        public bool IsEmailValido(string emailaddress)
        {
            try
            {
                MailAddress t = new MailAddress(emailaddress);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ValidarControles(Form F)
        {
            //Revisar si los campos están correctamente llenados, devolviendo dicho resultado...
            bool isValid = RevisionDeControlIndependiente(F.Controls);
            return isValid;
        }

        public bool ValidarControles(Panel P)
        {
            //Revisar si los campos están correctamente llenados, devolviendo dicho resultado...
            bool isValid = RevisionDeControlIndependiente(P.Controls);
            return isValid;
        }

        public bool RevisionDeControlIndependiente(Control.ControlCollection Controles)
        {
            bool isValid = true;
            foreach (Control ctrl in Controles)
            {
                if (ctrl is TextBoxRegular)
                {
                    TextBoxRegular myTextBox = ctrl as TextBoxRegular;
                    if (myTextBox.Obligatorio)
                    {
                        isValid = myTextBox.Validar() ? isValid : false;
                    }
                    else if (myTextBox.CantidadMinima)
                    {
                        if (!string.IsNullOrEmpty(myTextBox.Text))
                            isValid = myTextBox.Validar() ? isValid : false;
                    }
                }
                else if (ctrl is MaskedTextBoxRegular)
                {
                    MaskedTextBoxRegular myMaskedTextBox = ctrl as MaskedTextBoxRegular;
                    if (myMaskedTextBox.Obligatorio)
                    {
                        isValid = myMaskedTextBox.Validar() ? isValid : false;
                    }
                    else if (myMaskedTextBox.CantidadMinima)
                    {
                        if (!string.IsNullOrEmpty(myMaskedTextBox.Text))
                            isValid = myMaskedTextBox.Validar() ? isValid : false;
                    }
                }
                else if (ctrl is ComboBoxRegular)
                {
                    ComboBoxRegular myComboBoxRegular = ctrl as ComboBoxRegular;
                    if (myComboBoxRegular.Obligatorio)
                    {
                        isValid = myComboBoxRegular.Validar() ? isValid : false;
                    }
                }
                else if (ctrl is Panel)
                {
                    isValid = ValidarControles(ctrl as Panel) ? isValid : false;
                }
            }
            return isValid;
        }

        public void DeshabilitarControles(Form F)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            DeshabilitarControlesIndependiente(F.Controls);
        }

        public void DeshabilitarControles(Panel P)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            DeshabilitarControlesIndependiente(P.Controls);
        }

        public void DeshabilitarControlesIndependiente(Control.ControlCollection Controles)
        {
            foreach (Control ctrl in Controles)
            {
                if (ctrl is TextBoxRegular)
                {
                    TextBoxRegular myTextBox = ctrl as TextBoxRegular;
                    if (myTextBox.Deshabilitar)
                    {
                        myTextBox.Enabled = false;
                        myTextBox.RemoveErrorProvider();
                    }
                }
                else if (ctrl is MaskedTextBoxRegular)
                {
                    MaskedTextBoxRegular myMaskedTextBox = ctrl as MaskedTextBoxRegular;
                    if (myMaskedTextBox.Deshabilitar)
                    {
                        myMaskedTextBox.Enabled = false;
                        myMaskedTextBox.RemoveErrorProvider();
                    }
                }
                else if (ctrl is ComboBoxRegular)
                {
                    ComboBoxRegular myComboBoxRegular = ctrl as ComboBoxRegular;
                    if (myComboBoxRegular.Deshabilitar)
                    {
                        myComboBoxRegular.Enabled = false;
                        myComboBoxRegular.RemoveErrorProvider();
                    }
                }
                else if (ctrl is CheckBoxEstado)
                {
                    CheckBoxEstado myCheckBoxEstado = ctrl as CheckBoxEstado;
                    if (myCheckBoxEstado.Deshabilitar)
                        myCheckBoxEstado.Enabled = false;
                }
                else if (ctrl is Panel)
                {
                    DeshabilitarControles(ctrl as Panel);
                }
            }
        }

        public void HabilitarControles(Form F)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            HabilitarControlesIndependiente(F.Controls);
        }

        public async Task<bool> HabilitarControlesAsync(Form F)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            HabilitarControlesIndependiente(F.Controls);
            return true;
        }

        public void HabilitarControles(Panel P)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            DeshabilitarControlesIndependiente(P.Controls);
        }

        public void HabilitarControlesIndependiente(Control.ControlCollection Controles)
        {
            foreach (Control ctrl in Controles)
            {
                if (ctrl is TextBoxRegular)
                {
                    TextBoxRegular myTextBox = ctrl as TextBoxRegular;
                    if (myTextBox.Habilitar)
                        myTextBox.Enabled = true;
                }
                else if (ctrl is MaskedTextBoxRegular)
                {
                    MaskedTextBoxRegular myMaskedTextBox = ctrl as MaskedTextBoxRegular;
                    if (myMaskedTextBox.Habilitar)
                        myMaskedTextBox.Enabled = true;
                }
                else if (ctrl is ComboBoxRegular)
                {
                    ComboBoxRegular myComboBoxRegular = ctrl as ComboBoxRegular;
                    if (myComboBoxRegular.Habilitar)
                        myComboBoxRegular.Enabled = true;
                }
                else if (ctrl is CheckBoxEstado)
                {
                    CheckBoxEstado myCheckBoxEstado = ctrl as CheckBoxEstado;
                    if (myCheckBoxEstado.Habilitar)
                        myCheckBoxEstado.Enabled = true;
                }
                else if (ctrl is Panel)
                {
                    HabilitarControles(ctrl as Panel);
                }
            }
        }

        public void LimpiarControles(Form F)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            LimpiarControlesIndependiente(F.Controls);
        }

        public void LimpiarControles(Panel P)
        {
            //Deshabiliar controles en caso de estar marcada la opción...
            LimpiarControlesIndependiente(P.Controls);
        }

        public void LimpiarControlesIndependiente(Control.ControlCollection Controles)
        {
            foreach (Control ctrl in Controles)
            {
                if (ctrl is TextBoxRegular)
                {
                    TextBoxRegular myTextBox = ctrl as TextBoxRegular;
                    if (myTextBox.Limpiar)
                        myTextBox.Clean();
                }
                else if (ctrl is MaskedTextBoxRegular)
                {
                    MaskedTextBoxRegular myMaskedTextBox = ctrl as MaskedTextBoxRegular;
                    if (myMaskedTextBox.Limpiar)
                        myMaskedTextBox.Clean();
                }
                else if (ctrl is ComboBoxRegular)
                {
                    ComboBoxRegular myComboBoxRegular = ctrl as ComboBoxRegular;
                    if (myComboBoxRegular.Limpiar)
                        myComboBoxRegular.Clean();
                }
                else if (ctrl is CheckBoxEstado)
                {
                    CheckBoxEstado myCheckBoxEstado = ctrl as CheckBoxEstado;
                    if (myCheckBoxEstado.Limpiar)
                        myCheckBoxEstado.Checked = !myCheckBoxEstado.DefaultLimpiarValue;
                }
                else if (ctrl is Panel)
                {
                    LimpiarControles(ctrl as Panel);
                }
            }
        }

        public string FormatoDecimal(string texto)
        {
            try
            {
                double d = Convert.ToDouble(texto);
                string s = d.ToString("###,###.00");
                return s;
            }
            catch
            {
                return texto;
            }
        }

        public void FuncionLoading(Form invokerForm, Func<Task<bool>> funcion)
        {
            Form F = new Loading(funcion);
            F.Size = invokerForm.Size;
            F.ShowDialog();
        }

        public string DataTableToJSONWithStringBuilder(DataTable table)
        {
            var JSONString = new StringBuilder();
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    JSONString.Append("{");
                    for (int j = 0; j < table.Columns.Count; j++)
                    {
                        if (j < table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\",");
                        }
                        else if (j == table.Columns.Count - 1)
                        {
                            JSONString.Append("\"" + table.Columns[j].ColumnName.ToString() + "\":" + "\"" + table.Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == table.Rows.Count - 1)
                    {
                        JSONString.Append("}");
                    }
                    else
                    {
                        JSONString.Append("},");
                    }
                }
            }
            return JSONString.ToString();
        }

    }

    //Enumns
    public enum ProcesoBotones
    {
        Guardar,
        Modificar,
        CancelarNuevoRegistro,
        CancelarRegistroExistente,
        Nuevo
    }

    public enum TipoTagMedalla
    {
        DemeritoDeComportamiento,
        DemeritoDeOrganizacion,
        Celebracion
    }

}
