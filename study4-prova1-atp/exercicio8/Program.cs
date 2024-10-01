using System;
    class Program{
        public static void Main(){
            int num, primeiraParte,segundaParte,somaPartes;
            for(num=1000;num<9999;num++){
                primeiraParte=num/100;
                segundaParte=num%100;
                somaPartes=primeiraParte+segundaParte;
                if (Math.Pow(somaPartes, 2)== num){
                    Console.WriteLine(num);
                }
            }
        }
    }