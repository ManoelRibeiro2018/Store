using FluentValidation;
using Store.API.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.Validator
{
    public class ProdutoValidator : AbstractValidator<ProdutoInputModel>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .NotNull()
                .WithMessage("Informe o nome");

            RuleFor(p => p.Valor)
                .InclusiveBetween(10, 100000)
                .WithMessage("Digite um vlaor de 10 á 100000");


        }
    }
}
