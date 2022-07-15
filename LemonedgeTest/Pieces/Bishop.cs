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
            List<List<int>> tempList = new List<List<int>>();
            for (int i = 0; i < keypad.GetLength(0); i++) //iterate through rows
            {
                // can move positive or negative diagonal, so 4 types of movement
                tempList.Add(new List<int> { -i, -i }); //up left
                tempList.Add(new List<int> { -i, i }); //up right
                tempList.Add(new List<int> { i, -i }); //down left
                tempList.Add(new List<int> { i, i }); //down right
            }

            for (int k = 0; k < tempList.Count; k++)
            {
                bool dupe = false;
                for (int l = 0; l < moves.Count; l++)
                {

                    if (tempList[k].SequenceEqual(moves[l]))
                    {
                        dupe = true;
                    }
                }
                List<int> noMove = new List<int> { 0, 0 }; // no movement
                if (!dupe && !tempList[k].SequenceEqual(noMove)) // if it isn't a duplicate and it moves, add to moves
                {
                    moves.Add(tempList[k]);
                }
            }

        }
    }
}
