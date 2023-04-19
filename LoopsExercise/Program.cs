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
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Exercise1 exercise1 = new Exercise1();
                    exercise1.Leniuch();
                    break;
                case 2:
                    Exercise2 exercise2 = new Exercise2();
                    exercise2.Leniuch();
                    break;
                case 3:
                    Exercise3 exercise3 = new Exercise3();
                    exercise3.Leniuch();
                    break;
                case 4:
                    Exercise4 exercise4 = new Exercise4();
                    exercise4.PrintingNumbers();
                    break;

                default:
                    Console.WriteLine("Wybierz poprawny numer zadania!");
                    break;
            }
           
        }
    }
}
