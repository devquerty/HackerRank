using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(80));
            Console.ReadLine();
        }

        static int Fibonacci(int n)
        {
            if (n <= 1)
                return 1;

            return Fibonacci(n-1) +  Fibonacci(n - 2);
        }
    }
}
