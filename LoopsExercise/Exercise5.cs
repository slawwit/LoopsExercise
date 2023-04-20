using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise5
    {
        public void Exponentiation()
        {
            int number = 1;

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"Liczba {i} do potęgi 3 = {Math.Pow(i,3)}");

            }
        }
    }
}
