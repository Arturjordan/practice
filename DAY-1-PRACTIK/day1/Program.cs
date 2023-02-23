using System;

namespace day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вещественное число a: ");
            double a = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Введите вещественное число b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = a + b;
            Console.WriteLine(Math.Round(c, 2));

            Console.ReadLine();
        }
    }
}
