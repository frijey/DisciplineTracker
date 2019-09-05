using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Tag
    {
        public int id_tag { get; set; } = 0;
        public int tipo { get; set; } = 0;
        public string sigla { get; set; } = "";
        public string descripcion { get; set; } = "";
        public string estado { get; set; } = "A";
    }
}
