using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueIteminList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1,2,3,4,3,2,1 };
            Console.WriteLine(UniqueItemOnce(array));
            Console.ReadLine();
        }
        static int UniqueItemOnce(List<int> a) {

            int k = a[0];
            for (int i=1; i < a.Count; i++)
            {
                //XOR OPERTOR (1^1)^(2^2)^(3^3)^4 = 4
                k ^= a[i];
            }

            return k;
        }
    }
}
