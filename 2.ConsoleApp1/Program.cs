using System;

namespace _1.ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool sucesso;
        volta:
            Console.WriteLine("largura do retangulo: ");
            sucesso = decimal.TryParse(Console.ReadLine(), out decimal largura);
            if (sucesso == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("numero invalido");
                Console.ReadKey();
                Console.ResetColor();
                goto volta;
            }
        volta2:
            Console.WriteLine("altura do retangulo: ");
            sucesso = decimal.TryParse(Console.ReadLine(), out decimal altura);
            if (sucesso == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("numero invalido");
                Console.ReadKey();
                Console.ResetColor();
                goto volta2;
            }
            for (int i = 0; i < altura; i++)
            {
                for (int z = 0; z < largura; z++)
                {
                    if (i % 2 == 0)
                    Console.Write("A");
                    else
                        Console.Write("B");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}

