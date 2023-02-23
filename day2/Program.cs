using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите R ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("\nРадиус R: {0}. \nДлина окружности L: {1}. \nПлощадь круга S: {2}.\n", R, (2 * Math.PI * R).ToString("0.##"), (Math.PI * Math.Pow(R, 2)).ToString("0.##"));

        }
    }
}
