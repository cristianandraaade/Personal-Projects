int n, sinal=1; 
double pi=0;
Console.WriteLine("Digite o número de termos");
n=int.Parse(Console.ReadLine());
    for(int x =1; x<=n*2; x+=2){
        pi+=4/(double)x*sinal;  
        sinal*=-1;
    }
    Console.WriteLine("Resultado"+ pi);