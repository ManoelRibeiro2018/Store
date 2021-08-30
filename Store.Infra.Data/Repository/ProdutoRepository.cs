using Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infra.Data.Repository
{ 
    public class ProdutoRepository
    {
        
        private static List<Produto> _produtos = new();

        public ProdutoRepository()
        {
            _produtos = new List<Produto>();
        }
        public Guid Adicionar(Produto produto)
        {
            _produtos.Add(produto);
            return produto.Id;
        }
    }
}
