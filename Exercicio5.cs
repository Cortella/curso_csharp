using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            int PrimeiroNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundoo numero: ");
            int SegundoNumero = int.Parse(Console.ReadLine());

            if(PrimeiroNumero > SegundoNumero)
            {
                Console.WriteLine(PrimeiroNumero  + " > " + SegundoNumero);
            }
            if(PrimeiroNumero < SegundoNumero)
            {
                Console.WriteLine(SegundoNumero + " > " + PrimeiroNumero);
            }
            if(PrimeiroNumero == SegundoNumero)
            {
                Console.WriteLine("Os numeros sao iguais");
            }
        }
    }
}
