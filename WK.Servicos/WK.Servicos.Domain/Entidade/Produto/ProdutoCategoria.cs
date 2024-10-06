using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.DomainObjects;

namespace WK.Servicos.Domain.Entidade.Produto
{
    public class ProdutoCategoria : Entity, IAggregateRoot
    {
        public int id { get; set; }
        public string nome_categoria { get; set; }
        public string descricao { get; set; }
    }
}
