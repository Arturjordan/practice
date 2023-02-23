using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            double x = double.Parse(Console.ReadLine());
            double p = 3.14;
            if (x <= p)
            {
                double y = x + (2*x)*(Math.Sin(x)) * (3*x);
                Console.WriteLine(y);
            }
            else if (x > p)
            {
                double y = Math.Cos(x) + 2;
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
