using Controles;
using Bases;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFG
{
    public partial class FrmMantenimientoDetalle_cuadre_caja : Bases.MantenimientoBase
    {
        public FrmMantenimientoDetalle_cuadre_caja()
        {
            InitializeComponent();
        }

        Modelo.Detalle_cuadre_caja Detalle_cuadre_caja = new Detalle_cuadre_caja();

                protected override void MantenimientoAutomatico(Object sender, EventArgs e)
                {
                    if (!Tools.LlenarEntidadDesdeControlesPersonalizados(this, tabPageRegistro, Detalle_cuadre_caja).Item2)
                    {
                        if (Nuevo)
                        {
                            Sentencia = Detalle_cuadre_caja.Sentencia(Detalle_cuadre_caja, "I");
                            if (Sentencia.Item2)
                            {
                                txtd1fk_cua_caj.Text = Sentencia.Item1.ToString();
                            }
                        }
                        else
                        {
                            Sentencia = Detalle_cuadre_caja.Sentencia(Detalle_cuadre_caja, "U");
                        }
        
                        if (Sentencia.Item2)
                        {
                            Nuevo = false;
                            ActivarYDesactivarBotonesPorGrupo("1", true);
                            DeshabilitarEdición();
                            btnModificar.Focus();
                            BuscarPor();
                        }
                    }
                }
        
                protected override void Eliminar(Object sender, EventArgs e)
                {
                    if (Nuevo)
                    { }
                    else
                    {
                        if (Tools.MsgPregunta("¿Seguro que desea eliminar el registro actual?", "Eliminar Registro"))
                        {
                            Detalle_cuadre_caja.fk_cua_caj = Convert.ToInt32(txtd1fk_cua_caj.Text);
                            Sentencia = Detalle_cuadre_caja.Sentencia(Detalle_cuadre_caja, "D");
        
                            if (Sentencia.Item2)
                            {
                                Nuevoregistro();
                                ActivarYDesactivarBotonesPorGrupo("1", true);
                                DeshabilitarEdición();
                                BuscarPor();
                            }
                        }
                    }
        
                }

        private void FrmMantenimientoDetalle_cuadre_caja_Load(object sender, EventArgs e)
        {
            PrimerControlEdicion = txtd2fk_cod_fac;
            UltimoControlEdicion = txtd5tot_det_cua_caj;
            ControlTextBoxDeBusqueda = txtParametro;
            dataGridViewNormal2.AutoGenerateColumns = false;
/*dataGridViewNormal2.AutoGenerateColumns = false;*/
            /*AddControlInitialize*/
            /*ControlTextBoxDeBusqueda = ControlTextBoxDeBusqueda = txtParametro*/
            ;
            
            
            MostrarTodo();
/*AddEventsOnLoad*/
        }

        private void txtd5tot_det_cua_caj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 9)
            {
                e.Handled = false;
                btnGrabar.Select();
            }
            else
            {
            }
        }

        private void txtd5tot_det_cua_caj_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        
        private void textBoxSecundarioCustom1_TextChanged(object sender, EventArgs e)
        {
            BuscarPor();
        }

        private void txtParametro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (dataGridViewNormal2.Rows.Count > 0)
                {
                    dataGridViewNormal2.Focus();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                CargarDesdeElGrid();
                btnModificar.Focus();
            }
        }

        private void dataGridViewNormal2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarDesdeElGrid();
        }

        private void dataGridViewNormal2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.Handled = true;
                    CargarDesdeElGrid();
                }
                else if (e.KeyCode == Keys.Up && dataGridViewNormal2.CurrentRow.Index == 0)
                {
                    e.Handled = true;
                    ControlTextBoxDeBusqueda.Focus();
                }
            }
            catch
            {
            }
        }

                public void BuscarPor()
        {

            if (txtParametro.Text == "")
            {
                MostrarTodo();
            }
            else
            {
                try { dataGridViewNormal2.DataSource = Detalle_cuadre_caja.ListadoGeneral(txtParametro.Text.Trim()); } catch (Exception exc) { MessageBox.Show(exc.Message); }
                lblCantidad.Text = "Items: " + dataGridViewNormal2.Rows.Count.ToString();
            }
        }

        public void CargarDesdeElGrid()
        {
            if (dataGridViewNormal2.SelectedRows.Count == 1)
            {
                CargarRegistro(dataGridViewNormal2.CurrentRow.Cells[0].Value.ToString());
            }
        }

        public void MostrarTodo(object sender = null, EventArgs e = null)
        {
            try
            {
                dataGridViewNormal2.DataSource = Detalle_cuadre_caja.ListadoGeneral();
                lblCantidad.Text = "Items: " + dataGridViewNormal2.Rows.Count.ToString();
                ControlTextBoxDeBusqueda.Text = "";
                ControlTextBoxDeBusqueda.Focus();
            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void tabPageListado_Enter(object sender, EventArgs e)
        {
            txtParametro.Select();
        }
        public void CargarRegistro(string prm_id)
        {
            DeshabilitarEdición();
            ActivarYDesactivarBotonesPorGrupo("1", true);
            btnModificar.Focus();
            DataTable DT = Detalle_cuadre_caja.SDetalle_cuadre_caja(prm_id);
            Tools.LlenarControlesPersonalizadosDesdeDataTable(this.tabPageRegistro, DT); /*Llenar los controles personalizados desde una tabla
            Nota: Para que este procedimiento funcione es necesario que la propiedad [id] del control sea la misma que el nombre...
            ...de la columna en la base de datos...*/            
            Nuevo = false;
            tabControlPrincipal.SelectedIndex = 0;
            btnModificar.Focus();
        }/*AddMethodsHere*/

    }
}
