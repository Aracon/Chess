using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class GameRules
    {
        public static void PlaceFigures(Board board)
        {
            for (int i = 0; i < 8; i++)
            {
                Pawn p = new Pawn(FigureColor.White);
                board.AddFigure(p, i, 1);

                p = new Pawn(FigureColor.Black);
                board.AddFigure(p, i, 6);
            }

            Rook r = new Rook(FigureColor.White);
            board.AddFigure(r, 0, 0);

            r = new Rook(FigureColor.White);
            board.AddFigure(r, 7, 0);

            r = new Rook(FigureColor.Black);
            board.AddFigure(r, 0, 7);

            r = new Rook(FigureColor.Black);
            board.AddFigure(r, 7, 7);

            Bishop b = new Bishop(FigureColor.White);
            board.AddFigure(b, 2, 0);

            b = new Bishop(FigureColor.White);
            board.AddFigure(b, 5, 0);

            b = new Bishop(FigureColor.Black);
            board.AddFigure(b, 2, 7);

            b = new Bishop(FigureColor.Black);
            board.AddFigure(b, 5, 7);


            //board[0, 0] = board[0, 7] = 2; // Ладья
            //board[7, 0] = board[7, 7] = -2;
        }

    }
}
