using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите номер месяца: ");
                int MonthNomber = int.Parse(Console.ReadLine());
                Console.Write("Введите порядковый номер дня: ");
                int DayNomber = int.Parse(Console.ReadLine());

                switch (MonthNomber)
                {
                    case 1: case 3: case 5: case 7: case 8: case 10: case 12: Console.WriteLine("До конца месяца {0} дней.", GetDays(31, DayNomber)); break;
                    case 4: case 6: case 9: case 11: Console.WriteLine("До конца месяца {0} дней.", GetDays(30, DayNomber)); break;
                    case 2: Console.WriteLine("До конца месяца {0} или {1} дней.", GetDays(28, DayNomber), GetDays(29, DayNomber)); break;
                }

                Console.ReadKey();
            }
        }
        static public int GetDays(int MonthDays, int DayNomber)
        {
            return MonthDays - DayNomber;
        }
    }
}
