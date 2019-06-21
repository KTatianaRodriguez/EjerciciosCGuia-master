using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosC
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3, c = 1, d, e;
            float x, y;
            x = a / b;
            // "c= a<b && c" El operador && no se puede utilizar dentro de una variable int,double o float
            if ((a < b) && (a < c))
            {
                // En este caso se debe establecer una condicion
            }
            else
            {
                // En este caso se debe establecer una condicion
            }


            d = a + b++;
            e = ++a - b;
            y = a / b; // "y=(float)a / b" el tipo de dato debe ser definido al declarar la variable. 

        }
    }
}
