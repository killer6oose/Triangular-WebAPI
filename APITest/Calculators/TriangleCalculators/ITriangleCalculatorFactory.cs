namespace Triangular.BLL.Calculators.TriangleCalculators
{
    public interface ITriangleCalculatorFactory
    {
        ITriangleCalculator Make(IGridReference gridReference);
    }
}