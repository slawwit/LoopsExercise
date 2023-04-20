using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise4
    {
        public void PrintingNumbers()
        {
            Console.WriteLine("Podaj liczbę całkowitą: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            int num = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (num > number)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(num + " ");
                        num++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
