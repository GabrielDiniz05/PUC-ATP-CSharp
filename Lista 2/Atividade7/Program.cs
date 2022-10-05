using System;

class Program{

    public static void Main(String[] args){
        int quant, a = 0, fib = 1;

        Console.WriteLine("Insira a quantidade de casas que deseja ver da sequência de fibonacci: ");
        quant = int.Parse(Console.ReadLine());

        for(int i = 0; i < quant; i++){
            Console.Write(a + " " + fib + " ");
            a+=fib;
            fib+=a;
        }
    }
}