using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.DomainObjects;
using WK.Servicos.Domain.Entidade.Produto;
using WK.Servicos.Domain.Repositorio;
using WK.Servicos.Infra.Data.Context;

namespace WK.Servicos.Infra.Repositorio
{
    public class ProdutoCategoriaRepositorio : IProdutoCategoriaRepositorio
    {

        public IUnitOfWork UnitOfWork => _context;

        private readonly WKContext _context;

        public ProdutoCategoriaRepositorio(WKContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProdutoCategoria>> Listar()
        {
            return await _context.Categorias.ToListAsync();
        }

        public Task<ProdutoCategoria> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(ProdutoCategoria entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ProdutoCategoria entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context?.Dispose();
        }
    }
}
