﻿namespace Triangular.BLL.Calculators.TriangleCalculators
{
    public interface ITriangleCalculator
    {
        IGridShape Calculate(IGrid grid, IGridReference gridReference);
    }
}