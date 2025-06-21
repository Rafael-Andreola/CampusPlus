using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IAlunoRepository: IRepository<Aluno>
    {
        public Aluno GetById(string id);
    }
}
