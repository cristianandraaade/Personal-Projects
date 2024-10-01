using System;
    class Program{
        public static void Main(){
            double a=160, b=120;
            int anos=0;
            while(a>b){
                a=a*0.015+a;
                b=b*0.024+b;
                anos++;
            }
            Console.WriteLine("O país B ultrapassou o A em " + anos + " anos ");

        }
    }