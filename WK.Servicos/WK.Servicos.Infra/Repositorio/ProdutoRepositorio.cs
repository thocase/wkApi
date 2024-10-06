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

        public Produto GetById(int id)
        {
            return  _context.Produtos.Find(id);
        }

        public void Add(Produto entity)
        {
            _context.Add(entity);
        }

        public void Update(Produto entity)
        {
            _context.Update(entity);
        }

        public void Delete(int id)
        {
            try
            {
                var item =  _context.Produtos.Find(id);

                _context.Produtos.Remove(item);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            _context?.Dispose();
        }
    }
}
