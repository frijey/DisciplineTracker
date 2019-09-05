using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Cotizacion
    {
        public int cod_cot { get; set; } = 0;
        public DateTime fec_cot { get; set; }
        public string hor_cot { get; set; } = "";
        public string tip_cot { get; set; } = "";
        public int fk_cod_cli { get; set; } = 0;
        public double sub_tot_cot { get; set; } = 0.00;
        public double itb_cot { get; set; } = 0.00;
        public double des_cot { get; set; } = 0.00;
        public double tot_cot { get; set; } = 0.00;
    }
}
