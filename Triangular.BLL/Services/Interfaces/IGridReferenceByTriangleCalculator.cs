using Triangular.BLL.Models;

namespace Triangular.BLL.Services
{
    public interface IGridReferenceByTriangleCalculator
    {
        GridReference Calculate(IGrid grid, Triangle triangle);
    }
}