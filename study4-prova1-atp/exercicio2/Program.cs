using System;
    class Program{
        public static void Main(){
            int num=0, x=0,fatorial=1;
            Console.WriteLine("Insira um número");
            num=int.Parse(Console.ReadLine());
            for(x=1;x<=num;x++){
                fatorial*=x;
            }
                Console.WriteLine("O fatorial do número " + num + " é " + fatorial);
            
        }
    }