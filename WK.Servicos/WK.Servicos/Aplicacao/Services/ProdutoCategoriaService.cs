using Microsoft.AspNetCore.Mvc;
using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Domain.Entidade.Produto;
using WK.Servicos.Domain.Repositorio;
using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Aplicacao.Services
{
    public class ProdutoCategoriaService : IProdutoCategoriaService
    {

        private readonly IProdutoCategoriaRepositorio _produtoCategoriaRepositorio;

        public ProdutoCategoriaService(IProdutoCategoriaRepositorio produtoCategoriaRepositorio)
        {
            _produtoCategoriaRepositorio = produtoCategoriaRepositorio;
        }

        public async Task<List<ProdutoCategoriaDTO>> ListarProdutoCategoria()
        {
            var envio = await _produtoCategoriaRepositorio.Listar();

            return envio.Select(x => new ProdutoCategoriaDTO { Id = x.Id, Descricao = x.descricao, Nome = x.nome_categoria }).ToList();
        }

        public async Task<ProdutoCategoriaDTO> ObterPorId(int id)
        {
            var envio = await _produtoCategoriaRepositorio.GetById(id);

            return new ProdutoCategoriaDTO { Id = envio.Id, Descricao = envio.descricao, Nome = envio.nome_categoria };
        }

        public void Adicionar(ProdutoCategoriaDTO categoriaDTO)
        {
            var entity = new ProdutoCategoria { descricao = categoriaDTO.Descricao, nome_categoria = categoriaDTO.Nome };

            _produtoCategoriaRepositorio.Add(entity);

        }

        public void Atualizar(ProdutoCategoriaDTO categoriaDTO)
        {
            var entity = new ProdutoCategoria { descricao = categoriaDTO.Descricao, nome_categoria = categoriaDTO.Nome };

            _produtoCategoriaRepositorio.Update(entity);

        }

        public void Delete(int id)
        {
            _produtoCategoriaRepositorio.Delete(id);

        }
    }
}
