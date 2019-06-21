using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2___124
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int nacimiento;

            Console.WriteLine("Ingrese su Nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el año en el que nacio");
            nacimiento = int.Parse(Console.ReadLine());
            int edad = 2030 - nacimiento;

            Console.WriteLine($"Hola {nombre}, en el año 2030 tendras {edad} años");

            Console.ReadLine();
        }
    }
}
