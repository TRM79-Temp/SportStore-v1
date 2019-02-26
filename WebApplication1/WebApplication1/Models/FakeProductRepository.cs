using System.Collections.Generic;
using System.Linq;
namespace WebApplication1.Models
{
    public class FakeProductRepository : IProductRepositoryQ
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf board", Price = 179 },
            new Product { Name = "Running shoes", Price = 95 }
        }.AsQueryable<Product>();
    }
}