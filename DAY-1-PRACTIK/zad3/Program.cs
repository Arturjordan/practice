using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 2.7;
            double y = ((Math.Log(x + Math.Sqrt(x * x + 9))) - ((x + 1) / (Math.Pow(Math.Atan(x), 3))));
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
