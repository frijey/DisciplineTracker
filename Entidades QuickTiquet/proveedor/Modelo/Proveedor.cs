using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Proveedor : Conexion
    {

        public int Sentencia(Proveedor d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaProveedor('{Accion}',?,?,?,?,?,?,?,?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_pro", MySqlDbType.Int32).Value = d.cod_pro;
            cmd.Parameters.Add("prm_nom_pro", MySqlDbType.VarChar).Value = d.nom_pro;
            cmd.Parameters.Add("prm_tip_pro", MySqlDbType.VarChar).Value = d.tip_pro;
            cmd.Parameters.Add("prm_dir_pro", MySqlDbType.VarChar).Value = d.dir_pro;
            cmd.Parameters.Add("prm_sec_pro", MySqlDbType.VarChar).Value = d.sec_pro;
            cmd.Parameters.Add("prm_zon_pro", MySqlDbType.VarChar).Value = d.zon_pro;
            cmd.Parameters.Add("prm_con_pro", MySqlDbType.VarChar).Value = d.con_pro;
            cmd.Parameters.Add("prm_ema_pro", MySqlDbType.VarChar).Value = d.ema_pro;
            cmd.Parameters.Add("prm_rnc_pro", MySqlDbType.VarChar).Value = d.rnc_pro;
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaProveedorPorCod_proOPorNom_pro(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SProveedor(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SProveedor(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

