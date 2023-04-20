using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise6
    {
       
        public void StrangeSum()
        { 
            double sum = 0;
            double result = 0;

            for (double i = 1; i < 21; i++)
            {
                if (i == 1)
                {
                    Console.Write($"1");
                    result = 1;
                }
                else
                {
                    result = 1 / i;
                    Console.Write($" + 1/{i}");
                }
               
                sum += result;
            }

            Console.WriteLine($" = {sum}");
        }
    }
}
