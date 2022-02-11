using System;

namespace _3.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var horaAtual = DateTime.Now.TimeOfDay;

            if ((horaAtual > new TimeSpan(6, 0, 0)) && (horaAtual < new TimeSpan(12, 0, 0)))
            {
                Console.WriteLine("Bom Dia");
            }
            else if ((horaAtual > new TimeSpan(12, 0, 0)) && (horaAtual < new TimeSpan(18, 0, 0)))
            {
                Console.WriteLine("Boa Tarde");
            }
            else
                Console.WriteLine("Boa Noite");
            Console.ReadKey();
        }
    }
}
