using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Cuenta_por_cobrar
    {
        public int fk_cod_cli { get; set; } = 0;
        public int fk_cod_fac { get; set; } = 0;
        public double bal_cue_por_cob { get; set; } = 0.00;
        public string obs_cue_por_cob { get; set; } = "";
    }
}
