namespace exercicio1;

class Program
{
    static void Main(string[] args)
    {
        int primNumero, segNumero;
        primNumero = int.Parse(Console.ReadLine());
        segNumero = int.Parse(Console.ReadLine());
        isFriend(primNumero, segNumero);
    }
    static void isFriend(int primNumero, int segNumero){
        int soma1 = 0, soma2=0;
        for(int i = 1; i < primNumero; i++){
            if(primNumero % i == 0){
                soma1 += i;
            }
        }
        for(int i = 1 ; i < segNumero; i++){
            if(segNumero % i == 0){
                soma2 += i;
            }
        }
        if((soma1 == segNumero)&&(soma2 == primNumero)){
            Console.WriteLine("É amigo");
        }
        else{
            Console.WriteLine("Não é amigo");
        }
    }
}
