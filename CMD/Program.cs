using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.writeLine("Ingrese un numero");
            int num = Convert.ToInt32(Console.ReadLine);
            Console.writeLine("Ingrese otro numrro");
            int num2 = Convert.ToInt32(Console.ReadLine);
            Console.writeLine("El MCD de los numeros es " + Convert.ToInt32(MCD(num, num2)));
            if (num == 00 || num2 == 00)
            {
                break;
            }
        }
    }
    
    public int MCD (int num, int num2)
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

