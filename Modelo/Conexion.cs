using MySql;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {

        //public string stringDeConecxion { get; set; } = "datasource=localhost;port=3306;username=root;password=zxccxz;database=facturacion;";
        public string stringDeConecxion { get; set; } = "Server=localhost;Port=3306;Database=dtracker;Uid=root;Pwd=zxccxz;";
        public MySqlConnection miConexion = new MySqlConnection();

        public Conexion(string nuevoStringDeConexxion = null)
        {
            miConexion = new MySqlConnection(stringDeConecxion);
        }

        public MySqlConnection GetCon()
        {
            return miConexion;
        }

        public void Conect()
        {
            if (miConexion.State == System.Data.ConnectionState.Closed)
            {
                miConexion.Open();
            }
        }

        public void Dissconect()
        {
            if (miConexion.State == System.Data.ConnectionState.Open)
            {
                miConexion.Close();
            }
        }

    }
}
