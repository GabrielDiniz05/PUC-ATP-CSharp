using System;

class Program{

    static int[] Sorteio(){
        int[] vetor = new int[3];
        Random rdm = new Random();
        for(int i =0; i < 3; i++){
            vetor[i] = rdm.Next(10, 50);
        }
        return vetor;
    }

    static void Tentativa(int[] vetor, ref bool start){
        int n1, n2, n3;
        Console.WriteLine("Insira o primeiro número: ");
        n1 = int.Parse(Console.ReadLine());
        if(n1 == vetor[0]){
            Console.WriteLine("Parabens você acertou!");
            start = false;
        }
        Console.WriteLine("Insira o segundo número: ");
        n2 = int.Parse(Console.ReadLine());
        if(n2 == vetor[1]){
            Console.WriteLine("Parabens você acertou!");
            start = false;
        }
        Console.WriteLine("Insira o terceiro número: ");
        n3 = int.Parse(Console.ReadLine());
        if(n3 == vetor[2]){
            Console.WriteLine("Parabens você acertou!");
            start = false;
        }
    }

    public static void Main(string[] args){
        bool start = true;

        while(start){
            Tentativa(Sorteio(), ref start);
        }     
    }
}