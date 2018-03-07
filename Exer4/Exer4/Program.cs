using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, exp;
            
            Console.Write("Entre com as variáveis e o resultado de A^2 * 5 - C / (B - A % 4)");

            Console.Write("\n \n A = ");
            a = double.Parse(Console.ReadLine());

            Console.Write("\n B = ");
            b = double.Parse(Console.ReadLine());

            Console.Write("\n C = ");
            c = double.Parse(Console.ReadLine());

            exp = ((Math.Pow(a, 2)) * 5 - c) / (b - (a % 4));

            Console.Write("\n \n O resultado da sua expressão é de: {0}.", exp);

            Console.ReadKey();
        }
    }
}
