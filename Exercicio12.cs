using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador = 0;
            int Maior = 0;
            while(Contador < 5)
            {
                Console.WriteLine("Digite um numero: ");
                int Numero = int.Parse(Console.ReadLine());
                if(Numero > Maior)
                {
                    Maior = Numero;
                }
                Contador++;
            }
            Console.WriteLine("Maior = " + Maior);
        }
    }
}
