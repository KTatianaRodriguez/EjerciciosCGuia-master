using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___124
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 0;
            double v = 0;
            Console.WriteLine("Digite el radio de la esfera");
            radio = double.Parse(Console.ReadLine());
            v = (4 / 3 * 3.1416) * (radio * radio * radio);

            Console.WriteLine($"El volumen total de la esfera es de {v}");

            Console.ReadLine();
        }
    }
}
