using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Tag : Conexion
    {

        public int Sentencia(Tag d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaTag('{Accion}',?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_id_tag", MySqlDbType.Int32).Value = d.id_tag;
            cmd.Parameters.Add("prm_tipo", MySqlDbType.Int32).Value = d.tipo;
            cmd.Parameters.Add("prm_sigla", MySqlDbType.VarChar).Value = d.sigla;
            cmd.Parameters.Add("prm_descripcion", MySqlDbType.VarChar).Value = d.descripcion;
            cmd.Parameters.Add("prm_estado", MySqlDbType.VarChar).Value = d.estado;
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaTagPorId_tagOPorTipo(?)", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaTagPorSecuenciaDeid_tag(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable STag(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("STag(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

