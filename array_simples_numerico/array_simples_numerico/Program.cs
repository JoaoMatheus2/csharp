using System;

namespace array_simples_numerico
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[5];
            notas[0] = 6;
            notas[1] = 8;
            notas[2] = 7;
            notas[3] = 9;
            notas[4] = 5;
            // double soma = notas[0] + notas[1] + notas[2] + notas[3] + notas[4];
            // double media = soma / 5;

            double soma = notas.Sum();
            double media = notas.Average();
            
            Console.WriteLine("A soma das notas é " + soma);
           // Console.WriteLine("A média das notas é " + media);
            Console.ReadKey();
        }
    }
}
