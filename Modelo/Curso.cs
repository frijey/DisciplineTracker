using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Curso : Conexion
    {

        public int Sentencia(Curso d, string Accion)
        {
            int id = 0;
            using (GetCon())
            {
                MySqlCommand cmd = new MySqlCommand($"SentenciaCurso('{Accion}',?,?,?,?,?,?)", GetCon());
                cmd.Parameters.Add("prm_id_curso", MySqlDbType.Int32).Value = d.id_curso;
                cmd.Parameters.Add("prm_nombre_curso", MySqlDbType.VarChar).Value = d.nombre_curso;
                cmd.Parameters.Add("prm_numeracion", MySqlDbType.Int32).Value = d.numeracion;
                cmd.Parameters.Add("prm_nivel", MySqlDbType.Int32).Value = d.nivel;
                cmd.Parameters.Add("prm_profesor", MySqlDbType.Int32).Value = d.profesor;
                cmd.Parameters.Add("prm_estado", MySqlDbType.VarChar).Value = d.estado;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaCursoPorId_cursoOPorNombre_curso(?)", GetCon());
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
            MySqlCommand cmd = new MySqlCommand("SListaCursoPorSecuenciaDeid_curso(?,?)", GetCon());
            cmd.Parameters.Add("1- prm_tipoSecuencia", MySqlDbType.VarChar).Value = prm_tipoSecuencia;
            cmd.Parameters.Add("2- prm_idActual", MySqlDbType.Int32).Value = prm_idActual;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable SCurso(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SCurso(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

