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

        public override string Symbol
        {
            get { return "B"; }
        }


        public override bool CheckMove(Move m, Board board)
        {
            // TODO: Write move check
            return true;
        }
        
       
    }
}
