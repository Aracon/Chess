using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Pawn : Figure
    {
        public Pawn(FigureColor color) : base(color)
        {
        }


        public override bool CheckMove(Move m, Board b)
        {

            if (m.ColFrom != m.ColTo)
            {
                return false;
            }

            if (Color==FigureColor.White)
            {
                if (m.RowTo - m.RowFrom != 1) return false;
            }
            else
            {
                if (m.RowTo - m.RowFrom != -1) return false;
            }
            if (b[m.ColTo, m.RowTo] != null) return false;

            return true;
        }
    }
}
