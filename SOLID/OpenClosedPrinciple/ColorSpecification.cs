using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.Interface;

namespace OpenClosedPrinciple
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color Color;

        public ColorSpecification(Color color)
        {
            this.Color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == Color;
        }
    }
}
