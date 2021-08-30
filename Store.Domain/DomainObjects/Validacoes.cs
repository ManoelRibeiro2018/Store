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
    }
}
