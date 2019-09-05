using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Cotizacion : Conexion
    {

        public int Sentencia(Cotizacion d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaCotizacion('{Accion}',?,?,?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_cot", MySqlDbType.Int32).Value = d.cod_cot;
            cmd.Parameters.Add("prm_fec_cot", MySqlDbType.Date).Value = d.fec_cot;
            cmd.Parameters.AddWithValue($"3-hor_cot", d.hor_cot);
            cmd.Parameters.Add("prm_tip_cot", MySqlDbType.VarChar).Value = d.tip_cot;
            cmd.Parameters.Add("prm_fk_cod_cli", MySqlDbType.Int32).Value = d.fk_cod_cli;
            cmd.Parameters.AddWithValue($"6-sub_tot_cot", d.sub_tot_cot);
            cmd.Parameters.AddWithValue($"7-itb_cot", d.itb_cot);
            cmd.Parameters.AddWithValue($"8-des_cot", d.des_cot);
            cmd.Parameters.AddWithValue($"9-tot_cot", d.tot_cot);
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaCotizacionPorCod_cotOPorFec_cot(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListadoPorSecuencia(string prm_tipoSecuencia, string prm_idActual = "0")
        {
            if (!Char.IsDigit(Convert.ToChar(prm_idActual.Substring(prm_idActual.Length - 1, 1))))
            {
                prm_tipoSecuencia = prm_tipoSecuencia == "A" ? "P" : prm_tipoSecuencia == "S" ? "U" : prm_tipoSecuencia;
                prm_idActual = "0";
            }

            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaCotizacionPorSecuenciaDecod_cot(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SCotizacion(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SCotizacion(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

