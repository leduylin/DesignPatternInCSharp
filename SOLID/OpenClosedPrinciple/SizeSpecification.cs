using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.Interface;

namespace OpenClosedPrinciple
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size Size;
        public SizeSpecification(Size size)
        {
            this.Size = size;
        }
        public bool IsSatisfied(Product t)
        {
            return t.Size == Size;
        }
    }
}
