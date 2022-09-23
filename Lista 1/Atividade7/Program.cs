using System;

public class Program{

    public static void Main(String[] args){
        /*
            Faça um programa para calcular e imprimir o valor de Y, dado um valor de X:
        */
    
        // Declarando as variáveis x e y do tipo double
        double x, y = 0;

        // Solicitando os dados do usuário
        Console.WriteLine("Dado um valor de X, será impresso o valor de Y.");
        Console.WriteLine("Insira o valor de X: ");

        x = double.Parse(Console.ReadLine());

        // Verificando o valor de X para imprimir o valor de Y
        if(x <= 1){
            y = 1;
        }else if(x <= 2){
            y = 2;
        }else if(x <= 3){
            y = Math.Pow(x, 2);
        }else{
            y = Math.Pow(x, 3);
        }

        // Imprimindo o resultado
        Console.WriteLine("O valor de Y é: " + y);
    }
}