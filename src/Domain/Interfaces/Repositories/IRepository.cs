using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        public T Create(T _object);
        public T Delete(T _object);
        public T Update(T _object);
    }
}
