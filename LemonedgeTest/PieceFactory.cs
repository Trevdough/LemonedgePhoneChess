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
        public static Piece MakePiece(char[,] keypad, string name)
        {
            switch (name)
            {
                case "Pawn":
                    return new Pawn(name, keypad);
                case "Bishop":
                    return new Bishop(name, keypad);
                case "Rook":
                    return new Rook(name, keypad);
                case "Knight":
                    return new Knight(name, keypad);
                case "King":
                    return new King(name, keypad);
                case "Queen":
                    return new Queen(name, keypad);
                default:
                    return new Pawn(name, keypad);
            }
        }
        
    }
}
