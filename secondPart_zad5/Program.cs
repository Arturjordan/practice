using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цену за 1 кг конфет - ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} - {count * i}");
            }
            Console.ReadLine();
        }
    }
}
