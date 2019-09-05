using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Detalle_cuadre_caja
    {
        public int fk_cua_caj { get; set; } = 0;
        public int fk_cod_fac { get; set; } = 0;
        public DateTime fec_det_cua_caj { get; set; }
        public string hor_det_cua_caj { get; set; } = "";
        public double tot_det_cua_caj { get; set; } = 0.00;
    }
}
