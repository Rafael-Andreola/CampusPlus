using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Curso
    {
        public required long id { get; set; }
        public string nome { get; set; }
        public int periodos { get; set; } // Ex: "2023.1", "2023.2"
    }
}
