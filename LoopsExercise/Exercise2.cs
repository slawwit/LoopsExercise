using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise2
    {
        public void EvenNubers()
        {
            int a = 0;
            Console.WriteLine("Liczby parzyste z przedziału 0-1000: ");
            do
            {
                if(a % 2 == 0 )
                {
                    Console.Write($"{a}, ");
                }
                a++;

            }
            while (a < 1001);

        }
    }
}
