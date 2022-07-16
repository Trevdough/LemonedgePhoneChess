using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class Knight: Piece, IMovement
    {

        public Knight(string name, char[,] keypad)
        {
            this.name = name;
            this.keypad = keypad;
            this.moves = new List<List<int>>();

            GenerateMoves();
        }

        public void GenerateMoves()
        {

            // Move in an L shape, so 2 in one direction, one in the other
            moves.Add(new List<int> { -1, -2 }); //Left up
            moves.Add(new List<int> { -2, -1 }); //Up left
            moves.Add(new List<int> { -2,  1 }); //Up right
            moves.Add(new List<int> { -1, 2 }); //Right up
            moves.Add(new List<int> { 1, 2 }); //Right Down
            moves.Add(new List<int> { 2, 1 }); //Down right
            moves.Add(new List<int> { 2, -1 }); //Down left
            moves.Add(new List<int> { 1, -2 }); //Left down

        }
    }
}
