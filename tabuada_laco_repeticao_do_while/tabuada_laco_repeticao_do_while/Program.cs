using System;

namespace tabuada_laco_repeticao_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());
           
            
            int i = 1;
            do
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                i++;
            } while (1 <= 9);

            Console.ReadKey();
        }   
    }
}
