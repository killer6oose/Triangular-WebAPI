namespace Triangular.BLL.Models
{
    public class TriangularGrid : Grid
    {
        public TriangularGrid(int height, int width, int cellSize) : base(height, width, cellSize)
        {
        }

        public override int GetColumnCount()
        {
            return Width / CellSize * 2;
        }
    }
}