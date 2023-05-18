namespace Triangular.BLL.Models
{
    public class Grid : IGrid
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int CellSize { get; set; }

        public Grid(int height, int width, int cellSize)
        {
            Height = height;
            Width = width;
            CellSize = cellSize;
        }

        public virtual int GetRowCount()
        {
            return Height / CellSize;
        }

        public virtual int GetColumnCount()
        {
            return Width / CellSize;
        }
    }
}