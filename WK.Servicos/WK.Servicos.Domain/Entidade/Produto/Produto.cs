﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WK.Servicos.Domain.DomainObjects;

namespace WK.Servicos.Domain.Entidade.Produto
{
    public class Produto : Entity, IAggregateRoot
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public ProdutoCategoria Categoria { get; set; }
    }
}
