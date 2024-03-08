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

//problema 2 (calcular media de 3 numeros)

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