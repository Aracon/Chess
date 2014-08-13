using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    enum FigureColor { Black, White };

    struct Move
    {
        int colFrom;
        int rowFrom;
        int colTo;
        int rowTo;
    }
}
