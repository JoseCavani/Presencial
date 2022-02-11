using System;

namespace _5.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dado1, dado2, contador1= 0, contador2 = 0; 
            var rand = new Random();
            Console.WriteLine("digite os nome do jogador 1 ");
            string nome1 =Console.ReadLine();
            Console.WriteLine("digite os nome do jogador 2 ");
            string nome2 = Console.ReadLine();
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                dado1 = rand.Next(0,6);
                dado2 = rand.Next(0,6);
                Console.Write($"{nome1}: {dado1} \n{nome2}: {dado2}");
                if (dado1 > dado2)
                {
                    Console.WriteLine($"\n{nome1} jogou {dado1} e venceu a {i + 1}ª rodada ");
                    contador1++;
                }
                else if (dado1 == dado2)
                    Console.WriteLine("\nhouve empate");
                else
                {
                    Console.WriteLine($"\n{nome2} jogou {dado2} e venceu a {i + 1}ª rodada ");
                    contador2++;
                }
                if (i == 2 && dado1 == dado2 && contador1 == contador2)
                {
                    Console.WriteLine("\nhouve um empate definitivo pressione um tecla para tentar novamente");
                    Console.ReadKey();
                    i = 1;
                    continue;
                }
                
            }
            if (contador1 > contador2)
                Console.WriteLine($"parabens {nome1}, voce ganhou");
            else
                Console.WriteLine($"parabens {nome2}, voce ganhou");
            Console.ReadKey();
        }
    }
}
