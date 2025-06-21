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

        public Disciplina GetDisciplina(string disciplinaId)
        {
            return repository.Read(disciplinaId);
        }
    }
}
