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
        public char[,] keypad { get; set; }
        public List<List<int>> moves { get; set; }
    }
}
