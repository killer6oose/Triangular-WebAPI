using Triangular.BLL.Models;

namespace Triangular.BLL.Factories
{
    public interface ITriangleCalculatorFactory
    {
        ITriangleCalculator Make(IGridReference gridReference);
    }
}