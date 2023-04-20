using System;

namespace LoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz numer zadania: ");
            Console.WriteLine("1: Zadanie_1 ");
            Console.WriteLine("2: Zadanie_2 ");
            Console.WriteLine("3: Zadanie_3 ");
            Console.WriteLine("4: Zadanie_4 ");
            Console.WriteLine("5: Zadanie_5 ");
            Console.WriteLine("------------------------");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            switch (option)
            {
                case 1:
                    Exercise1 exercise1 = new Exercise1();
                    exercise1.PrimeNumbers();
                    break;
                case 2:
                    Exercise2 exercise2 = new Exercise2();
                    exercise2.EvenNubers();
                    break;
                case 3:
                    Exercise3 exercise3 = new Exercise3();
                    exercise3.Fibonacci();
                    break;
                case 4:
                    Exercise4 exercise4 = new Exercise4();
                    exercise4.PrintingNumbers();
                    break;
                case 5:
                    Exercise5 exercise5 = new Exercise5();
                    exercise5.Exponentiation();
                    break;

                default:
                    Console.WriteLine("Wybierz poprawny numer zadania!");
                    break;
            }
           
        }
    }
}
