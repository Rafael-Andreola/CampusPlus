using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class DisciplinaService : IDisciplinaService
    {
        private IDisciplinaRepository repository;

        public DisciplinaService(IDisciplinaRepository _repository)
        {
            repository = _repository;
        }

        public bool Contratar(Aluno aluno, string disciplinaId)
        {
            return true;
        }

        public Disciplina GetDisciplina(string disciplinaId)
        {
            return repository.Read(disciplinaId);
        }
    }
}
