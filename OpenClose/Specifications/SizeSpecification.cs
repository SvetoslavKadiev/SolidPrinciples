using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClose.Interfaces;

namespace OpenClose.Specifications
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }
}
