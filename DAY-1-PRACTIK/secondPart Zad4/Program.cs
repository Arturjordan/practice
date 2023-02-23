using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_Zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m ");
            double m = Convert.ToInt32(Console.ReadLine());
            double z2 = -Math.Sqrt(m);
            Console.WriteLine(z2);
            Console.ReadLine();
        }
    }
}
