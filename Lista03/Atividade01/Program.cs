using System;

class Program
{
    static void calcNota(int n1, int n2, int n3, string l)
    {
        if (l.ToUpper() == "A")
        {
            int media;
            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("A média aritmética das notas é: " + media);
        }
        else if (l.ToUpper() == "P")
        {
            double media;
            media = (((double)n1 * 5) + ((double)n2 * 3) + ((double)n3 * 2)) / 10;
            Console.WriteLine("A média ponderada das notas é: " + media);
        }
        else
        {
            Console.WriteLine("Comando Inválido!");
        }
    }

    public static void Main(string[] args)
    {
        int n1 = 0, n2 = 0, n3 = 0, n = 0;
        string l;

        Console.WriteLine("Insira a quantidade de alunos que vão inserir a nota: ");

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Insira suas notas: (N1, N2, N3)");
            Console.WriteLine("Digite a primeira nota: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceiro nota: ");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite informe uma letra para escolher qual média calcular: (a) Aritmética, (p) Ponderada");
            l = Console.ReadLine();
            calcNota(n1, n2, n3, l);
            Console.WriteLine("\n... Indo para o próximo aluno ...\n\n\n");
        }
    }
}