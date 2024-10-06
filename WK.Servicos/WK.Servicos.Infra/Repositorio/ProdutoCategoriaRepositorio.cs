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

        public  ProdutoCategoria GetById(int id)
        {
            return _context.Categorias.Find(id);
        }

        public void Add(ProdutoCategoria entity)
        {
            _context.Add(entity);
        }

        public void Update(ProdutoCategoria entity)
        {
            _context.Update(entity);
        }

        public void Delete(int id)
        {
            var item = _context.Categorias.Find(id);

            _context.Remove(item);
           
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context?.Dispose();
        }
    }
}
