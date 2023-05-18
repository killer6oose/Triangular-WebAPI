using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangular.BLL
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
