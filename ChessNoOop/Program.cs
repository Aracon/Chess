using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chess
{
    class Program
    {
        static int[,] board;
        static Board brd;

        static Move ReadMove()
        {
            int iFrom, jFrom, iTo, jTo;
            iFrom = 0;
            jFrom = 0;
            iTo = 0;
            jTo = 0;
            bool reading = true;
            do
            {
                Console.WriteLine("Your turn:");
                string[] cmd = Console.ReadLine().Split(' '); // 2 2 2 4
                if (cmd.Length != 4)
                {
                    Console.WriteLine("Enter 4 numbers, for example 2 2 2 4 for B2-B4");
                    continue;
                }
                try
                {
                    iFrom = int.Parse(cmd[0])-1;
                    jFrom = int.Parse(cmd[1])-1;
                    iTo = int.Parse(cmd[2])-1;
                    jTo = int.Parse(cmd[3])-1;

                    if (!brd.IsCellOnBoard(iFrom, jFrom)) continue;
                    if (!brd.IsCellOnBoard(iTo, jTo)) continue;

                    reading = false;
                }
                catch
                {
                    Console.WriteLine("Enter 4 numbers, for example 2 2 2 4 for B2-B4");
                    continue;
                }

            } while (reading);
            return new Move(iFrom, jFrom, iTo, jTo);
        }

       
        static bool CheckMove(Move move, FigureColor currentPlayerColor)
        {
            if (brd[move.ColFrom, move.RowFrom] == null)
            {
                return false;
            }
            FigureColor colorFrom;

            // Проверяем, принадлежит ли фигура текущему игроку
            Figure figure = brd[move.ColFrom, move.RowFrom];
            colorFrom = figure.Color;


            if (colorFrom != currentPlayerColor)
            {
                return false;
            }

            // Проверка, ходит ли фигура таким образом
            if (figure.CheckMove(move, brd) == false)
                return false;

            Figure fig2 = brd[move.ColTo, move.RowTo];
            if (fig2 != null)
            {
                FigureColor colorTo = fig2.Color;
                
                if (colorFrom == colorTo)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            brd = new Board(8, 8);
            GameRules.PlaceFigures(brd);
            FigureColor currentPlayerColor = FigureColor.White;

            int i1, j1, i2, j2;



            Move move;

            while (true)
            {
                brd.PrintBoard();

                move = ReadMove();

                if (CheckMove(move, currentPlayerColor))
                {
                    brd.ApplyMove(move);

                    if (currentPlayerColor == FigureColor.White)
                        currentPlayerColor = FigureColor.Black;
                    else
                        currentPlayerColor = FigureColor.White;
                }
                else
                {
                    Console.WriteLine("wrong move");
                }

            }



            Console.WriteLine("END OF THE GAME");
            Console.ReadKey();
        }
    }
}
