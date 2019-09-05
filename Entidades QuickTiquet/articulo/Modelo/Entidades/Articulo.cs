using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Articulo
    {
        public int cod_art { get; set; } = 0;
        public string nom_art { get; set; } = "";
        public string des_art { get; set; } = "";
        public string mar_art { get; set; } = "";
        public double cost_art { get; set; } = 0.00;
        public double prec_art { get; set; } = 0.00;
        public double exis_art { get; set; } = 0.00;
        public double cant_min_art { get; set; } = 0.00;
    }
}
