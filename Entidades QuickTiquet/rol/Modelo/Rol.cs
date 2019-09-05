using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Rol : Conexion
    {

        public int Sentencia(Rol d, string Accion)
        {
            int id = 0;
                using (GetCon())
            {
            MySqlCommand cmd = new MySqlCommand($"SentenciaRol('{Accion}',?,?)", GetCon());
            cmd.Parameters.Add("prm_cod_rol", MySqlDbType.Int32).Value = d.cod_rol;
            cmd.Parameters.Add("prm_des_rol", MySqlDbType.VarChar).Value = d.des_rol;
            Conectar();
            id = int.Parse(cmd.ExecuteScalar().ToString());
             return id; 
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaRolPorCod_rolOPorDes_rol(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SRol(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SRol(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

