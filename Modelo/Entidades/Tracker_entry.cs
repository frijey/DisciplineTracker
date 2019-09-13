using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Tracker_entry
    {
        public int id_tracker_entry { get; set; } = 0;
        public int id_estudiante { get; set; } = 0;
        public DateTime fecha { get; set; }
        public int tag { get; set; } = 0;
        public string comentario { get; set; } = "";
        public string estado { get; set; } = "A";
    }
}
