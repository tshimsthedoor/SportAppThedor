using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportAppThedor.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>;
    }
}
