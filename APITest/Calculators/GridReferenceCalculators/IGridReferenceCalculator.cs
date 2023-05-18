namespace Triangular.BLL.Calculators.GridReferenceCalculators
{
    public interface IGridReferenceCalculator
    {
        IGridShape Calculate(IGrid grid, IGridShape gridShape);
    }
}