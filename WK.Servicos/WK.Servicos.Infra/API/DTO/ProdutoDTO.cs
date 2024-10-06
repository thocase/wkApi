using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.Entidade.Produto;

namespace WK.Servicos.Infra.API.DTO
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int CategoriaId { get; set; }
    }
}
