using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class Pawn : Piece, IMovement
    {
        public Pawn(string name, char[,] keypad)
        {
            this.name = name;
            this.keypad = keypad;
            this.moves = new List<List<int>>();

            GenerateMoves();
        }

        public void GenerateMoves()
        {
            moves.Add(new List<int> { -1, 0 }); //move up
        }
        



    }
}
