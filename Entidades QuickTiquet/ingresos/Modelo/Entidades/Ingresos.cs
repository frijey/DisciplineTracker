using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Ingresos
    {
        public int cod_ing { get; set; } = 0;
        public int fk_cod_fac { get; set; } = 0;
        public double mon_ing { get; set; } = 0.00;
        public DateTime fec_ing { get; set; }
        public string hor_ing { get; set; } = "";
        public double tot_ing { get; set; } = 0.00;
        public double bal_pen_ing { get; set; } = 0.00;
    }
}
