using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IDisciplinaService
    {
        public bool Contratar(Aluno aluno, string disciplinaId);
        public Disciplina GetDisciplina(string disciplinaId);
    }
}
