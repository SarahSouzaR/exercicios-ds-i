using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Digite um número para saber o resultado do dobro dele: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\n \n O resultado é: {0}", a += a);

            Console.ReadKey();

        }
    }
}
