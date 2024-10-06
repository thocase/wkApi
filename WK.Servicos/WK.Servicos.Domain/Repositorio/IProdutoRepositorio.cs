using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.DomainObjects;
using WK.Servicos.Domain.Entidade.Produto;

namespace WK.Servicos.Domain.Repositorio
{
    public interface IProdutoRepositorio : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> Listar();
    }
}
