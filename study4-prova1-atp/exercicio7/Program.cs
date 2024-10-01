using System;
class Program
{
    public static void Main()
    {
        double gastos, media, maior = 0, total = 0;
        int qtd = 0;
        do
        {
            Console.WriteLine("Insira o valor gasto");
            gastos = double.Parse(Console.ReadLine());
            if (gastos != 0)
            {
                qtd++;
                total += gastos;
                if (maior < gastos)
                {
                    maior = gastos;
                }
            }
        } while (gastos != 0);
        media = total / (double)qtd;
        Console.WriteLine("O valor total é " + total);
        Console.WriteLine("O maior gasto é " + maior);
        Console.WriteLine("A media dos gastos é " + media);
    }
}