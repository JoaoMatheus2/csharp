using System;

namespace tratamento_erros_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.Write("Digite um numero..:");
            try
            {
                numero = int.Parse(Console.ReadLine());
                for (int i = 1; i <= 9; i++)
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
            catch (Exception erro_ocorreu)
            {
                Console.WriteLine("Você deve digitar um numero");
            }
            finally
            {
                Console.WriteLine("Aperte qualquer tecla");
                Console.ReadKey();
            }
        }
    }
}
