using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class Rook: Piece, IMovement
    {
        public Rook(string name, char[,] keypad, int numberCount)
        {
            this.name = name;
            this.keypad = keypad;
            this.validMoves = new Dictionary<char, List<List<int>>>();
            this.numberCount = numberCount;
            this.moves = new List<List<int>>();

            GenerateMoves();
            GenerateValidMoves();
            GetCount();
        }

        public void GenerateMoves()
        {
            for (int i = 0; i < keypad.GetLength(0); i++) //iterate through rows
            {
                // can move positive or negative up to bounds of keypad
                moves.Add(new List<int> { -i, 0 });  // up
                moves.Add(new List<int> { i, 0 }); //down
            }

            for(int j = 0; j< keypad.GetLength(1); j++) // iterate through columns
            {
                moves.Add(new List<int> { 0, -j }); //left
                moves.Add(new List<int> { 0, j }); //right
            }
        }

    }
}
