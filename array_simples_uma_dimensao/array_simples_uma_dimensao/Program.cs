using System;

namespace array_simples_uma_dimensao
{
    class Program
    {
        static void Main(string[] args)
        {
            // sintaxe = tipo [] nome_do_array = new tipo[tamanho_do_array];
            string[] nome = new string[3];
            nome[0] = "Neri ";
            nome[1] = "Aldoir ";
            nome[2] = "Neitzke";
            Console.WriteLine(nome[0] + nome[1] + nome[2]);
            Console.WriteLine(String.Concat(nome));
            Console.WriteLine("tamanho = "+nome.Length.ToString());
            Console.ReadKey();
        }
    }
}
