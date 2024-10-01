using System;
class Program
{
    public static void Main()
    {
        int np, nc, comb = 0, x, y;
        Console.WriteLine("Digite o número de pontos");
        np = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de casas");
        nc = int.Parse(Console.ReadLine());
        for (x = 1; x <= np; x++)
        {
            for (y = 1; y <= nc; y++)
            {
                Console.WriteLine("Variações possiveis " + x +"---"+ y);

            }
        }
    }
}