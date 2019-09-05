using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Articulo : Conexion
    {

        public int Sentencia(Articulo d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaArticulo('{Accion}',?,?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_art", MySqlDbType.Int32).Value = d.cod_art;
            cmd.Parameters.Add("prm_nom_art", MySqlDbType.VarChar).Value = d.nom_art;
            cmd.Parameters.Add("prm_des_art", MySqlDbType.VarChar).Value = d.des_art;
            cmd.Parameters.Add("prm_mar_art", MySqlDbType.VarChar).Value = d.mar_art;
            cmd.Parameters.AddWithValue($"5-cost_art", d.cost_art);
            cmd.Parameters.AddWithValue($"6-prec_art", d.prec_art);
            cmd.Parameters.AddWithValue($"7-exis_art", d.exis_art);
            cmd.Parameters.AddWithValue($"8-cant_min_art", d.cant_min_art);
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaArticuloPorCod_artOPorNom_art(?)", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaArticuloPorSecuenciaDecod_art(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SArticulo(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SArticulo(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

