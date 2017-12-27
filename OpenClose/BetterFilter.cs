using System.Collections.Generic;
using OpenClose.Interfaces;

namespace OpenClose
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (Product product in items)
                if (spec.IsSatisfied(product))
                    yield return product;
        }
    }
}
