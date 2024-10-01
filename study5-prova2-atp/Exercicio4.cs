using System;
public class Exercicio4
{
    public void Run()
    {
        int x = 0;
        x = int.Parse(Console.ReadLine());
        Fluxograma(x);
    }
    static void Fluxograma(int x)
    {
        int i = 1, cont = 0;
        while (x > i)
        {
            if (i % 2 == 0)
            {
                cont++;
            }
                i++;
        }
        Console.WriteLine(cont);
    }
}