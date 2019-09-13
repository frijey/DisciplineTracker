using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public partial class Estudiante : Conexion
    {

        public int Sentencia(Estudiante d, string Accion)
        {
            int id = 0;
            using (GetCon())
            {
                //MySqlCommand cmd = new MySqlCommand($"SentenciaCliente('{Accion}',?,?,?,?,?,?,?,?,?,?)", GetCon());
                MySqlCommand cmd = new MySqlCommand($"SentenciaEstudiante", GetCon());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("accion", MySqlDbType.VarChar).Value = Accion;
                cmd.Parameters.Add("prm_id_estudiante", MySqlDbType.Int32).Value = d.id_estudiante;
                cmd.Parameters.Add("prm_nombre", MySqlDbType.VarChar).Value = d.nombre;
                cmd.Parameters.Add("prm_apellido", MySqlDbType.VarChar).Value = d.apellido;
                cmd.Parameters.Add("prm_curso", MySqlDbType.VarChar).Value = d.curso;
                cmd.Parameters.Add("prm_estado", MySqlDbType.VarChar).Value = d.estado;
                Conect();
                id = int.Parse(cmd.ExecuteScalar().ToString());
                return id;
            }
        }
        public DataTable ListadoGeneral(string prm_parametro = "")
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SListaEstudiantesPorNombreCodOApellido(?)", GetCon());
            cmd.Parameters.Add("1- prm_parametro", MySqlDbType.VarChar).Value = "%" + prm_parametro + "%";
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListadoDeEstudiantesPorCurso(int prm_id_curso = 0)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("EstudiantesPorCurso(?)", GetCon());
            cmd.Parameters.Add("1- prm_id_curso", MySqlDbType.Int32).Value = prm_id_curso;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
        public DataTable ListadoDeEstudiantesParaCombo(int prm_id_curso = 0)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("ListaEstudiantesParaComboTracker(?)", GetCon());
            cmd.Parameters.Add("1- prm_id_curso", MySqlDbType.Int32).Value = prm_id_curso;
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
        public DataTable SEstudiante(string prm_id)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("SEstudiante(?)", GetCon());
            cmd.Parameters.Add("1- prm_id", MySqlDbType.Int32).Value = prm_id;
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        /*AddMethodsHere*/

    }
}

