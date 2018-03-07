using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();

            Console.Write("\n \n Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("\n \n Digite a cidade em que você reside: ");
            cidade = Console.ReadLine();

            Console.WriteLine("\n \n {0} tem {1} anos e reside em {2}.", nome, idade, cidade);

            Console.ReadKey();

        }
    }
}
