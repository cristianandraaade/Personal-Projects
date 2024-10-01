namespace study1_prova_aed;

class Program
{
    static void Main(string[] args)
    {
        int[] v = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Ordena(v);
        foreach (var item in v)
        {
            Console.Write(item + " ");
        }
    }

    static void Ordena(int[] v)
    {
        int maior = maiorValor(v);
        int[] pares = new int[maior + 1];
        int[] impares = new int[maior + 1];
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] % 2 == 0) 
            {
                pares[v[i]]++;
            }
            else
            {
                impares[v[i]]++;
            }
        }
        int index = 0;
        for (int i = 0; i <= maior; i++)
        {
            while (pares[i] > 0)
            {
                v[index] = i;
                pares[i]--;
                index++;
            }
        }
        for (int i = maior; i >= 0; i--)
        {
            while (impares[i] > 0)
            {
                v[index] = i;
                impares[i]--;
                index++;
            }
        }
    }
    static int maiorValor(int[] v)
    {
        int maior = v[0];
        for (int i = 1; i < v.Length; i++)
        {
            if (v[i] > maior)
            {
                maior = v[i];
            }
        }
        return maior;
    }
}
