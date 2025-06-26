using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository alunoRepository;

        private readonly IDisciplinaRepository disciplinaRepository;

        public AlunoService(IAlunoRepository _alunoRepository, IDisciplinaRepository _disciplinaRepository)
        {
            alunoRepository = _alunoRepository;
            disciplinaRepository = _disciplinaRepository;
        }

        public bool ContratarDisciplina(string alunoId, long disciplinaId)
        {
            var aluno = this.GetAluno(alunoId);

            var disciplina = disciplinaRepository.Read(disciplinaId);

            if (disciplina != null)
            {
                throw new ArgumentException($"ID da disciplina inválido: {disciplinaId}");
            }

            var matricula = aluno.matriculas.Find(x => x.disciplina_cod == disciplinaId);

            if (matricula != null)
            {
                throw new InvalidOperationException($"Aluno já está matriculado na disciplina com ID {disciplinaId}.");
            }

            matricula = new Matricula
            {
                id = disciplinaId,
                status = 0, // 0 - ativa, 1 - cancelada, 2 - concluída
                data = DateTime.Now,
            };

            aluno.matriculas.Add(matricula);

            return true;
        }

        public Aluno GetAluno(string alunoId)
        {
            return alunoRepository.GetById(alunoId) ?? throw new ArgumentException($"Aluno com ID {alunoId} não encontrado.");
        }
    }
}
