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
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        public IUnitOfWork UnitOfWork => _context;

        private readonly WKContext _context;

        public ProdutoRepositorio(WKContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Produto>> Listar()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> GetById(int id)
        {
            return await _context.Produtos.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Add(Produto entity)
        {
            _context.Add(entity);
        }

        public void Update(Produto entity)
        {
            _context.Update(entity);
        }

        public async Task Delete(int id)
        {
            var item = await _context.Produtos.Where(x => x.Id == id).FirstOrDefaultAsync();

            _context.Remove(item);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context?.Dispose();
        }
    }
}
