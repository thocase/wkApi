using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.DomainObjects;
using WK.Servicos.Domain.Entidade.Produto;

namespace WK.Servicos.Domain.Repositorio
{
    public interface IProdutoCategoriaRepositorio : IRepository<ProdutoCategoria>
    {
        Task<IEnumerable<ProdutoCategoria>> Listar();
    }
}
