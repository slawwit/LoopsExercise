using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise7
    {
        public void Diamond()
        {
            Console.WriteLine("Podaj Krótszą przekątną diamentu: ");
            int diagonal = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------");    
            
            for (int i = 1; i <= diagonal; i++)
            {
                for (int j = 1; j <= diagonal - i; j++)
                {
                    Console.Write(" ");                    
                }

                for (int k = 1; k <= i ; k++)
                {
                    Console.Write("* ");

                }
                Console.WriteLine();
            }

            for (int i = 1; i <= diagonal - 1; i++)
            {
                for (int j = 1; j <= diagonal -i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }                
            }
        }
    }
}
