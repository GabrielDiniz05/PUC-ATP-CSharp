using System;

class Program{

    public static void Main(String[] args){

        /*
            Escrever um algoritmo que lê um valor N inteiro e positivo e que calcula e escreve o valor
            de E:
            E = 1 + 1 / 1! + 1 / 2! + 1 / 3! + .... + 1 / N!
        */

        // Declaração de variáveis
        int n, aux;
        double fat = 1.0, e = 1.0;

        // Solicitando a entrada de dados
        Console.WriteLine("Insira o número: ");
        n = int.Parse(Console.ReadLine());

        // Atribuindo o valor de N na variável AUX
        aux = n;

        // Laço de repetição 
        for(int i = 0; i < n; i++){
            e += (1.0/fat);
            Console.WriteLine(e);
            for(fat = 1; aux >= 1; aux--){
                fat*=aux;
            }
            aux = n;
            aux-=i;     
        }
        Console.WriteLine("Resultado: " + e);
    }
}