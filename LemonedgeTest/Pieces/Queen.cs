using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest.Pieces
{
    public class Queen: Piece, IMovement
    {

        public Queen(string name, char[,] keypad)
        {
            this.name = name;
            this.keypad = keypad;
            this.moves = new List<List<int>>();

            GenerateMoves();
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

            for (int i = 0; i < keypad.GetLength(0); i++) //iterate through rows
            {
                // can move positive or negative up to bounds of keypad
                tempList.Add(new List<int> { -i, 0 });  // up
                tempList.Add(new List<int> { i, 0 }); //down
            }

            for (int j = 0; j < keypad.GetLength(1); j++) // iterate through columns
            {
                tempList.Add(new List<int> { 0, -j }); //left
                tempList.Add(new List<int> { 0, j }); //right
            }

            // consider making utility class since used 3 places
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
