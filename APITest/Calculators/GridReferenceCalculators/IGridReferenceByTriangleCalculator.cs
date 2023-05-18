using Triangular.BLL;

namespace APITest.Calculators.GridReferenceCalculators
{
    public interface IGridReferenceByTriangleCalculator
    {
        GridReference Calculate(IGrid grid, Triangle triangle);
    }
}