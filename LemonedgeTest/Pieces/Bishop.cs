using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class Bishop: Piece, IMovement
    {
        public Bishop(string name, char[,] keypad, int numberCount)
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
                // can move positive or negative diagonal, so 4 types of movement
                moves.Add(new List<int> { -i, -i }); //up left
                moves.Add(new List<int> { -i, i }); //up right
                moves.Add(new List<int> { i, -i }); //down left
                moves.Add(new List<int> { i, i }); //down right
            }

        }
    }
}
