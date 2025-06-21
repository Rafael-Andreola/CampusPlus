using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository alunoRepository;
        private readonly IDisciplinaService disciplinaService;
        public AlunoService(IAlunoRepository _alunoRepository, IDisciplinaService _disciplinaService)
        {
            alunoRepository = _alunoRepository;
            disciplinaService = _disciplinaService;
        }

        public bool Contratar(string alunoId, string disciplinaId)
        {
            throw new NotImplementedException();
        }

        public Aluno GetAluno(string alunoId)
        {
            throw new NotImplementedException();
        }
    }
}
