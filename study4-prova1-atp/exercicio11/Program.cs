using System;
class Program
{
    public static void Main()
    {
        float valor=0, valorTotal=0, maiorDireto=0, mediaIndireta=0, totalIndireto=0;
        int qtdAcima = 0, qtdIndireto = 0;
        string tipo;
        Console.WriteLine("Digite o tipo de gasto e o valor");
        do
        {
            tipo = Console.ReadLine();
            if (tipo != "nenhum")
            {
                if (tipo == "obra")
                {
                    valor = float.Parse(Console.ReadLine());
                    if (valor > 150.000)
                    {
                        qtdAcima++;
                    }
                }
                else if (tipo == "direto")
                {
                    valor = float.Parse(Console.ReadLine());
                    if (valor > 300.000)
                    {
                        qtdAcima++;
                    }
                    if (maiorDireto < valor)
                    {
                        maiorDireto = valor;
                    }
                }
                else if (tipo == "indireto")
                {
                    valor = float.Parse(Console.ReadLine());
                    totalIndireto += valor;
                    qtdIndireto++;
                    if (valor > 50.000)
                    {
                        qtdAcima++;
                    }
                }
            }
            valorTotal+=valor;
        } while (tipo != "nenhum");
        mediaIndireta= totalIndireto/(float)qtdIndireto;
        Console.WriteLine(valorTotal);
        Console.WriteLine(maiorDireto);
        Console.WriteLine(mediaIndireta);
        Console.WriteLine(qtdAcima);
    }
}