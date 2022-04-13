using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportAppThedor.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
