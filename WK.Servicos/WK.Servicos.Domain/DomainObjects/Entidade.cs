using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK.Servicos.Domain.DomainObjects
{
    public abstract class Entity
    {
        public int id { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={id}]";
        }
    }
}
