using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int> { 1, 4, 8, 8, 9, 3,4,6 };
            List<int> b = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> common = CommonItens(a, b);

            foreach (int x in common)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

        static List<int> CommonItens(List<int> a, List<int> b)
        {
            a.Sort();
            b.Sort();

            int i, j;
            i = j = 0;
            List<int> common = new List<int>();

            while (i < a.Count && j < b.Count)
            {
                if (a[i] == b[j])
                {
                    common.Add(a[i]);
                    i++;
                    j++;
                }
                else if (a[i] < b[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return common;
        }
    }
}
