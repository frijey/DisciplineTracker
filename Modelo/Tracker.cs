using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Tracker : Conexion
    {

        public int Sentencia(Tracker d, string Accion)
        {
            int id = 0;
            using (GetCon())
            {
                MySqlCommand cmd = new MySqlCommand($"SentenciaTracker('{Accion}',?,?,?,?,?,?,?,?)", GetCon());
                cmd.Parameters.Add("prm_id_tracker", MySqlDbType.Int32).Value = d.id_tracker;
                cmd.Parameters.Add("prm_id_estudiante", MySqlDbType.Int32).Value = d.id_estudiante;
                cmd.Parameters.Add("prm_fecha_desde", MySqlDbType.Date).Value = d.fecha_desde;
                cmd.Parameters.Add("prm_fecha_hasta", MySqlDbType.Date).Value = d.fecha_hasta;
                cmd.Parameters.AddWithValue($"5-total_dem_comp", d.total_dem_comp);
                cmd.Parameters.AddWithValue($"6-total_dem_org", d.total_dem_org);
                cmd.Parameters.AddWithValue($"7-total_celebraciones", d.total_celebraciones);
                cmd.Parameters.Add("prm_estado", MySqlDbType.VarChar).Value = d.estado;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaTrackerPorId_trackerOPorId_estudiante(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListadoPeriodo()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("ListaPeriodos()", GetCon());
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListadoTotalDemeritos(string tipo, int prm_id_curso, int prm_id_estudiante, string prm_fecha_ini, string prm_fecha_fin)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("TotalDemeritos(?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("1- tipo", MySqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("2- prm_id_curso", MySqlDbType.VarChar).Value = prm_id_curso;
            cmd.Parameters.Add("3- prm_id_estudiante", MySqlDbType.VarChar).Value = prm_id_estudiante;
            cmd.Parameters.Add("4- prm_fecha_ini", MySqlDbType.VarChar).Value = prm_fecha_ini;
            cmd.Parameters.Add("5- prm_fecha_fin", MySqlDbType.VarChar).Value = prm_fecha_fin;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable DetalleTotalDemeritos(string tipo, int prm_id_curso, int prm_id_estudiante, string prm_fecha_ini, string prm_fecha_fin)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("DetalleTotalDemeritos(?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("1- tipo", MySqlDbType.VarChar).Value = tipo;
            cmd.Parameters.Add("2- prm_id_curso", MySqlDbType.VarChar).Value = prm_id_curso;
            cmd.Parameters.Add("3- prm_id_estudiante", MySqlDbType.VarChar).Value = prm_id_estudiante;
            cmd.Parameters.Add("4- prm_fecha_ini", MySqlDbType.VarChar).Value = prm_fecha_ini;
            cmd.Parameters.Add("5- prm_fecha_fin", MySqlDbType.VarChar).Value = prm_fecha_fin;
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
            MySqlCommand cmd = new MySqlCommand("SListaTrackerPorSecuenciaDeid_tracker(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable STracker(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("STracker(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

