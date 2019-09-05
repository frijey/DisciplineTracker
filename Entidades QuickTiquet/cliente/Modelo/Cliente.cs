using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Cliente : Conexion
    {

        public int Sentencia(Cliente d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaCliente('{Accion}',?,?,?,?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_cli", MySqlDbType.Int32).Value = d.cod_cli;
            cmd.Parameters.Add("prm_nom_cli", MySqlDbType.VarChar).Value = d.nom_cli;
            cmd.Parameters.Add("prm_ape_cli", MySqlDbType.VarChar).Value = d.ape_cli;
            cmd.Parameters.Add("prm_sex_cli", MySqlDbType.VarChar).Value = d.sex_cli;
            cmd.Parameters.Add("prm_dir_cli", MySqlDbType.VarChar).Value = d.dir_cli;
            cmd.Parameters.Add("prm_sec_cli", MySqlDbType.VarChar).Value = d.sec_cli;
            cmd.Parameters.Add("prm_zon_cli", MySqlDbType.VarChar).Value = d.zon_cli;
            cmd.Parameters.Add("prm_cel_cli", MySqlDbType.VarChar).Value = d.cel_cli;
            cmd.Parameters.Add("prm_ema_cli", MySqlDbType.VarChar).Value = d.ema_cli;
            cmd.Parameters.Add("prm_ced_cli", MySqlDbType.VarChar).Value = d.ced_cli;
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaClientePorCod_cliOPorNom_cli(?)", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaClientePorSecuenciaDecod_cli(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SCliente(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SCliente(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

