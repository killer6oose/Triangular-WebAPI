using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangular.BLL.Calculators.TriangleCalculators
{
    public interface ITriangleCalculator
    {
        IGridShape Calculate(IGrid grid, IGridReference gridReference);
    }
}
