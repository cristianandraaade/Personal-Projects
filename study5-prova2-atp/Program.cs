using System;
class Program
{
    public static void Main()
    {

        int opcao;
        opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                Exercicio1 exercicio1 = new Exercicio1();
                exercicio1.Run();
                break;
            case 2:
                Exercicio2 exercicio2 = new Exercicio2();
                exercicio2.Run();
                break;
            case 3:
                Exercicio3 exercicio3 = new Exercicio3();
                exercicio3.Run();
                break;
            case 4:
                Exercicio4 exercicio4 = new Exercicio4();
                exercicio4.Run();
                break;
            case 5:
                Exercicio5 exercicio5 = new Exercicio5();
                exercicio5.Run();
                break;
            case 6:
                Exercicio6 exercicio6 = new Exercicio6();
                exercicio6.Run();
                break;
            case 7:
                Exercicio7 exercicio7 = new Exercicio7();
                exercicio7.Run();
                break;
            case 8:
                Exercicio8 exercicio8 = new Exercicio8();
                exercicio8.Run();
                break;
            case 9:
                Exercicio9 exercicio9 = new Exercicio9();
                exercicio9.Run();
                break;
            case 10:
                Exercicio10 exercicio10 = new Exercicio10();
                exercicio10.Run();
                break;
        }
    }
}