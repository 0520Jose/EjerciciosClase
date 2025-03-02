using System;

namespace Mochila
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] valores = { 60, 100, 120 };
            int[] pesos = { 10, 20, 30 };
            int capacidad = 50;
            int n = valores.Length;
            Console.WriteLine(Mochila(capacidad, pesos, valores, n));
        }

        public static int Mochila(int capacidad, int[] pesos, int[] valores, int n)
        {
            if (n == 0 || capacidad == 0)
            {
                return 0;
            }

            if (pesos[n - 1] > capacidad)
            {
                return Mochila(capacidad, pesos, valores, n - 1);
            }
            else
            {
                return Math.Max(valores[n - 1] + Mochila(capacidad - pesos[n - 1], pesos, valores, n - 1), Mochila(capacidad, pesos, valores, n - 1));
            }
        }
    }
}