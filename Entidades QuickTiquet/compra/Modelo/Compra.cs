using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Compra : Conexion
    {

        public int Sentencia(Compra d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaCompra('{Accion}',?,?,?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_com", MySqlDbType.Int32).Value = d.cod_com;
            cmd.Parameters.Add("prm_fec_com", MySqlDbType.Date).Value = d.fec_com;
            cmd.Parameters.AddWithValue($"3-hor_com", d.hor_com);
            cmd.Parameters.Add("prm_tip_com", MySqlDbType.VarChar).Value = d.tip_com;
            cmd.Parameters.Add("prm_fk_cod_pro", MySqlDbType.Int32).Value = d.fk_cod_pro;
            cmd.Parameters.AddWithValue($"6-sub_tot_com", d.sub_tot_com);
            cmd.Parameters.AddWithValue($"7-itb_com", d.itb_com);
            cmd.Parameters.AddWithValue($"8-des_com", d.des_com);
            cmd.Parameters.AddWithValue($"9-tot_com", d.tot_com);
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaCompraPorCod_comOPorFec_com(?)", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaCompraPorSecuenciaDecod_com(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SCompra(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SCompra(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

