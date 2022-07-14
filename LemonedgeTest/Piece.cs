using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest
{
    public class Piece
    {
        public string name { get; set; }
        public Dictionary<char, List<List<int>>> validMoves { get; set; }
        public int count { get; set; }
        public char[,] keypad { get; set; }
        public List<List<int>> moves { get; set; }
        public int numberCount { get; set; }

        // methods more associated with movement, consider refactoring to be able to associate better
        public void GetCount()
        {
            for (int i = 0; i < keypad.GetLength(0); i++) // iterate through rows
            {
                for (int j = 0; j < keypad.GetLength(1); j++) //iterate through columns
                {
                    List<List<List<int>>> output = new List<List<List<int>>>();
                    CountNumbers(i, j, numberCount, 1, output);
                }
            }
        }

        public void CountNumbers(int currRow, int currCol, int length, int loop, List<List<List<int>>> output)
        {
            //if length is 1, then starting point makes number of 1, no loop needed
            if (length == 1)
            {
                count += 1;
                return;
            }
            // final loop count up all of the final arrays since all possible make num of correct length
            if (loop == length)
            {
                //Console.WriteLine(keypad[currRow, currCol]);
                count += output[loop - 1].Count;
                loop = 1; // reset loop
                return;
            }
            // first loop add start point's valid moves to output and next set, so 0 and 1
            if (loop == 1)
            {
                List<List<int>> tempList = new List<List<int>>();
                tempList.Add(new List<int>() { currRow, currCol });
                if (Rules.IsValid(keypad[currRow, currCol], 0))
                {
                    output.Add(tempList);
                } else
                {
                    // if invalid, no numbers can be built
                    return;
                }
                
                try
                {
                    
                    output.Add(validMoves[keypad[currRow, currCol]]);
                }
                catch
                {
                    //if no possible move remain, number cannot reach length
                    return;
                }

            }
            else
            // all other loops until final go through previous loop's potential choices to get next series
            {
                List<List<List<int>>> tempList = new List<List<List<int>>>();
                for (int i = 0; i < output[loop - 1].Count; i++)
                {
                    try
                    {
                        if (Rules.IsValid(keypad[output[loop - 1][i][0], output[loop - 1][i][1]], 1))
                        {
                            //push all of the loop's options
                            tempList.Add(validMoves[keypad[output[loop - 1][i][0], output[loop - 1][i][1]]]);
                        }
                        
                    }
                    catch
                    {
                        //if no valid moves before length hit, no valid numbers can be made so exit
                        return;
                    }

                }
                // then flatten them all so all options for that loop stay on same series
                List<List<int>> flatList = tempList.SelectMany(x => x).ToList();
                output.Add(flatList);
            }
            loop++;
            CountNumbers(currRow, currCol, length, loop, output);
        }

        public void GenerateValidMoves()
        {
            //Dictionary<char, List<List<int>>> validMoves = new Dictionary<char, List<List<int>>>();
            for (int i = 0; i < keypad.GetLength(0); i++) // iterate through rows
            {
                for (int j = 0; j < keypad.GetLength(1); j++) //iterate through columnd
                {
                    for (int k = 0; k < moves.Count; k++) // iterate through moves
                    {
                        ValidMoveFromPosition(i, j, i + moves[k][0], j + moves[k][1]);
                    }
                }
            }
            //return validMoves;
        }



        public void ValidMoveFromPosition(int rowStart, int colStart, int rowNext, int colNext)
        {
            int nextMoveRow = rowNext;
            int nextMoveCol = colNext;
            // checks if current move valid
            //if (Rules.IsValid(keypad[rowStart, colStart], 0)
            //    && nextMoveRow < keypad.GetLength(0) && nextMoveRow >= 0 // checking if next move oob for row, only moves row on pawn
            //    && nextMoveCol < keypad.GetLength(1) && nextMoveCol >= 0
            //    && Rules.IsValid(keypad[nextMoveRow, nextMoveCol], 1))
            if (
                 nextMoveRow < keypad.GetLength(0) && nextMoveRow >= 0 // checking if next move oob for row, only moves row on pawn
                && nextMoveCol < keypad.GetLength(1) && nextMoveCol >= 0
                )
            {
                // if no entry for current value, add it and push coordinates to list
                if (!validMoves.ContainsKey(keypad[rowStart, colStart]))
                {
                    validMoves.Add(keypad[rowStart, colStart], new List<List<int>>());
                    validMoves[keypad[rowStart, colStart]].Add(new List<int> { nextMoveRow, nextMoveCol });
                }
                // if it does push next move coordinate to list
                else
                {
                    validMoves[keypad[rowStart, colStart]].Add(new List<int> { nextMoveRow, nextMoveCol });
                }
            }
        }

    }
}
