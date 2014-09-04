﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    abstract class Figure
    {
        public Figure(FigureColor color)
        {
            this.color = color;
        }

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

        abstract public bool CheckMove(Move m, Board board);
    }
}
