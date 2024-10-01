using System;
public class Exercicio7
{
    public void Run()
    {
        float a,r;
        int n;
    
        Console.WriteLine("Digite o primeiro termo");
        a = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite a razão");
        r = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de termos");
        n = int.Parse(Console.ReadLine());
        CalculaTermos(a,r,n);
    }
    static float CalculaTermos(float a, float r, float n){
        for(int i=1; i<=n; i++){
            float termo = a+(i-1)*r;
            Console.WriteLine("Termo {0} é {1}",i,termo);
        }
        return a;

    }
}