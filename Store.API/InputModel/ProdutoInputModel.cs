using System;

namespace Store.API.ViewModel
{
    public class ProdutoInputModel
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public  DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QtdEstoque { get; private set; }
    }
}
