using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class DisciplinaDTO
    {
        public DisciplinaDTO() { }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int Creditos { get; set; }
        public List<PreRequisitoDTO>? PreRequisitos { get; set; }

    }
}
