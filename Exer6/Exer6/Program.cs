using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, cot, resul;

            Console.Write("\n Verifique a conversão do seu valor em Reais para Dólares.\n \n");

            Console.Write(" Digite a quantia em Reais: ");
            R = double.Parse(Console.ReadLine());

            Console.Write("\n Digite a cotação atual do dólar: ");
            cot = double.Parse(Console.ReadLine());

            resul = R / cot;

            Console.Write("\n \n O seu valor é de R$ {0}. Equivalente a US$ {1}.", R, resul);

            Console.ReadKey();
        }
    }
}
