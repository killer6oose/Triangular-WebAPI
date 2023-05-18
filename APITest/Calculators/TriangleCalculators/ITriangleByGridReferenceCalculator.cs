using Triangular.BLL;

namespace APITest.Calculators.TriangleCalculators
{
    public interface ITriangleByGridReferenceCalculator
    {
        IGridShape Calculate(IGrid grid, IGridReference gridReference);
    }
}