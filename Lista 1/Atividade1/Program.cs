using System;

public class Program{

    public static void Main(String[] args){
        // Dado dois números, imprimir somente o maior deles.

        // Declaração das variáveis do tipo double.
        double num1, num2;

        // Solicitando a entrada de dados
        Console.WriteLine("Insira um número: ");
        num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira um segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        // Verificando se o número 1 é maior que o número 2
        if(num1 > num2){
            Console.WriteLine("O maior número é: " + num1);
        }
        // Verificando se o número 2 é maior que o número 1
        else if(num2 > num1){
            Console.WriteLine("O maior número é: " + num2);
        }
        // E finalmente se não cair nas condições anteriores, significa que os números são iguais
        else{
            Console.WriteLine("Os números são iguais: {0}, {1}", num1, num2);
        }

    }
}