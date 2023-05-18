using Triangular.BLL.Calculators;
using Triangular.BLL.Models;

namespace Triangular.BLL.Factories
{
    public class TriangleCalculatorFactory : ITriangleCalculatorFactory
    {
        public ITriangleCalculator Make(IGridReference gridReference)
        {
            return gridReference.Column % 2 == 0
                ? new RightTriangleCalculator()
                : new LeftTriangleCalculator();
        }
    }
}