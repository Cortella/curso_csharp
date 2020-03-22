using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int Numero = int.Parse(Console.ReadLine());
            int Contador = 0;
            while(Contador <= 10)
            {
                Console.WriteLine(Numero + " X " + Contador + " = " + Numero*Contador);
                Contador++;
            }
        }
    }
}
