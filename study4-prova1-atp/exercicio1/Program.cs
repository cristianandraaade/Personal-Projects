using System;
    class Program{
        public static void Main(){
            double  farenheit, c;
            for (c =1;c<=100;c++){
                farenheit =(1.8* c) + 32;
                Console.WriteLine("Celsius " + c +" °" + "||" + "Farenheit " + farenheit + "°");
                }
        }
    }