using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WK.Servicos.Domain.Repositorio;

namespace WK.Servicos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriaController : ControllerBase
    {

        private readonly IProdutoCategoriaRepositorio _produtoCategoriaRepositorio;

        public CategoriaController(IProdutoCategoriaRepositorio produtoCategoriaRepositorio)
        {
            _produtoCategoriaRepositorio = produtoCategoriaRepositorio;
        }

        [HttpGet(Name = "Get")]
        public async Task<string> Get()
        {
            var envio = await _produtoCategoriaRepositorio.Listar();
            return envio.FirstOrDefault().nome_categoria;
        }
    }
}
