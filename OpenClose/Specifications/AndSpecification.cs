using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClose.Interfaces;

namespace OpenClose.Specifications
{
    // combinator
    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(Product p)
        {
            return first.IsSatisfied(p) && second.IsSatisfied(p);
        }
    }
}
