﻿namespace Triangular.BLL.Models
{
    public interface IGrid
    {
        int Height { get; set; }
        int Width { get; set; }
        int CellSize { get; set; }

        int GetRowCount();

        int GetColumnCount();
    }
}