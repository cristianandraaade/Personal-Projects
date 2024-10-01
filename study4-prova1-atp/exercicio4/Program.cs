using System;
class Program
{
    public static void Main()
    {
        int numerosDigitados = 0, numerosNegativos = 0, somaPositivos = 0;
        int stop = 0;
        do
        {
            Console.WriteLine("Digite um número");
            numerosDigitados = int.Parse(Console.ReadLine());
                if (numerosDigitados < 0)
                {
                    numerosNegativos++;
                }
                else if (numerosDigitados > 0)
                {
                    somaPositivos += numerosDigitados;
                }
        } while (numerosDigitados != stop);
            Console.WriteLine("O número de negativos foi: " + numerosNegativos);
        Console.WriteLine("A soma dos positivos foi: " + somaPositivos);
    }
}