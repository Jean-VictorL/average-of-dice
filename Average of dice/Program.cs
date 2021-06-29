using System;

namespace Average_of_dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many dice will be thrown? ");
            int number = Parse.GetNumber();
            Console.Write("What is the face of the dice? ");
            int face = Parse.GetNumber();
            Console.Write("What is the bonus throw? ");
            int bonus = Parse.GetNumber();

            //Console.Write("Write the dice formula: ");
            //string formula = Console.ReadLine();


            AverageOfDice DiceAverage = new AverageOfDice(number, face, bonus);
            int result = DiceAverage.Result();
            Console.WriteLine("The average result of this role is: " + result);
            Console.ReadLine();
        }
    }
}
