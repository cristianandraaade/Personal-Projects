using System;
public class Exercicio1
{
    public void Run()
    {
        int numeroBase, expoente;
        double potencia;

        Console.WriteLine("Escreva o número a e ser elevado e seu expoente");
        numeroBase = int.Parse(Console.ReadLine());
        expoente = int.Parse(Console.ReadLine());
        potencia = CalcularPotencia(numeroBase, expoente);
        Console.WriteLine("A potencia é: " + potencia);

        static double CalcularPotencia(int numeroBase, int expoente){
            double potencia;
            potencia = Math.Pow(numeroBase, expoente);

            return potencia;
            
        }
    }
}