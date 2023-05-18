using Triangular.BLL.Models;

namespace Triangular.BLL.Services
{
    public class GridReferenceByTriangleCalculator : IGridReferenceByTriangleCalculator
    {
        public GridReference Calculate(IGrid grid, Triangle triangle)
        {
            Coordinate angleCoordinate = triangle.AngleCoordinate;
            Coordinate topCoordinate = triangle.TopLeftCoordinate;
            Coordinate bottomCoordinate = triangle.BottomRightCoordinate;

            int row = angleCoordinate.Y / grid.CellSize;

            if (topCoordinate.Y == angleCoordinate.Y)
            {
                row++;
            }

            int column = angleCoordinate.X / grid.CellSize * 2;

            if (topCoordinate.X == angleCoordinate.X)
            {
                column++;
            }

            return new GridReference(row, column);
        }
    }
}