using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Domain.Entidade.Produto;
using WK.Servicos.Domain.Repositorio;
using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Aplicacao.Services
{
    public class ProdutoService : IProdutoService
    {

        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoService(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<List<ProdutoDTO>> ListarProduto()
        {
            var envio = await _produtoRepositorio.Listar();

            return envio.Select(x => new ProdutoDTO
            {
                Id = x.Id,
                Nome = x.Nome,
                Descricao = x.Descricao,
                Preco = x.Preco,
                QuantidadeEstoque = x.QuantidadeEstoque,
                Categoria = new ProdutoCategoriaDTO { Id = x.Categoria.Id, Nome = x.Categoria.nome_categoria, Descricao = x.Categoria.descricao }
            }).ToList();
        }

        public async Task<ProdutoDTO> ObterPorId(int id)
        {
            var retorno = await _produtoRepositorio.GetById(id);

            return new ProdutoDTO
            {
                Id = retorno.Id,
                Nome = retorno.Nome,
                Descricao = retorno.Descricao,
                Preco = retorno.Preco,
                QuantidadeEstoque = retorno.QuantidadeEstoque,
                Categoria = new ProdutoCategoriaDTO { Id = retorno.Categoria.Id, Nome = retorno.Categoria.nome_categoria, Descricao = retorno.Categoria.descricao }
            };
        }

        public void Adicionar(ProdutoDTO produtoDTO)
        {
            var entity = new Produto
            {
                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Descricao = produtoDTO.Descricao,
                Preco = produtoDTO.Preco,
                QuantidadeEstoque = produtoDTO.QuantidadeEstoque,
                Categoria = new ProdutoCategoria { Id = produtoDTO.Categoria.Id, nome_categoria = produtoDTO.Categoria.Nome, descricao = produtoDTO.Categoria.Descricao }
            };

            _produtoRepositorio.Add(entity);

        }

        public void Atualizar(ProdutoDTO produtoDTO)
        {
            var entity = new Produto
            {
                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Descricao = produtoDTO.Descricao,
                Preco = produtoDTO.Preco,
                QuantidadeEstoque = produtoDTO.QuantidadeEstoque,
                Categoria = new ProdutoCategoria { Id = produtoDTO.Categoria.Id, nome_categoria = produtoDTO.Categoria.Nome, descricao = produtoDTO.Categoria.Descricao }
            };

            _produtoRepositorio.Update(entity);

        }

        public void Delete(int id)
        {
            _produtoRepositorio.Delete(id);

        }
    }
}
