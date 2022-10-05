using System;

class Program{

    public static void Main(String[] args){

        /*
            Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
            S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
            O algoritmo deve escrever cada termo gerado e o valor final de S.
        */

        int numero;

        double s = 0;

        Console.WriteLine("Insira um número: ");
        numero = int.Parse(Console.ReadLine());

        for(int i = 1; i <= numero; i++){
            s+=(1.0/i);
            Console.WriteLine("(S) dentro do FOR: " + s);
        }
        Console.WriteLine("RESULTADO FINAL: " + s);
    }
}