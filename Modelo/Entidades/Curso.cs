using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public partial class Curso
    {
        public int id_curso { get; set; } = 0;
        public string nombre_curso { get; set; } = "";
        public int numeracion { get; set; } = 0;
        public int nivel { get; set; } = 0;
        public int profesor { get; set; } = 0;
        public string estado { get; set; } = "A";
    }
}
