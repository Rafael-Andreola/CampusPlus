using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class CursoInfoDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Periodos { get; set; }

        public List<DisciplinaDTO> Disciplinas { get; set; }
    }
}
