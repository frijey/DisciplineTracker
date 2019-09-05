using MySql.Data.MySqlClient;

namespace Modelo
{
    public class Conexion
    {
        public string Cadena { get; set; }
        public bool ConexionExterna { get; set; } = false;

        MySqlConnection SystemConecction;
        public Conexion()
        {
            Cadena = SFG.Configuracion.CadenaConexion;
            SystemConecction = new MySqlConnection(SFG.Configuracion.CadenaConexion);
        }

        public MySqlConnection GetCon()
        {
            if (ConexionExterna)
                SystemConecction = new MySqlConnection(Cadena);
            return SystemConecction;
        }

        public void Conectar()
        {
            if (SystemConecction.State == System.Data.ConnectionState.Closed)
            {
                SystemConecction.Open();
            }
        }

        public void Desconectar()
        {
            if (SystemConecction.State == System.Data.ConnectionState.Open)
            {
                SystemConecction.Close();
            }
        }
    }
}
