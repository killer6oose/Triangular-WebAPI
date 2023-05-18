using APITest.Calculators.TriangleCalculators;

namespace Triangular.BLL.Calculators.TriangleCalculators
{
    public class TriangleByGridReferenceCalculator : ITriangleByGridReferenceCalculator
    {
        private readonly ITriangleCalculatorFactory CalculatorFactory;

        public TriangleByGridReferenceCalculator(ITriangleCalculatorFactory calculatorFactory)
        {
            this.CalculatorFactory = calculatorFactory;
        }

        public IGridShape Calculate(IGrid grid, IGridReference gridReference)
        {
            ITriangleCalculator triangleCalculator = this.CalculatorFactory.Make(gridReference);

            return triangleCalculator.Calculate(grid, gridReference);
        }
    }
}