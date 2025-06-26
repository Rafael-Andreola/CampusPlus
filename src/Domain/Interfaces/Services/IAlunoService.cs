using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IAlunoService
    {
        /// <summary>
        /// Contrata um aluno para uma disciplina.
        /// </summary>
        /// <param name="alunoId">ID do aluno.</param>
        /// <param name="disciplinaId">ID da disciplina.</param>
        /// <returns>True se a contratação for bem-sucedida, caso contrário, false.</returns>
        bool ContratarDisciplina(string alunoId, long disciplinaId);

        /// <summary>
        /// Obtém os detalhes de um aluno.
        /// </summary>
        /// <param name="alunoId">ID do aluno.</param>
        /// <returns>Detalhes do aluno.</returns>
        public Aluno GetAluno(string alunoId);
    }
}
