using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Ingresos : Conexion
    {

        public int Sentencia(Ingresos d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaIngresos('{Accion}',?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_ing", MySqlDbType.Int32).Value = d.cod_ing;
            cmd.Parameters.Add("prm_fk_cod_fac", MySqlDbType.Int32).Value = d.fk_cod_fac;
            cmd.Parameters.AddWithValue($"3-mon_ing", d.mon_ing);
            cmd.Parameters.Add("prm_fec_ing", MySqlDbType.Date).Value = d.fec_ing;
            cmd.Parameters.AddWithValue($"5-hor_ing", d.hor_ing);
            cmd.Parameters.AddWithValue($"6-tot_ing", d.tot_ing);
            cmd.Parameters.AddWithValue($"7-bal_pen_ing", d.bal_pen_ing);
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaIngresosPorCod_ingOPorFk_cod_fac(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SIngresos(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SIngresos(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

