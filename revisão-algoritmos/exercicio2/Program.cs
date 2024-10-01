namespace exercicio2;

class Program
{
    static void Main(string[] args)
    {
        int num1;
        num1 = int.Parse(Console.ReadLine());
        if(itsPerfect(num1)){
            Console.WriteLine("é perfeito");
        }
        else{
            Console.WriteLine("Não é perfeito");
        }
    }
    static bool itsPerfect(int num1){
        int soma = 0;
        for(int i=1; i < num1; i++){
            if(num1 % i == 0){
                soma+=i;
            }
        }
        if(soma == num1){
            return true;
        }
        else{
            return false;
        }
    }
}
