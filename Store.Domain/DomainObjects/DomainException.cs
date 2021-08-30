using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.DomainObjects
{
    public class DomainException : Exception
    {
        public DomainException(string mensagem):
            base(mensagem)
        {

        }
    }
}
