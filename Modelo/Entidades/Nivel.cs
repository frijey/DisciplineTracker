using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Nivel
    {
        public int id_nivel { get; set; } = 0;
        public string descripcion { get; set; } = "";
        public string estado { get; set; } = "A";
    }
}
