using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Usuario
    {
        public required long id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public DateTime ultimo_login { get; set; }
        public int tipo_usuario { get; set; } // 0 - Aluno, 1 - Professor, 2 - Administrador
        public List<Mensagem> disciplinas_contratadas { get; set; };
    }
}
