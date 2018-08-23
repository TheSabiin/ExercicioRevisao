using System;

namespace frutas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da fruta: ");
            var fruta = Console.Readline();
            Console.WriteLine();
            Console.WriteLine("Quantas vezes gostaria de repetir: ");
            var qtd = int.Parse(Console.ReadLine());

            var saida = string.Empty;
            for(int i = 0; i < qtd; i++)
            {
                if(saida.Lenght > 0)
                {

                    saida += " * ";
                    saida += fruta;
                }
                Console.WriteLine(saida);
            }

        }
    }
}
