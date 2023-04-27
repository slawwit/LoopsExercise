using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise10
    {
        public void Nww()
        {
            int i = 0;
            int result = 0;
            Console.WriteLine("Wyznaczanie najmniejszej wspólnej wielokrotności dwóch liczb.");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int.TryParse(Console.ReadLine(), out int number1);
            Console.WriteLine("Podaj drugą liczbę: ");
            int.TryParse(Console.ReadLine(), out int number2);

            if (number1>number2)
            {
                i = number1;
            }
            else if (number2>number1)
            {
                i = number2;
            }
            while (result ==0)
            {
                int a = i % number1;
                int b = i % number2;
                if (a ==0 && b ==0)
                {
                    result = i; 
                }
                i++;
            }
            Console.WriteLine($"Najmniejsza wspólna wielokrotność liczb {number1} i {number2} to {result}.");
        }
    }
}
