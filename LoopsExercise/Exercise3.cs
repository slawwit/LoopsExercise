using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise3
    {
        public void Fibonacci()
        {

            Console.WriteLine("Podaj długość ciągu.");

            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            int a = 1;
            int b = 0;
            int c = 0;
            for(int i = 0; i < length; i++)
            {
                Console.Write($"{c}, ");
                c = a + b;
                a = b;
                b = c;

            }

        }
    }
}
