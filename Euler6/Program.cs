using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler6
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n;
            uint.TryParse(args[0], out n);

            ulong s = SumOfIntegers(n);

            s = s * s - SumOfSquares(n);

            Console.WriteLine(s);
            Console.ReadLine();          

        }

        static ulong SumOfSquares(ulong n)
        {
            return n * (n + 1) * (2*n + 1) / 6;
        }

        static ulong SumOfIntegers(ulong n)
        {
            return n * (n + 1) / 2;
        }
    }
}
