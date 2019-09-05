using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Curso : Conexion
    {

        public DataTable ListadoGeneral()
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand("GetCursos", GetCon());
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }
    }
}
