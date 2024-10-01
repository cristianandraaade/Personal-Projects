using System;
public class Exercicio3
{
    public void Run()
    {
        int[] teste = {12, 43, 25, 36, 244, 34, 235, 1000, 543, 7680, 2, 54, 6343};
        int maior = MaiorValor(teste);
        Console.WriteLine("maior valor do vetor é: " + maior);
    }
     static int MaiorValor(int[] teste){
        int maior = teste[0];
        for(int i=0; i <teste.Length;i++){
            if(teste[i] > maior){
                maior = teste[i];
            }
        }
        return maior;
     }
}
