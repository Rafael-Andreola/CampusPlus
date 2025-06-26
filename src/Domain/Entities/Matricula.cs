using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Matricula
    {
        public long id { get; set; }
        public DateTime data { get; set; }
        public long aluno_id { get; set; }
        public long disciplina_cod { get; set; }
        public int status { get; set; } // 0 - Ativo, 1 - Inativo, 2 - Trancado
    }
}
