using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Detalle_cuadre_caja : Conexion
    {

        public int Sentencia(Detalle_cuadre_caja d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaDetalle_cuadre_caja('{Accion}',?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_fk_cua_caj", MySqlDbType.Int32).Value = d.fk_cua_caj;
            cmd.Parameters.Add("prm_fk_cod_fac", MySqlDbType.Int32).Value = d.fk_cod_fac;
            cmd.Parameters.Add("prm_fec_det_cua_caj", MySqlDbType.Date).Value = d.fec_det_cua_caj;
            cmd.Parameters.AddWithValue($"4-hor_det_cua_caj", d.hor_det_cua_caj);
            cmd.Parameters.AddWithValue($"5-tot_det_cua_caj", d.tot_det_cua_caj);
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaDetalle_cuadre_cajaPorFk_cua_cajOPorFk_cod_fac(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SDetalle_cuadre_caja(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SDetalle_cuadre_caja(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

