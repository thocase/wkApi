using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WK.Servicos.Aplicacao.Interfaces;
using WK.Servicos.Domain.Repositorio;
using WK.Servicos.Infra.API.DTO;

namespace WK.Servicos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoCategoriaController : ControllerBase
    {

        private readonly IProdutoCategoriaService _produtoCategoriaService;

        public ProdutoCategoriaController(IProdutoCategoriaService produtoCategoriaService)
        {
            _produtoCategoriaService = produtoCategoriaService;
        }

        [HttpGet(Name = "ListaProdutoCategoria")]
        public async Task<List<ProdutoCategoriaDTO>> Lista()
        {
            var retorno = await _produtoCategoriaService.ListarProdutoCategoria();

            return retorno;
        }

        [HttpGet(Name = "ObterPorId")]
        public async Task<ProdutoCategoriaDTO> ObterPorId(int id)
        {
            var retorno = await _produtoCategoriaService.ObterPorId(id);

            return  retorno;
        }

        [HttpPost(Name = "Adicionar")]
        public  ActionResult<ProdutoCategoriaDTO> Adicionar(ProdutoCategoriaDTO categoriaDTO)
        {
            _produtoCategoriaService.Adicionar(categoriaDTO);

            return Ok();
        }

        [HttpPut(Name = "Atualizar")]
        public ActionResult<ProdutoCategoriaDTO> Atualizar(ProdutoCategoriaDTO categoriaDTO)
        {
            _produtoCategoriaService.Atualizar(categoriaDTO);

            return Ok();
        }

        [HttpDelete(Name = "Delete")]
        public ActionResult<ProdutoCategoriaDTO> Delete(int id)
        {
            _produtoCategoriaService.Delete(id);

            return Ok();
        }


    }
}
