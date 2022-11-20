using System;

class Program
{
    public static void Main(string[] args)
    {
        int num = 20;
        int[] vetor = new int[num];
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine("Insira o número: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        int menor = vetor[0], pos = 0;
        for (int i = 0; i < num; i++)
        {
            if (vetor[i] < menor)
            {
                menor = vetor[i];
                pos = i;
            }
        }
        Console.WriteLine("O meno número é: {0} e sua posição é: {1}", menor, pos);
    }
}