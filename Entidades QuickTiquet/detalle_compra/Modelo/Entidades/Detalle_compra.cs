using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Detalle_compra
    {
        public int fk_cod_com { get; set; } = 0;
        public int fk_cod_art { get; set; } = 0;
        public string nom_det_com { get; set; } = "";
        public double can_det_com { get; set; } = 0.00;
        public double sub_tot_det_com { get; set; } = 0.00;
    }
}
