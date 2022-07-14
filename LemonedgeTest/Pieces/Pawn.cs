using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class Pawn : Piece, IMovement
    {
        public Pawn(string name, char[,] keypad, int numberCount)
        {
            this.name = name;
            this.keypad = keypad;
            this.validMoves = new Dictionary<char, List<List<int>>>();
            this.numberCount = numberCount;
            this.moves = new List<List<int>>();

            GenerateMoves();
            GenerateValidMoves();
            GetCount();

            //this.moves = new List<List<int>>();
            //GenerateMoves();
            //validMoves = IMovement.GenerateValidMoves(keypad, moves);
        }
        // need:
        // get List of coords of move options
        // loop through pad to generate available moves for each piece for ech start point, iterate through all move options

        public void GenerateMoves()
        {
            moves.Add(new List<int> { -1, 0 }); //move up
        }
        



    }
}
