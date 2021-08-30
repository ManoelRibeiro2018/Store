using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.DomainObjects
{
    public class Validacoes
    {
        public static void ValidarSeMenorQue(decimal valor, long minimo, string mensagemValidacao)
        {
            if (valor < minimo)
            {
                throw new DomainException(mensagemValidacao);
            }

        }

        public static void ValidarSeVazio(string valor,  string mensagemValidacao)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(mensagemValidacao);
            }
        }

        public static void ValidarSeIgual(object val1, object val2, string mensagemValidacao)
        {
            if (val1.Equals(val2))
            {
                throw new DomainException(mensagemValidacao);
            }
        }
    }
}
