using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondPart_Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 100 && a < 1000)
            {
                int firstNumber = a / 100;
                int secondNumber = ((a - (a / 100) * 100)) / 10;
                int thirdNumber = a % 10;
                if (firstNumber != secondNumber && firstNumber != thirdNumber && secondNumber != thirdNumber)
                {
                    Console.WriteLine($"first = {firstNumber * 100 + secondNumber * 10 + thirdNumber}");
                    Console.WriteLine($"second = {firstNumber * 100 + secondNumber + thirdNumber * 10}");
                    Console.WriteLine($"third = {firstNumber + secondNumber * 10 + thirdNumber * 100}");
                    Console.WriteLine($"fourth = {firstNumber * 10 + secondNumber + thirdNumber * 100}");
                    Console.WriteLine($"fifth = {firstNumber * 10 + secondNumber * 100 + thirdNumber}");
                    Console.WriteLine($"sixth = {firstNumber + secondNumber * 100 + thirdNumber * 10}");
                }
            }
            else
            {
                Console.WriteLine("Число не является трехзначным! ");
            }
            Console.ReadLine();
        }
    }
}
