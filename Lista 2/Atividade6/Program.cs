using System;

class Program{

    public static void Main(String[] args){

        /*
            Escreva um algoritmo que lê um valor n inteiro e positivo e que calcula a seguinte soma:
            S = 1 + 1/2 + 1/3 + 1/4 + ... + 1/n
            O algoritmo deve escrever cada termo gerado e o valor final de S.
        */

        // Declarando variáveis
        int numero;

        double s = 0;

        // Solicitando a entrada de dados
        Console.WriteLine("Insira um número: ");
        numero = int.Parse(Console.ReadLine());

        // Laço de repetição para efetuar a operação enquanto for necessário
        for(int i = 1; i <= numero; i++){
            // Operação e impreção dos dados desejados
            s+=(1.0/i);
            Console.WriteLine("(S) dentro do FOR: " + s);
        }

        // Imprimindo resultado final
        Console.WriteLine("RESULTADO FINAL: " + s);
    }
}