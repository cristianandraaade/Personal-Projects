using System;
public class Exercicio6
{
    public void Run()
    {
        int notaUm,notaDois,notaTres;
        Console.WriteLine("Digite as três notas");
        notaUm = int.Parse(Console.ReadLine());
        notaDois = int.Parse(Console.ReadLine());
        notaTres = int.Parse(Console.ReadLine());
        CalcularMedia(notaUm,notaDois,notaTres);
    }
    static float CalcularMedia(int notaUm, int notaDois, int notaTres){
        int maiorNota,mediaNota,menorNota;
        float mediaDasNotas;
        if((notaUm > notaDois)&&(notaUm > notaTres)){
            maiorNota=notaUm;
            if(notaDois > notaTres){
                mediaNota = notaDois;
                menorNota = notaTres;
            }
            else{
                mediaNota = notaTres;
                menorNota = notaDois;
            }
        }
        else if((notaDois > notaUm)&&(notaDois > notaTres)){
            maiorNota = notaDois;
                if(notaUm > notaTres){
                mediaNota = notaUm;
                menorNota = notaTres;
            }
            else{
                mediaNota = notaTres;
                menorNota = notaUm;
            }
        }
        else{
            maiorNota = notaTres;
            if(notaUm > notaDois){
                mediaNota = notaUm;
                menorNota = notaDois;
            }
            else{
                mediaNota = notaDois;
                menorNota = notaUm;
            }
        }
        mediaDasNotas = (float)(maiorNota+mediaNota)/2;
        Console.WriteLine("A media das maiores notas foi {0} e a menor nota foi {1}", mediaDasNotas, menorNota);
        return mediaDasNotas;
    }
}