using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Nivel : Conexion
    {

        public int Sentencia(Nivel d, string Accion)
        {
            int id = 0;
            using (GetCon())
            {
                MySqlCommand cmd = new MySqlCommand($"SentenciaNivel('{Accion}',?,?,?)", GetCon());
                cmd.Parameters.Add("prm_id_nivel", MySqlDbType.Int32).Value = d.id_nivel;
                cmd.Parameters.Add("prm_descripcion", MySqlDbType.VarChar).Value = d.descripcion;
                cmd.Parameters.Add("prm_estado", MySqlDbType.VarChar).Value = d.estado;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaNivelPorId_nivelOPorDescripcion(?)", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaNivelPorSecuenciaDeid_nivel(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SNivel(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SNivel(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

