using System;
using System.Globalization;

namespace Uri1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, velocidade;
            double litros;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            int distancia = tempo * velocidade;
            litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
