using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Aplicacao.Interfaces
{
    public interface IProdutoService
    {
        void Adicionar(ProdutoDTO DTO);
        void Atualizar(ProdutoDTO DTO);
        void Delete(int id);
        Task<List<ProdutoDTO>> ListarProduto();
        Task<ProdutoDTO> ObterPorId(int id);
    }
}