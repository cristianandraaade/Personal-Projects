using System;
class Program
{
    public static void Main()
    {

        int nivel1;
        Console.WriteLine("Selecione um número de 1 a 10");
        nivel1=int.Parse(Console.ReadLine());
        switch (nivel1)
        {
            case 1:
            //declaração de variaveis
                int estoqueMedio, quantidadeMinima, quantidadeMaxima;
            //emtrada de dados
                Console.WriteLine("Digite a quantidade minima do produto");
                quantidadeMinima=int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a quantidade maxima do produto");
                quantidadeMaxima=int.Parse(Console.ReadLine());
            //processamento de dados
                estoqueMedio=(quantidadeMinima + quantidadeMaxima)/2;
            //saida de dados
                Console.WriteLine("O estoque médio desse produto é " + estoqueMedio);
            break;
            case 2:
            //declaração de variaveis
                double cotaçãoDolar,valorDolar,valorReais;
            //entrada de dados
                Console.WriteLine("Informe a cotação do dólar");
                cotaçãoDolar=double.Parse(Console.ReadLine());
                Console.WriteLine("Digite um valor em dolares");
                valorDolar=double.Parse(Console.ReadLine());
            //processamento de dados
                valorReais=cotaçãoDolar*valorDolar;
            //saida de dados
                Console.WriteLine("O valor convertido é {0:f2} " ,valorReais);
            break;
            case 3:
            //declaração de variaveis
                i


                
            default:
                Console.WriteLine("Digite um valor valido");
            break;
                
        }

    }
}
