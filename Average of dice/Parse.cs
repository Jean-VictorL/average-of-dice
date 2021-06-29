using System;
using System.Collections.Generic;
using System.Text;

namespace Average_of_dice
{
    static class Parse
    {
        public static int GetNumber()
        {
            int number;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    return 0;
                }
                else if (!int.TryParse(input, out number))
                {
                    Console.WriteLine("Not a valid number");
                }
                else { break; }
            }
            return number;
        }
    }
}
