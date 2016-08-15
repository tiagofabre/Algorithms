using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyWithoutX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(10,100));
            Console.ReadLine();
        }

        static float Multiply(int a, int b)
        {
            float result = 0;

            for (int i=0; i < b; i++)
            {
                result += a;
            }

            return result;
        }
    }
}
