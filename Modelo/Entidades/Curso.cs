using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    public partial class Curso
    {
        public int id_curso { get; set; }
        public string nombre_curso { get; set; }
        public int numeracion { get; set; }
        public int nivel { get; set; }
        public int profesor { get; set; }
        public string estado { get; set; }
    }
}
