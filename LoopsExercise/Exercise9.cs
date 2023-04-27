using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise9
    {
        public void ConvertToBinary()
        {
            Console.WriteLine("Podaj liczbę do zamiany na binarną: ");

            string numberInput = Console.ReadLine();
            int.TryParse(numberInput, out int number);
            string result = string.Empty;
            int resultModulo;

            do
            {
                resultModulo = number % 2;
                number = number / 2;
                result = resultModulo + result;
            }
            while (number > 0);
            Console.WriteLine($"W formie binarnej to: {result}");
           
        }
    }
}
