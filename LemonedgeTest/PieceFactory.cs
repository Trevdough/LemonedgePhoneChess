using LemonedgeTest.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest
{
    public class PieceFactory
    {
        public static Piece MakePiece(char[,] keypad, string name, int numberCount)
        {
            switch (name)
            {
                case "Pawn":
                    return new Pawn(name, keypad, numberCount);
                case "Bishop":
                    return new Bishop(name, keypad, numberCount);
                case "Rook":
                    return new Rook(name, keypad, numberCount);
                case "Knight":
                    return new Knight(name, keypad, numberCount);
                case "King":
                    return new King(name, keypad, numberCount);
                case "Queen":
                    return new Queen(name, keypad, numberCount);
                default:
                    return new Pawn(name, keypad, numberCount);
            }
        }
        
    }
}
