using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(Product p);
    }
}
