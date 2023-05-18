using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangular.BLL.Calculators.GridReferenceCalculators
{
    public interface IGridReferenceCalculator
    {
        IGridShape Calculate(IGrid grid, IGridShape gridShape);
    }
}
