using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Compra
    {
        public int cod_com { get; set; } = 0;
        public DateTime fec_com { get; set; }
        public string hor_com { get; set; } = "";
        public string tip_com { get; set; } = "";
        public int fk_cod_pro { get; set; } = 0;
        public double sub_tot_com { get; set; } = 0.00;
        public double itb_com { get; set; } = 0.00;
        public double des_com { get; set; } = 0.00;
        public double tot_com { get; set; } = 0.00;
    }
}
