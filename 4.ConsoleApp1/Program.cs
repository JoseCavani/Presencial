using System;

namespace _4.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sucesso;
            decimal total = 0;
            int positivos = 0, negativos = 0;
            decimal[] valores = new decimal[5];
      for (int i = 0; i < 5; i++)
            {
                volta:
                Console.WriteLine($"Digite o {i+1} valor");
                sucesso = decimal.TryParse(Console.ReadLine(), out valores[i]);
                if (sucesso == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("numero invalido");
                    Console.ReadKey();
                    Console.ResetColor();
                    goto volta;
                }

            }
            foreach (var numero in valores)
            {
                total = numero + total;
                if (numero > -1)
                    positivos++;
                else
                    negativos++;
            }
            total = total / valores.Length;
            Console.WriteLine($"média aritmética : {total} \n numeros positivos : {positivos}\n" +
                $"numeros negativos : {negativos}");
            Console.ReadKey ();
        }
    }
}
