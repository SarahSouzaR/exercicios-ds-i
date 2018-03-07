using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num, res;

            Console.Write(" --- Quadrado do número desejado ---");
            Console.Write("\n \n Digite um número: ");
            num = int.Parse(Console.ReadLine());

            res = Math.Pow(num, 2);

            Console.Write("\n \n O quadrado de {0} é: {1}.", num, res);

            Console.ReadKey();

        }
    }
}
