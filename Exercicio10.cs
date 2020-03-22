using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int Numero = int.Parse(Console.ReadLine());

            if (Numero == 1)
            {
                Console.WriteLine("Domingo!");
            }
            else if (Numero == 2)
            {
                Console.WriteLine("Segunda!");
            }
            else if (Numero == 3)
            {
                Console.WriteLine("Terca!");
            }
            else if (Numero == 4)
            {
                Console.WriteLine("Quarta!");
            }
            else if (Numero == 5)
            {
                Console.WriteLine("Quinta!");
            }
            else if (Numero == 6)
            {
                Console.WriteLine("Sexta!");
            }
            else if(Numero == 7)
            {
                Console.WriteLine("Sabado!");
            }
            else
            {
                Console.WriteLine("Entrada invalida!");
            }   

            }
    }
}
