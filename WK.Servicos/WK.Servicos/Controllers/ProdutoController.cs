using Microsoft.AspNetCore.Mvc;
using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Controllers
{
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet(Name = "ListaProduto")]
        public async Task<List<ProdutoDTO>> Lista()
        {
            var retorno = await _produtoService.ListarProduto();

            return retorno;
        }

        [HttpGet(Name = "ObterPorId")]
        public async Task<ProdutoDTO> ObterPorId(int id)
        {
            var retorno = await _produtoService.ObterPorId(id);

            return retorno;
        }

        [HttpPost(Name = "Adicionar")]
        public ActionResult<ProdutoDTO> Adicionar(ProdutoDTO produtoDTO)
        {
            _produtoService.Adicionar(produtoDTO);

            return Ok();
        }

        [HttpPut(Name = "Atualizar")]
        public ActionResult<ProdutoDTO> Atualizar(ProdutoDTO produtoDTO)
        {
            _produtoService.Atualizar(produtoDTO);

            return Ok();
        }

        [HttpDelete(Name = "Delete")]
        public ActionResult<ProdutoDTO> Delete(int id)
        {
            _produtoService.Delete(id);

            return Ok();
        }
    }
}
