using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 'M' (masculino) ou 'F' (feminino) ");
            char Letra = char.Parse(Console.ReadLine());
            if(Letra == 'M' || Letra == 'm')
            {
                Console.WriteLine("Masculino");
            }
            if(Letra == 'F' || Letra =='f')
            {
                Console.WriteLine("feminino");
            }
            if(Letra != 'M' && Letra != 'F' && Letra !='m' && Letra != 'f')
            {
                Console.WriteLine("Entrada Invalida");
            }
            

        }
    }
}
