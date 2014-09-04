using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Bishop : Figure
    {
        public Bishop(FigureColor color) : base(color)
        {
        }



        public override bool CheckMove(Move m, Board board)
        {
            // TODO: Write move check
            return true;
        }
        
       
    }
}
