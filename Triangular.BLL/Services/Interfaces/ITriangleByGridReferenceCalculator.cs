using Triangular.BLL.Models;

namespace Triangular.BLL.Services
{
    public interface ITriangleByGridReferenceCalculator
    {
        IGridShape Calculate(IGrid grid, IGridReference gridReference);
    }
}