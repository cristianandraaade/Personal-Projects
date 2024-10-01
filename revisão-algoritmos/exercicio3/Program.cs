namespace exercicio3;

class Program
{
    //static void Main(string[] args)
    // {
    //     int n = int.Parse(Console.ReadLine());
    //     for(int i = 1; i <= n; i++){
    //         for(int j = 1; j <= i; j++){
    //             if((i == n)||(j == i)||(j == 1)){
    //                 Console.Write("*");
    //             }
    //             else{
    //                 Console.Write(" ");
    //             }
    //         }
    //         Console.WriteLine();
    //     }
    // }
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        recurssao(1, 1, n);
    }
    static void recurssao(int i, int j, int n)
    {
        if (i <= n)
        {
            if (j <= i)
            {
                if ((i == n) || (j == i) || (j == 1))
                {
                    Console.Write("*");
                    recurssao(i, j + 1, n);
                }
                else
                {
                    Console.Write(" ");
                    recurssao(i, j + 1, n);
                }
            }
            else
            {
                Console.WriteLine();
                recurssao(i + 1, 1, n);
            }
        }
    }
}
