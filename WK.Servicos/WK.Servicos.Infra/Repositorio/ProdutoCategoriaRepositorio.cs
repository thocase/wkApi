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

        public async Task<ProdutoCategoria> GetById(int id)
        {
            return await _context.Categorias.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public void Add(ProdutoCategoria entity)
        {
            _context.Add(entity);
        }

        public void Update(ProdutoCategoria entity)
        {
            _context.Update(entity);
        }

        public async Task Delete(int id)
        {
            var item = await _context.Categorias.Where(x => x.Id == id).FirstOrDefaultAsync();

            _context.Remove(item);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context?.Dispose();
        }
    }
}
