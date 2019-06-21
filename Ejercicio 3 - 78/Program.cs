using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___78
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, c = 2, k = 3;
            double b = -1.17, d = 3.5;
            double x = 10.5;
            double res, cuax, trix, dox;

            cuax = Math.Pow(x, 4);
            trix = Math.Pow(x, 3);
            dox = Math.Pow(x, 2);

            res = ((a * cuax) + (b * trix) + (c * dox) + (d * x) + (k));
            Console.WriteLine($"{res}");
            Console.ReadLine();
        }
    }
}
