using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digitel el valor de a");
            double a1 = double.Parse(Console.ReadLine());
            Console.Write("digitel el valor de b");
            double a2 = double.Parse(Console.ReadLine());
            Console.Write("digitel el valor de c");
            double a3 = double.Parse(Console.ReadLine());
            Console.Write("digitel el valor de d");
            double a4 = double.Parse(Console.ReadLine());
            Console.Write("digitel el valor de x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Class1 cls = new Class1(a1, a2, a3, a4);
            Console.WriteLine("el resultado es" + cls.valorp(x));

            Console.ReadLine();

        }
    }
}
