using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro numrro");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El MCD de los numeros es " + (MCD(num, num2)).ToString());
            if (num == 00 || num2 == 00)
            {
                break;
            }
        }
    }
    
    public static int MCD (int num, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num % num2;
            num = temp;
        }
        return num;

    }


}

