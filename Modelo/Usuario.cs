using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Usuario : Conexion
    {

        public int Sentencia(Usuario d, string Accion)
        {
            int id = 0;
            using (GetCon())
            {
                MySqlCommand cmd = new MySqlCommand($"SentenciaUsuario('{Accion}',?,?,?,?,?,?)", GetCon());
                cmd.Parameters.Add("prm_cod_usu", MySqlDbType.Int32).Value = d.cod_usu;
                cmd.Parameters.Add("prm_nom_usu", MySqlDbType.VarChar).Value = d.nom_usu;
                cmd.Parameters.Add("prm_cla_usu", MySqlDbType.VarChar).Value = d.cla_usu;
                cmd.Parameters.Add("prm_tip_usu", MySqlDbType.VarChar).Value = d.tip_usu;
                cmd.Parameters.Add("prm_ema_usu", MySqlDbType.VarChar).Value = d.ema_usu;
                cmd.Parameters.Add("prm_fk_rol", MySqlDbType.Int32).Value = d.fk_rol;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
        }

        public bool IniciarSesion(string usuario, string contraseña)
        {
            int id = 0;
            using (GetCon())
            {
                MySqlCommand cmd = new MySqlCommand($"IniciarSesion", GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("prm_usuario", MySqlDbType.VarChar).Value = usuario;
                cmd.Parameters.Add("prm_contraseña", MySqlDbType.VarChar).Value = contraseña;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id == 1 ? true : false;
            }
        }

        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaUsuarioPorCod_usuOPorNom_usu(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SUsuario(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SUsuario(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

