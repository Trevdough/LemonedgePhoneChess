using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class King: Piece, IMovement
    {

        public King(string name, char[,] keypad)
        {
            this.name = name;
            this.keypad = keypad;
            this.moves = new List<List<int>>();

            GenerateMoves(); 
        }

        public void GenerateMoves()
        {   
                // Bishop type movement
                moves.Add(new List<int> { -1, -1}); //up left
                moves.Add(new List<int> { -1, 1 }); //up right
                moves.Add(new List<int> { 1, -1 }); //down left
                moves.Add(new List<int> { 1, 1 }); //down right
                // Rook type movement
                moves.Add(new List<int> { -1, 0 });  // up
                moves.Add(new List<int> { 1, 0 }); //down
                moves.Add(new List<int> { 0, -1 }); //left
                moves.Add(new List<int> { 0, 1 }); //right

        }
    }
}
