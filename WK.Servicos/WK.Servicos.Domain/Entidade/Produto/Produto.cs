using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.DomainObjects;

namespace WK.Servicos.Domain.Entidade.Produto
{
    public class Produto : Entity, IAggregateRoot
    {
        public int id { get; set; }
        public string nome_produto { get; set; }
        public string descricao { get; set; }
        public decimal preco { get; set; }
        public int quantidade_estoque { get; set; }
        public int id_produto_categoria { get; set; }
        //public ProdutoCategoria Categoria { get; set; }
    }
}
