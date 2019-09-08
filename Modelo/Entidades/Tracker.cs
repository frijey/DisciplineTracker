using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Tracker
    {
        public int id_tracker { get; set; } = 0;
        public int id_estudiante { get; set; } = 0;
        public DateTime fecha_desde { get; set; }
        public DateTime fecha_hasta { get; set; }
        public double total_dem_comp { get; set; } = 0.00;
        public double total_dem_org { get; set; } = 0.00;
        public double total_celebraciones { get; set; } = 0.00;
        public string estado { get; set; } = "A";
    }
}
