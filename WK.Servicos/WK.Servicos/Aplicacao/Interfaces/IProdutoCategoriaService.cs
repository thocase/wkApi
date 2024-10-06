using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Aplicacao.Interfaces
{
    public interface IProdutoCategoriaService
    {
        void Adicionar(ProdutoCategoriaDTO categoriaDTO);
        void Delete(int id);
        Task<List<ProdutoCategoriaDTO>> ListarProdutoCategoria();
        Task<ProdutoCategoriaDTO> ObterPorId(int id);
        void Atualizar(ProdutoCategoriaDTO categoriaDTO);
    }
}
