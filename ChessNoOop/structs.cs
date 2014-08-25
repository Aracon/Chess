using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    enum FigureColor { Black, White };

    struct Move
    {
        public Move(int colFrom, int rowFrom, int colTo, int rowTo)
        {
            this.colFrom = colFrom;
            this.rowFrom = rowFrom;
            this.colTo = colTo;
            this.rowTo = rowTo;
        }


        int colFrom;
        int rowFrom;
        int colTo;
        int rowTo;

        public int ColFrom {
            get { return colFrom; }
            set { colFrom = value; }
        }
        public int RowFrom
        {
            get { return rowFrom; }
            set { rowFrom = value; }
        }
        public int ColTo
        {
            get { return colTo; }
            set { colTo = value; }
        }
        public int RowTo
        {
            get { return rowTo; }
            set { rowTo = value; }
        }

    }
}
