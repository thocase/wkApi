using Microsoft.AspNetCore.Mvc;
using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("ListaProduto")]
        public async Task<List<ProdutoDTO>> Lista()
        {
            var retorno = await _produtoService.ListarProduto();

            return retorno;
        }

        [HttpGet]
        [Route("ObterPorId/{id}")]
        public async Task<ProdutoDTO> ObterProdutoPorId(int id)
        {
            var retorno = await _produtoService.ObterPorId(id);

            return retorno;
        }

        [HttpPost]
        [Route("Adicionar")]
        public ActionResult<ProdutoDTO> Adicionar(ProdutoDTO produtoDTO)
        {
            _produtoService.Adicionar(produtoDTO);

            return Ok();
        }

        [HttpPut]
        [Route("Atualizar")]
        public ActionResult<ProdutoDTO> Atualizar(ProdutoDTO produtoDTO)
        {
            _produtoService.Atualizar(produtoDTO);

            return Ok();
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public ActionResult<ProdutoDTO> Delete(int id)
        {
            _produtoService.Delete(id);

            return Ok();
        }
    }
}
