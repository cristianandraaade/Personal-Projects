using System;
class Program
{
    public static void Main()
    {
        int qntTotal = 0, qntAcimaPeso = 0, mediaPesoCaminhoes = 0, maiorPesoCarreta = 0, qntCaminhoes = 0, media;
        char codigo; int peso = 0; string tipo;
        do
        {
            codigo = char.Parse(Console.ReadLine());
            peso = int.Parse(Console.ReadLine());
            {
                if (codigo == 'A')
                {
                    if (peso > 15)
                    {
                        Console.WriteLine("Acima do peso");
                        qntAcimaPeso++;
                    }
                }
                else if (codigo == 'B')
                {
                    qntCaminhoes++;
                    mediaPesoCaminhoes += peso;
                    if (peso > 30)
                    {
                        Console.WriteLine("Acima do peso");
                        qntAcimaPeso++;
                    }
                }
                else if (codigo == 'C')
                {
                    if (peso > maiorPesoCarreta)
                    {
                        maiorPesoCarreta = peso;
                    }
                    if (peso > 50)
                    {
                        Console.WriteLine("Acima do peos");
                        qntAcimaPeso++;
                    }
                }
                qntTotal++;

            } while (codigo != 'z') ;
            media = mediaPesoCaminhoes / qntCaminhoes;
            Console.WriteLine("Quantidade total de veiculos " + qntTotal);
            Console.WriteLine("Quantidade acima do peso " + qntAcimaPeso);
            Console.WriteLine("Peso da carreta mais pesada" + maiorPesoCarreta);
            Console.WriteLine("A media do peso dos caminhões é " + media);
        }
    }
}