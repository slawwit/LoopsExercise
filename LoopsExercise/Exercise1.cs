using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsExercise
{
    internal class Exercise1
    {
        int count = 0;        
        public void PrimeNumbers()
        {
            for (int i = 0; i < 101; i++)
            {
                if (i > 1)
                {
                    for (int j = 2; j <= i; j++)
                    {
                        if (i % j == 0 && i!=j)
                        {
                           break;
                        }
                        else if (i == j)
                        {
                            count++;
                        }
                                              
                    }                    
                }
            }
            Console.WriteLine($"W zakresie 0-100 jest {count} liczb pierwszych.");
        }
    }
}
