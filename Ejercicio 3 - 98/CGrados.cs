using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3___98
{
    class CGrados
    {
        // definicion de constantes
        const int limInferior = -50;
        const int limSuperior = 120;
        const int incremento = 5;

        public static float obtenerfahrenheit(float gradosC)
        {
            //retornar los grados fahrenheit equivalentes a gradosC
            return 9F / 5F * gradosC + 32;
        }
        public static void Main(string[] args)
        {
            //Declaracion de variables
            int gradosCent = limInferior;
            float gradosfahr = 0;

            while (gradosCent <= limSuperior)
            {
                // obtener los grados fahrenheit equivalentes a gradoscent
                gradosfahr = obtenerfahrenheit(gradosCent);
                // escribir la siguiente linea de la tabla 
                System.Console.WriteLine("(0. 8:d) C (1. 8:f2)", gradosCent, gradosfahr);
                // siguiente valor
                gradosCent += incremento;
                Console.ReadLine();
            }

        }
    }
}
