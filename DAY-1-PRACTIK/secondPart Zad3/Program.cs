using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите m ");
            double m = Convert.ToInt32(Console.ReadLine());
            double z1 = (Math.Sqrt(Math.Pow(((3 * m) + 2), 2) - 24 * m) / ((3 * Math.Sqrt(m)) - (2 / Math.Sqrt(m))));
            Console.WriteLine(Math.Round(z1, 2));
            Console.ReadLine();
        }
    }
}
