using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest
{
    public class Phone
    {
        public char[,] keypad;

        public Phone()
        {
            keypad = new char[4, 3]
            {
                {'1', '2', '3' },
                {'4', '5', '6' },
                {'7', '8', '9' },
                {'*', '0', '#' }
            };

            //keypad = new char[3, 1]
            //{
            //    {'1' },
            //    {'4' },
            //    {'7' },
            //};
        }
    }
}
