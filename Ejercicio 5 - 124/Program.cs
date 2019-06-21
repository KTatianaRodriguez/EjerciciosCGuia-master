using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5___124
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = "";// se cambio el tipo de dato de char a var

            Console.Write("caracter: ");
            car = Console.ReadLine();
            Console.WriteLine($"{car}"); // se llamo la variable

            // se eliminaron las 3 lineas de codigo que estaban repetidas

            Console.ReadLine();// se agrego un readline

        }
    }
}
