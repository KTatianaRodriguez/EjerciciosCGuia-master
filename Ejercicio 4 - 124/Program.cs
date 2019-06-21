using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4___124
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, c;
            double respuesta;

            Console.WriteLine("ingrese el valor de x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor de c");
            c = int.Parse(Console.ReadLine());


            respuesta = (a * x * x * x * x * x) - (b * x * x * x) + (c * x) - 7;

            Console.WriteLine(respuesta);
            Console.ReadLine();
        }
    }
}
