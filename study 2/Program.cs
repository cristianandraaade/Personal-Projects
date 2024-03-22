int select;
Console.WriteLine("Selecione um número de 1 a 8");
select = int.Parse(Console.ReadLine());
switch (select)
{
    case 1:
        double peso, alt, imc;
        Console.WriteLine("Digite seu peso e altura");
        peso = double.Parse(Console.ReadLine());
        alt = double.Parse(Console.ReadLine());
        imc = peso / Math.Pow(alt, 2);
        Console.Write("Seu IMC é {0:f2}", imc);
        if (imc < 18)
        {
            Console.WriteLine(" Desnutrido ");
        }
        else if (imc <= 20)
        {
            Console.WriteLine(" Baixo Peso ");
        }
        else if (imc <= 24)
        {
            Console.WriteLine(" Normal ");
        }
        else if (imc <= 27)
        {
            Console.WriteLine(" Sobrepeso ");
        }
        else
        {
            Console.WriteLine(" Obeso ");
        }
        break;
    
    case 2:
        double rendaAnual, rendaLiquida, imposto;
        int numeroDependentes;
        Console.WriteLine("Escreva sua renda anual");
        rendaAnual = double.Parse(Console.ReadLine());
        Console.WriteLine("Escreva o número de dependentes");
        numeroDependentes = int.Parse(Console.ReadLine());
        rendaLiquida = rendaAnual - (rendaAnual * numeroDependentes * 0.02);
        if (rendaLiquida <= 20000)
        {
            imposto = 0;
        }
        else if (rendaLiquida <= 50000)
        {
            imposto = rendaLiquida * 0.05;
        }
        else if (rendaLiquida <= 100000)
        {
            imposto = rendaLiquida * 0.1;
        }
        else
        {
        imposto= rendaLiquida * 0.15;
        }
        Console.WriteLine("Imposto Calculado {0:c2}", imposto);
        break;
}


