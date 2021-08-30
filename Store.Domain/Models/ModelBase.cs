using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Models
{
    public abstract class ModelBase
    {
        public Guid Id { get; set; }
        protected ModelBase()
        {
            Id = Guid.NewGuid();
        }
    }
}
