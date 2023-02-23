using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int M = int.Parse(Console.ReadLine());
            double A = 0;
            double B = 0;
            double H = (B - A) / M;
            double x = 0;
            x = x + H;
            for (int i = 1; i <= M; i++)
            {
                double y = Math.Sin(x) - Math.Cos(x);
                Console.WriteLine($"{i} - " + y);
                x = x + H;
            }
            Console.ReadLine();
        }
    }
}
