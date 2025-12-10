using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.lib
{
    public static class SquareRoot
    {
        public static double SQRT(double number)
        {
            if (number < 0)
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");

            if (number == 0)
                return 0;

            double aproximacion = number;
            double precision = 0.000001; // margen de error permitido

            while (true)
            {
                double siguiente = 0.5 * (aproximacion + number / aproximacion);

                if (Math.Abs(siguiente - aproximacion) < precision)
                    return siguiente;

                aproximacion = siguiente;
            }


            // return Math.Sqrt(number);
        }
    }
}
