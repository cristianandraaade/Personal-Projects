using System;
class Program
{
    public static void Main()
    {
        int num, termos = 1;
        Console.WriteLine("Escreva um número natural");
        num = int.Parse(Console.ReadLine());
        while(num !=1){
            if(num % 2 ==0){
                num/=2;
                termos++;
            }
            else{
                num=num*3+1;
                termos++;
            }
            Console.WriteLine("valor de num " + num + "valor de termos " + termos);
        }
    }
}
