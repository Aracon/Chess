using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Pawn
    {
        FigureColor color;
        public FigureColor Color
        {
            get { return color; }
        }

        int col;
        public int Column
        {
            get { return col; }
            set { col = value; }
        }
        int row;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public bool CheckMove(Move m)
        {
            throw new NotImplementedException();
        }
    }
}
