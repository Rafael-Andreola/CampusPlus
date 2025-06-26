using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aluno
    {
        public long id { get; set; }
        public List<Matricula> matriculas { get; set; }
        public long curso_id { get; set; }
        public int status_matricula { get; set; } // 0 - aberta, 1 - fechada, 3 - Trancado
    }
}
