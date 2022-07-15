using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class King: Piece, IMovement
    {

        public King(string name, char[,] keypad, int numberCount)
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
                // Bishop movement
                moves.Add(new List<int> { -1, -1}); //up left
                moves.Add(new List<int> { -1, 1 }); //up right
                moves.Add(new List<int> { 1, -1 }); //down left
                moves.Add(new List<int> { 1, 1 }); //down right
                // Rook movement
                moves.Add(new List<int> { -1, 0 });  // up
                moves.Add(new List<int> { 1, 0 }); //down
                moves.Add(new List<int> { 0, -1 }); //left
                moves.Add(new List<int> { 0, 1 }); //right

        }
    }
}
