using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonedgeTest
{
    public class Rules
    {
        
        //consider moving rules into list for better maintainability
        // numberPos is position of number in counting step
        public static bool IsValid(char button, int numberPos)
        {
            bool valid = false;
            // rules are: Cannot begin with 0 or 1
            // Cannot contain * or #
            if(numberPos == 0)
            { 
                if (button != '1' && button != '0' && button != '*' && button != '#')
                {
                    valid = true;
                }
                
            } else
            {
                if(button != '*' && button != '#')
                {
                    valid = true;
                }
            }


            return valid;
        }
    }
}
