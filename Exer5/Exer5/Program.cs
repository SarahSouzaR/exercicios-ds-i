using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer5
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string verdade = "maior de idade", falso = "menor de idade";

            Console.Write("\n Decubra se você é maior de idade! \n \n ");
            Console.Write("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("\n \n Sua idade é de {0} anos. \n \n Você é ", idade);
            Console.Write(idade >= 18 ? verdade : falso);

            Console.ReadKey();
        }
    }
}
