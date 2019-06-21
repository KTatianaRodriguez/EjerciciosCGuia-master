using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___98
{
    class Program
    {
        static void Main(string[] args)
        {
            float gradosC = 0;

            Console.WriteLine("Digite los grados Centigrados");

            gradosC = int.Parse(Console.ReadLine());
            CGrados grados = new CGrados();
            Console.WriteLine(CGrados.obtenerfahrenheit(gradosC));

            Console.ReadLine();

            gradosC = 0;

            Console.WriteLine(CGrados.obtenerfahrenheit(gradosC));

            Console.ReadLine();
        }
    }
}
