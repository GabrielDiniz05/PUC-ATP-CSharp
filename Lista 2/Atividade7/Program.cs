using System;

class Program{

    public static void Main(String[] args){

        /*
            Faça um programa que imprima os L primeiros elementos da série de Fibonacci. Por
            exemplo, se o usuário digitou o número 40, deverão ser apresentados os 40 números da
            sequência na tela.
        */

        // Declaraçãpo de variáveis
        int quant, a = 0, fib = 1;

        // Solicitando a entrada de dados
        Console.WriteLine("Insira a quantidade de casas que deseja ver da sequência de fibonacci: ");
        quant = int.Parse(Console.ReadLine());

        // Laço de repetição para calcular a sequencia de fibonacci e imprimi-la
        for(int i = 0; i < quant; i++){
            Console.Write(a + " " + fib + " ");
            a+=fib;
            fib+=a;
        }
    }
}