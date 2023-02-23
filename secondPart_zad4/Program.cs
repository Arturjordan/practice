using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите курс доллара: ");
            double kurs = double.Parse(Console.ReadLine());
            Console.WriteLine("\nfor\n");
            for (int i = 5; i <= 120; i += 5)
                Console.WriteLine("{0} долларов - {1} рублей", i, i * kurs);
            Console.WriteLine("\nwhile\n");
            int j = 5;
            while (j <= 120)
            {
                Console.WriteLine("{0} долларов - {1} рублей", j, j * kurs);
                j += 5;
            }
            Console.WriteLine("\ndo while\n");
            int k = 0;
            do
            {
                k += 5;
                Console.WriteLine("{0} долларов - {1} рублей", k, k * kurs);
            }
            while (k < 120);

            Console.Write("Нажмите что-нибудь чтобы продолжить ...");
            Console.ReadKey(true);
        }
    }
}
