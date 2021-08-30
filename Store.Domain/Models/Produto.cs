using Store.Domain.DomainObjects;
using Store.Domain.ValueObjects;
using System;

namespace Store.Domain.Models
{
    public class Produto : ModelBase
    {
        
        public Guid CategoriaId { get; private set; }
        public string  Nome { get; private set; }
        public string Descricao { get; private set; }
        public bool Ativo { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Imagem { get; private set; }
        public int QtdEstoque { get; private set; }
        public Dimensoes Dimensoes { get; private set; }
        public Categoria Categoria { get; private set; }

        protected Produto()
        {

        }
        public Produto(Guid categoriaId, string nome, string descricao, bool ativo, decimal valor, DateTime dataCadastro,
            string imagem, int qtdEstoque, Dimensoes dimensoes, Categoria categoria)
        {
            CategoriaId = categoriaId;
            Nome = nome;
            Descricao = descricao;
            Ativo = ativo;
            Valor = valor;
            DataCadastro = dataCadastro;
            Imagem = imagem;
            QtdEstoque = qtdEstoque;
            Dimensoes = dimensoes;
            Categoria = categoria;

            Validar();
        }

        public  void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "Nome não informado");
        } 
    }
}
