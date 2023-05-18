using System;
using System.Linq;

namespace Triangular.BLL
{
    public class GridReference : IGridReference
    {
        public char Row { get; set; }
        public int Column { get; set; }

        public GridReference(string reference)
        {
            Row = reference.ToCharArray().First();
            Column = int.Parse(reference.Substring(1));
        }

        public GridReference(char row, int column)
        {
            Row = char.ToUpper(row);
            Column = column;
        }

        public GridReference(int row, int column)
        {
            Row = NumberToAlphabet(row);
            Column = column;
        }

        public int GetNumericRow()
        {
            int rowCharacterCode = Row;

            return rowCharacterCode - 64;
        }

        public char NumberToAlphabet(int number)
        {
            return (Char)(64 + number);
        }
    }
}