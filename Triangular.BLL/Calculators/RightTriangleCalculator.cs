using Triangular.BLL.Models;

namespace Triangular.BLL.Calculators
{
    public class RightTriangleCalculator : ITriangleCalculator
    {
        public IGridShape Calculate(IGrid grid, IGridReference gridReference)
        {
            int topLeftX = (gridReference.Column / 2 - 1) * grid.CellSize;
            int leftY = (gridReference.GetNumericRow() - 1) * grid.CellSize;

            int bottomX = topLeftX + grid.CellSize;
            int bottomRightY = leftY + grid.CellSize;

            return new GridShape().AddCoordinate(new Coordinate(topLeftX, leftY))
                                  .AddCoordinate(new Coordinate(bottomX, leftY))
                                  .AddCoordinate(new Coordinate(bottomX, bottomRightY));
        }
    }
}