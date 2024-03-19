/*problema 1 (achar o valor de x em uma equação de 2°grau)

//Declaração de variavel
double a, b, c, x1, x2;
//Entrada de Dados
Console.WriteLine("Escreva o valor de a,b,c");
a = double.Parse(Console.ReadLine());
b = double.Parse(Console.ReadLine());
c = double.Parse(Console.ReadLine());
//Processamento de dados
double delta = Math.Pow(b, 2) - 4 * a * c;
//Saida de dados
if (delta < 0) 
{
    Console.WriteLine("x não possui raízes reais");
}
else
{
    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("O valor de x1 é " + x1);
    Console.WriteLine("O valor de x2 é " + x2);
}

*/

/*problema 2 (calcular media de 3 numeros)

//Declaração de variaveis
double a,b,c, med;

//Entrada de dados

Console.WriteLine("Insira 3 números");
a=double.Parse(Console.ReadLine());
b=double.Parse(Console.ReadLine());
c=double.Parse(Console.ReadLine());

//Processamento de dados

med = (a+b+c)/3;

//saida de dados

Console.WriteLine("a media dos três números é "+ med);

*/

/*problema 3 (converter °C em °F)

//Declaração de variaveis

double c,f;

//Entrada de dados

Console.WriteLine("Insira um valor em °C");
c=double.Parse(Console.ReadLine());

//Processamento de dados

f=(c*9/5)+32;

//Saida de dados

Console.WriteLine("O valor em °F é " + f);

*/

/*problema 4 (verificação de numero par ou impar)

//declaração de variavel

int num;

//Emtrada de dados

Console.WriteLine("Insira um número");
num = int.Parse(Console.ReadLine());

//Processamento e saida de dados

if(num%2==0)
{
Console.WriteLine("o número é par");
}
    
else
{
    Console.WriteLine("o número é impar");
}
    
*/

//problema 5 (calculo de fatorial)

//Declaração de variavel

int num,fatorial;

//Entrada de dados

Console.WriteLine("Insira um número inteiro");
num=int.Parse(Console.ReadLine());

//Processamento de dados

fatorial=num*(num-1)*(num-2)*(num-3);

//Saida de dados

Console.WriteLine("a fatorial desse numero igual é " + fatorial);