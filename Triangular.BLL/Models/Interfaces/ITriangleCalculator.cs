namespace Triangular.BLL.Models
{
    public interface ITriangleCalculator
    {
        IGridShape Calculate(IGrid grid, IGridReference gridReference);
    }
}