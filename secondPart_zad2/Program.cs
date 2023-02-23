using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a, b, c: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a >= b + c || b >= a + c || c >= b + a)
            {
                Console.WriteLine("Это не треугольник! ");
                
                // это вообще не треугольник
                // ...
            }
            else if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == b * b + a * a)
            {
                Console.WriteLine("Это прямоугольник! ");
                //прямоугольный
                // ...
            }
            else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > b * b + a * a)
            {
                Console.WriteLine("Это тупоугольник! ");
                //тупоугольный
                // ...
            }
            else
            {
                Console.WriteLine("Это остроугольник! ");
                //остроугольный
                // ...
            }
            Console.ReadLine(); 
        }
    }
}
