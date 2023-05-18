using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangular.BLL
{
    public interface IGridReference
    {
        char Row { get; set; }
        int Column { get; set; }

        int GetNumericRow();
    }
}
