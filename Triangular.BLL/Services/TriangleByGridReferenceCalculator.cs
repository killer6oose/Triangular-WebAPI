using Triangular.BLL.Factories;
using Triangular.BLL.Models;

namespace Triangular.BLL.Services
{
    public class TriangleByGridReferenceCalculator : ITriangleByGridReferenceCalculator
    {
        private readonly ITriangleCalculatorFactory _calculatorFactory;

        public TriangleByGridReferenceCalculator(ITriangleCalculatorFactory calculatorFactory)
        {
            _calculatorFactory = calculatorFactory;
        }

        public IGridShape Calculate(IGrid grid, IGridReference gridReference)
        {
            ITriangleCalculator triangleCalculator = _calculatorFactory.Make(gridReference);

            return triangleCalculator.Calculate(grid, gridReference);
        }
    }
}