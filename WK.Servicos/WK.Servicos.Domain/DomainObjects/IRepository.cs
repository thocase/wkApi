using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK.Servicos.Domain.DomainObjects
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        T GetById(int id);

        void Add(T entity);

        void Update(T entity);
        void Delete(int id);

        IUnitOfWork UnitOfWork { get; }
    }
}
