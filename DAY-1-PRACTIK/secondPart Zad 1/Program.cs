using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_Zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минуты");
            double minute = Convert.ToInt32(Console.ReadLine());
            double hours = Convert.ToInt32(minute / 60);
            double smin = Convert.ToInt32(minute % 60);
            Console.WriteLine(minute + " мин - это " + hours + " чаc " + smin + " минут ");
            Console.ReadLine();
        }
    }
}
