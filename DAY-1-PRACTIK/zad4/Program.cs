using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Время, Скорость и Ускорение");
            double t = Convert.ToInt32(Console.ReadLine());
            double v0 = Convert.ToInt32(Console.ReadLine());
            double a = Convert.ToInt32(Console.ReadLine());
            double v = v0 + a * t;
            double s = v * t;
            Console.WriteLine("Скорость =" + v );
            Console.WriteLine("Расстяние =" + s);

            Console.ReadLine();
        }
    }
}
