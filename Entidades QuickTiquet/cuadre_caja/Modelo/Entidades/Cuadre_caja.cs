using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Cuadre_caja
    {
        public int cod_cua_caj { get; set; } = 0;
        public int fk_usu_cua_caj { get; set; } = 0;
        public DateTime fec_cua_caj { get; set; }
        public string hor_cua_caj { get; set; } = "";
        public double tot_cua_caj { get; set; } = 0.00;
    }
}
