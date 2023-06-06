using System;
class Programa
{
    static void Main()
    {
        int num, i = 1;

        Console.WriteLine("Digite um número inteiro positivo: ");
        num = int.Parse(Console.ReadLine());


        while (i <= num)
        {

            Console.WriteLine( i + " "); i++;

        }
    }

}