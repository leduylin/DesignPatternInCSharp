using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosedPrinciple.Interface;

namespace OpenClosedPrinciple
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var p in items)
            {
                if (spec.IsSatisfied(p))
                {
                    yield return p;
                }
            }
        }
    }
}
