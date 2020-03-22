using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int Numero = int.Parse(Console.ReadLine());
            if(Numero >= 0)
            {
                Console.WriteLine("Numero Positivo ou nulo");
            }
            else
            {
                Console.WriteLine("Numero negativo");
            }
            
        }
    }
}
