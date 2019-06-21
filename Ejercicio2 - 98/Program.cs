using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2___98
{
    class Program
    {
        static void Main(string[] args)
        {
            float gradosC = 0;

            Console.WriteLine("Digite los grados Centigrados");
            Console.ReadLine();

            gradosC = int.Parse(Console.ReadLine());
            CApGrados2 grados = new CApGrados2();
            Console.WriteLine(CApGrados2.obtenerfahrenheit(gradosC));

            Console.ReadLine();

            //Lo que sucede cuando se quita la F de la clase se cambian los valores de fahrenheit
        }
    }
}
