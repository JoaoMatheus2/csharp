using System;

namespace tabuada_laco_repeticao_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());
            int i = 1;
            while (i <= 9)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                i++;
            }
        }
    }
}
