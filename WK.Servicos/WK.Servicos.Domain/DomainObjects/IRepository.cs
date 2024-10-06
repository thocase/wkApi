using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK.Servicos.Domain.DomainObjects
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        Task<T> GetById(int id);

        void Add(T entity);

        void Update(T entity);

        IUnitOfWork UnitOfWork { get; }
    }
}
