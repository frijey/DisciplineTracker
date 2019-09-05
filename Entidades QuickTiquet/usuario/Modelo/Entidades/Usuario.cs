using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Usuario
    {
        public int cod_usu { get; set; } = 0;
        public string nom_usu { get; set; } = "";
        public string cla_usu { get; set; } = "";
        public string tip_usu { get; set; } = "";
        public string ema_usu { get; set; } = "";
        public int fk_rol { get; set; } = 0;
    }
}
