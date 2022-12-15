using System;

class Program{

    public static void Main(string[] args){
        string caminho = @".\ler.txt";
        int num = 0, divisor = 0;

        StreamWriter sw = new StreamWriter(caminho);

        Console.WriteLine("Insira um número para saber os divisores: ");
        num = int.Parse(Console.ReadLine());
        
        
        for(int i  = 1; i <= num; i++){
            if(num%i == 0){
                Console.WriteLine("Divisor:" + i);
                divisor+=i;
                Console.WriteLine("Soma do divisor: " + divisor);
            }
        }

        sw.WriteLine("Soma dos divisores de "  + num  + " é: " + divisor);
        sw.Close();

    }
}