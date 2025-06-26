using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class DisciplinaDTO
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public int creditos { get; set; }
        public List<PreRequisitoDTO>? PreRequisitos { get; set; }
    }
}
