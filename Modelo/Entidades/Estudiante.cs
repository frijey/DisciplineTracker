using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Estudiante
    {
        public int id_estudiante { get; set; } = 0;
        public string nombre { get; set; } = "";
        public string apellido { get; set; } = "";
        public int curso { get; set; } = 0;
        public string estado { get; set; } = "";
    }

    //public class EntidadCliente
    //{
    //    public string cod_cli { get; set; }
    //    public string nom_cli { get; set; }
    //    public string ape_cli { get; set; }
    //    public string sex_cli { get; set; }
    //    public string dir_cli { get; set; }
    //    public string sec_cli { get; set; }
    //    public string zon_cli { get; set; }
    //    public string cel_cli { get; set; }
    //    public string ema_cli { get; set; }
    //    public string ced_cli { get; set; }
    //}

}
