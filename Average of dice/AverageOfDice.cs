using System;
using System.Collections.Generic;
using System.Text;

namespace Average_of_dice
{
    class AverageOfDice
    {
        public int numberOfDice { get; set; }
        public int diceFaces { get; set; }
        public int bonus { get; set; }

        private int iterations = 10000000;

        public AverageOfDice(int numberOfDice, int diceFaces, int bonus)
        {
            this.numberOfDice = numberOfDice;
            this.diceFaces = diceFaces;
            this.bonus = bonus;
        }

        public int Result()
        {
            var random = new Random();
            int isum = 0;
            int sum = 0;
            using (var progress = new ProgressBar())
            {
                for (int i = 0; i < iterations; i++)
                {
                    for (int j = 0; j < numberOfDice; j++)
                    {
                        int roll = random.Next(1, diceFaces + 1);
                        isum += roll;
                    }
                    isum += bonus;
                    sum += isum;
                    isum = 0;
                    progress.Report((double)i / iterations);
                }
            }
            double iaverage = sum / iterations;
            int average = (int)Math.Round(iaverage);
            return average;
        }
    }
}

