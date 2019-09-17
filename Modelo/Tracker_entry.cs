using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Tracker_entry : Conexion
    {

        public int Sentencia(Tracker_entry d, string Accion)
        {
            int id = 0;
            using (GetCon())
            {
                MySqlCommand cmd = new MySqlCommand($"SentenciaTracker_entry('{Accion}',?,?,?,?,?,?,?)", GetCon());
                cmd.Parameters.Add("prm_id_tracker_entry", MySqlDbType.Int32).Value = d.id_tracker_entry;
                cmd.Parameters.Add("prm_id_estudiante", MySqlDbType.Int32).Value = d.id_estudiante;
                cmd.Parameters.Add("prm_fecha", MySqlDbType.Date).Value = d.fecha;
                cmd.Parameters.Add("prm_tipo_tag", MySqlDbType.Int32).Value = d.tipo_tag;
                cmd.Parameters.Add("prm_tag", MySqlDbType.Int32).Value = d.tag;
                cmd.Parameters.Add("prm_comentario", MySqlDbType.VarChar).Value = d.comentario;
                cmd.Parameters.Add("prm_estado", MySqlDbType.VarChar).Value = d.estado;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaTracker_entryPorId_tracker_entryOPorId_tracker(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListaCuartos()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("ListaCuartos()", GetCon());
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListadoEstudiantesMedallas()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("ListadoEstudiantesMedallas()", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaTracker_entryPorSecuenciaDeid_tracker_entry(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable STracker_entry(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("STracker_entry(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

