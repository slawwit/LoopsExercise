using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise8
    {
        public void ReverseString()
        {
            Console.WriteLine("Podaj cią znaków do odwrócenia:");
            string str1 = Console.ReadLine().ToLower();
            string str2 = string.Empty;

            for (int i = str1.Length - 1; i >= 0; i--)
            {
                str2 = str2 + str1.ElementAt(i);
                if (i == str1.Length -1)
                {
                   str2 = str2.ToUpper();
                }                                            
            }
            Console.WriteLine(str2); 

        }
    }
}
