using Store.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public class Categoria : ModelBase
    {
        public string Nome { get; private set; }

        public Categoria(string nome, int id)
        {
            Nome = nome;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"{Nome} - {Id}";
        }

        public void Validar()
        {
            //Validações
        }
    }
}
