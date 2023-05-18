﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangular.BLL
{
    public class GridReference : IGridReference
    {
        public char Row { get; set; }
        public int Column { get; set; }

        public GridReference(string reference)
        {
            this.Row = reference.ToCharArray().First();
            this.Column = int.Parse(reference.Substring(1));
        }

        public GridReference(char row, int column)
        {
            this.Row = char.ToUpper(row);
            this.Column = column;
        }

        public GridReference(int row, int column)
        {
            this.Row = this.NumberToAlphabet(row);
            this.Column = column;
        }

        public int GetNumericRow()
        {
            int rowCharacterCode = this.Row;

            return rowCharacterCode - 64;
        }

        public char NumberToAlphabet(int number)
        {
            return (Char)(64 + number);
        }
    }
}
