using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Factura : Conexion
    {

        public int Sentencia(Factura d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaFactura('{Accion}',?,?,?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_fac", MySqlDbType.Int32).Value = d.cod_fac;
            cmd.Parameters.Add("prm_fec_fac", MySqlDbType.Date).Value = d.fec_fac;
            cmd.Parameters.AddWithValue($"3-hor_fac", d.hor_fac);
            cmd.Parameters.Add("prm_tip_fac", MySqlDbType.VarChar).Value = d.tip_fac;
            cmd.Parameters.Add("prm_fk_cod_cli_fac", MySqlDbType.Int32).Value = d.fk_cod_cli_fac;
            cmd.Parameters.AddWithValue($"6-sub_tot_fac", d.sub_tot_fac);
            cmd.Parameters.AddWithValue($"7-itb_fac", d.itb_fac);
            cmd.Parameters.AddWithValue($"8-des_fac", d.des_fac);
            cmd.Parameters.AddWithValue($"9-tot_fac", d.tot_fac);
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaFacturaPorCod_facOPorFec_fac(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SFactura(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SFactura(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

