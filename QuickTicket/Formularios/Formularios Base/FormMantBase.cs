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
    public partial class FormMantBase : FormBase
    {

        //Varaibles Globales
        public bool isNuevoRegistro = true;
        public bool isGuardar = true;
        public ProcesoBotones ButtonsStatusActual = ProcesoBotones.Guardar;

        public FormMantBase()
        {
            InitializeComponent();
        }

        private void ClickDown_Effect(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.DimGray;
        }

        private void ClickUp_DesEffect(object sender, MouseEventArgs e)
        {
            (sender as Button).BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormatearBotones(ProcesoBotones tipoDeProceso)
        {
            if (tipoDeProceso == ProcesoBotones.Guardar)
            {
                ButtonsStatusActual = ProcesoBotones.Modificar;

                btnGuardarModificar.Text = "MODIFICAR";
                btnGuardarModificar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGuardarModificar.Enabled = true;

                btnCancelar.Text = "CANCELAR";
                btnCancelar.Enabled = false;

                btnNuevo.Text = "NUEVO";
                btnNuevo.Enabled = true;

                btnEliminar.Text = "ELIMINAR";
                btnEliminar.Enabled = true;

            }
            else if (tipoDeProceso == ProcesoBotones.Modificar)
            {
                ButtonsStatusActual = ProcesoBotones.Guardar;
                btnGuardarModificar.Text = "Guardar";
                btnGuardarModificar.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGuardarModificar.Enabled = true;

                btnCancelar.Text = "CANCELAR";
                btnCancelar.Enabled = true;

                btnNuevo.Text = "NUEVO";
                btnNuevo.Enabled = false;

                btnEliminar.Text = "ELIMINAR";
                btnEliminar.Enabled = false;
            }
            else if (tipoDeProceso == ProcesoBotones.CancelarNuevoRegistro)
            {
                btnGuardarModificar.Text = "Guardar";
                btnGuardarModificar.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGuardarModificar.Enabled = false;

                btnCancelar.Text = "CANCELAR";
                btnCancelar.Enabled = false;

                btnNuevo.Text = "NUEVO";
                btnNuevo.Enabled = true;

                btnEliminar.Text = "ELIMINAR";
                btnEliminar.Enabled = false;
            }
            else if (tipoDeProceso == ProcesoBotones.CancelarRegistroExistente)
            {
                ButtonsStatusActual = ProcesoBotones.Modificar;
                btnGuardarModificar.Text = "MODIFICAR";
                btnGuardarModificar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGuardarModificar.Enabled = true;

                btnCancelar.Text = "CANCELAR";
                btnCancelar.Enabled = false;

                btnNuevo.Text = "NUEVO";
                btnNuevo.Enabled = true;

                btnEliminar.Text = "ELIMINAR";
                btnEliminar.Enabled = true;
            }
            else if (tipoDeProceso == ProcesoBotones.Nuevo)
            {
                ButtonsStatusActual = ProcesoBotones.Guardar;
                btnGuardarModificar.Text = "Guardar";
                btnGuardarModificar.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnGuardarModificar.Enabled = true;

                btnCancelar.Text = "CANCELAR";
                btnCancelar.Enabled = true;

                btnNuevo.Text = "NUEVO";
                btnNuevo.Enabled = false;

                btnEliminar.Text = "ELIMINAR";
                btnEliminar.Enabled = false;
            }
            else
            {
                //Tipo de proceso no controlado...
            }
        }

    }
}
