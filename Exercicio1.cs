using System;

namespace Programacao_Estruturada
{
    class Exercicio1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Antecessor = "+ (numero-1));
        }
    }
}
