using System;

namespace Programacao_Estruturada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            int Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            int Numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um numero");
            int Numero3 = int.Parse(Console.ReadLine());

            if(Numero1 > Numero2 && Numero2 > Numero3)
            {
                Console.WriteLine(Numero1 +" > " + Numero2 + " > " + Numero3);
            }
            if (Numero1 > Numero2 && Numero2 > Numero3)
            {
                Console.WriteLine(Numero1 + " > " + Numero3 + " > " + Numero2);
            }
            if (Numero2 > Numero1 && Numero1 > Numero3)
            {
                Console.WriteLine(Numero2 + " > " + Numero1 + " > " + Numero3);
            }
            if (Numero2 > Numero1 && Numero1 > Numero3)
            {
                Console.WriteLine(Numero2 + " > " + Numero3 + " > " + Numero1);
            }
            if (Numero3 > Numero1 && Numero1 > Numero2)
            {
                Console.WriteLine(Numero3 + " > " + Numero1 + " > " + Numero2);
            }
            if (Numero3 > Numero2 && Numero2 > Numero1)
            {
                Console.WriteLine(Numero3 + " > " + Numero2 + " > " + Numero1);
            }
            

        }
    }
}
