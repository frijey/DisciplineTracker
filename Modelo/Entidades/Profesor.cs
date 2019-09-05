using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Profesor
    {
        public int id_profe { get; set; } = 0;
        public string nombre { get; set; } = "";
        public string apellido { get; set; } = "";
        public string email { get; set; } = "";
        public string contacto { get; set; } = "";
        public string imagen { get; set; } = "";
        public string estado { get; set; } = "A";
    }
}
