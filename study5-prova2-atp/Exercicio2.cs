using System;
public class Exercicio2
{
    public void Run()
    {
        double capitalInicial, taxaJuros;
        int anos, trimestres;
        Console.WriteLine("Insira o capital inicial a taxa e os anos");
        capitalInicial = double.Parse(Console.ReadLine());
        taxaJuros = double.Parse(Console.ReadLine());
        anos = int.Parse(Console.ReadLine());
        trimestres = anos * 4;
        double montanteFinal = CalcularMontante(capitalInicial,taxaJuros,trimestres);
        Console.WriteLine("O montante no final de {0} trimestres foi: {1:c2}", trimestres, montanteFinal);
    }
    static double CalcularMontante(double capitalInicial, double taxaJuros, int trimestres)
    {
        double montanteTrimestral = 0;
        for (int i = 1; i <= trimestres; i++)
        {
            montanteTrimestral = capitalInicial * Math.Pow(1 + taxaJuros, trimestres);
            capitalInicial = montanteTrimestral;
            Console.WriteLine("{0:c}",capitalInicial);
        }
        return montanteTrimestral;
    }
}