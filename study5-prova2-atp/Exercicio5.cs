using System;
public class Exercicio5
{
    public void Run()
    {
        double salarioAtual;
        Console.WriteLine("Digite o salario");
        salarioAtual = double.Parse(Console.ReadLine());
        CalcularNovoSalario(ref salarioAtual);
        Console.WriteLine("Seu novo salario é " + salarioAtual);
    }
    public static void CalcularNovoSalario(ref double salarioAtual){
        if(salarioAtual < 1420.00){
            salarioAtual+= salarioAtual*0.15;
        }
        else{
            salarioAtual+= salarioAtual*0.10;
        }
    }
}