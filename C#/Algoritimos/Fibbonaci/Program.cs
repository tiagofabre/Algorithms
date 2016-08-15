using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonaci
{
    class Program
    {
        static float x = 0;
        static float y = 1;
        static float z = 0;
        static void Main(string[] args)
        {
            for (int counter = 0; counter <= 100; counter++)
                Console.WriteLine("Fibonacci of "+ counter + " is: " + RecursiveFibo(counter) );

            Console.ReadLine();
        }

        static void Fibo(){

            for (int i = 1; i < 20; i++)
            {
                Console.WriteLine(y);

                z = y;
                y = x + y;
                x = z;
            }

            Console.ReadLine();
        }

        static int RecursiveFibo(int n)
        {
            if (n < 2)
                return n;
                
            return RecursiveFibo(n-1)+RecursiveFibo(n-2);
        }

    }
}
