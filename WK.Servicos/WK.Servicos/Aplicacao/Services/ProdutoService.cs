using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Domain.Entidade.Produto;
using WK.Servicos.Domain.Repositorio;
using WK.Servicos.Infra.API.DTO;
using WK.Servicos.Infra.Repositorio;

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
                Id = x.id,
                Nome = x.nome_produto,
                Descricao = x.descricao,
                Preco = x.preco,
                QuantidadeEstoque = x.quantidade_estoque,
                CategoriaId = x.id_produto_categoria
            }).ToList();
        }

        public async Task<ProdutoDTO> ObterPorId(int id)
        {
            var retorno = _produtoRepositorio.GetById(id);

            return new ProdutoDTO
            {
                Id = retorno.id,
                Nome = retorno.nome_produto,
                Descricao = retorno.descricao,
                Preco = retorno.preco,
                QuantidadeEstoque = retorno.quantidade_estoque,
                CategoriaId = retorno.id_produto_categoria
                //Categoria = new ProdutoCategoriaDTO { Id = retorno.Categoria.Id, Nome = retorno.Categoria.nome_categoria, Descricao = retorno.Categoria.descricao }
            };
        }

        public void Adicionar(ProdutoDTO produtoDTO)
        {
            var entity = new Produto
            {
                nome_produto = produtoDTO.Nome,
                descricao = produtoDTO.Descricao,
                preco = produtoDTO.Preco,
                quantidade_estoque = produtoDTO.QuantidadeEstoque,
                id_produto_categoria = produtoDTO.CategoriaId
            };
            _produtoRepositorio.Add(entity);

            _produtoRepositorio.UnitOfWork.Commit();

        }

        public void Atualizar(ProdutoDTO produtoDTO)
        {
            var entity = new Produto
            {
                id = produtoDTO.Id,
                nome_produto = produtoDTO.Nome,
                descricao = produtoDTO.Descricao,
                preco = produtoDTO.Preco,
                quantidade_estoque = produtoDTO.QuantidadeEstoque,
                id_produto_categoria = produtoDTO.CategoriaId
            };

            _produtoRepositorio.Update(entity);

            _produtoRepositorio.UnitOfWork.Commit();

        }

        public void Delete(int id)
        {
            _produtoRepositorio.Delete(id);

            _produtoRepositorio.UnitOfWork.Commit();

        }
    }
}
