using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IDisciplinaRepository : IRepository<Disciplina>
    {
        public Disciplina Read(long id);

    }
}
