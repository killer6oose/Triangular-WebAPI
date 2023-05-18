using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangular.BLL.Calculators.TriangleCalculators
{
    public class TriangleCalculatorFactory : ITriangleCalculatorFactory
    {
        public ITriangleCalculator Make(IGridReference gridReference)
        {
            if(gridReference.Column % 2 == 0)
            {
                return new RightTriangleCalculator();
            }
            else
            {
                return new LeftTriangleCalculator();
            }
        }
    }
}
