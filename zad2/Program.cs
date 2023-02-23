using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metka: Console.WriteLine("Введите четырехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 1000 && a < 10000)
            {
               
            else
                {
                    Console.WriteLine("Не вверный ввод");
                    goto metka;
                }
            } 
        }
    }
}
