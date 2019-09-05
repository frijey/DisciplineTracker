using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Factura
    {
        public int cod_fac { get; set; } = 0;
        public DateTime fec_fac { get; set; }
        public string hor_fac { get; set; } = "";
        public string tip_fac { get; set; } = "";
        public int fk_cod_cli_fac { get; set; } = 0;
        public double sub_tot_fac { get; set; } = 0.00;
        public double itb_fac { get; set; } = 0.00;
        public double des_fac { get; set; } = 0.00;
        public double tot_fac { get; set; } = 0.00;
    }
}
