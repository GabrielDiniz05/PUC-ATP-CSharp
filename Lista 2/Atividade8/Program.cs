using System;

class Program{

    public static void Main(String[] args){

        /*
            Faça um programa que imprima todos os elementos da série de Fibonacci menores que L.
        */

        // Declaração de variáveis
        int num, a = 0, fib = 1;

        // Solicitando a entrada de dados
        Console.WriteLine("Insira um número: ");
        num = int.Parse(Console.ReadLine());

        // Laço de repetição para calcular a sequencia de fibonacci
        for(int i = 0; i < num; i++){

            // Estrutura condicional para verificar se os numeros chegaram no valor desejado
            if(fib > num || a > num){
                i = num;
            }

            // Verificação para ver se é possível continuar calculando e imprimindo os valores
            if(fib < num || a < num){
                Console.Write(a + " " + fib + " ");
            
                a+=fib;
                fib+=a;
               
            }else{
                i = num;
            }
        }
    }
}