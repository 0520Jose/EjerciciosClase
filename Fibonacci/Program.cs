using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("- Ingresa que metodo de Fibonacci quieres usar: ");
            Console.WriteLine("1. FibonacciMemorizado");
            Console.WriteLine("2. FibonacciRecursivo");
            int metodo = Convert.ToInt32(Console.ReadLine());
            if (metodo == 1)
            {
                Console.WriteLine("- Ingresa hasta que termino de la serie de FibonacciMemorizado quiere calcular: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] memoria = new int[n + 1];
                for (int i = 0; i < n + 1; i++)
                {
                    memoria[i] = -1;
                }
                Console.WriteLine("El termino " + n.ToString() + " en FibonacciMemorizado es: ");
                Console.WriteLine(FibonacciMemorizado(n-1, memoria));
                if (n == 0)
                {
                    break;
                }
            }
            else if (metodo == 2)
            {
                Console.WriteLine("- Ingresa hasta que termino de la serie de FibonacciRecursivo quiere calcular: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El termino " + n.ToString() + " en FibonacciRecursivo es: ");
                int i;
                for (i = 0; i < n; i++)
                {
                    FibonacciRecursivo(i);
                }
                Console.WriteLine(FibonacciRecursivo(i-1));
                if (n == 0)
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
            
        }
    }

    public static int FibonacciRecursivo(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        return FibonacciRecursivo(n - 1) + FibonacciRecursivo(n - 2);
    }

    public static int FibonacciMemorizado(int n, int[] memoria)
    {
        if (memoria[n] != -1)
        {
            return memoria[n];
        }
        if (n <= 1)
        {
            memoria[n] = n;
            return memoria[n];
        }
        else
        {
            memoria[n] = FibonacciMemorizado(n - 1, memoria) + FibonacciMemorizado(n - 2, memoria);
        }
        return memoria[n];
    }

}
