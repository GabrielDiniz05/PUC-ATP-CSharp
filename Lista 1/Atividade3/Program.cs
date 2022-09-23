using System;

public class Program{

    public static void Main(String[] args){
        /*
            Faça um programa para ler os coeficientes de uma equação do primeiro grau (ax + b = 0), 
            calcular e escrever a raiz da equação.
        */  
    
        // Declarando as variáveis A, B e resultado do tipo inteiro
        int a, b, resultado;

        // Explicando a equação, a fórmula de resolução e posteriormente solicitando a entrada de dados
        Console.WriteLine("Uma equação do 1ºgrau é dada pela seguinte fórmula (AX + B = 0)");
        Console.WriteLine("Com a resolução sendo: X = -B/A");
        Console.WriteLine("Sendo assim, insira o valor de A: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o valor de B: ");
        b = int.Parse(Console.ReadLine());

        // Aplicando a fórmula para descobrir a raiz da equação e posteriormente armazenando o valor na variável resultado
        resultado = (-b / a);

        // Imprimindo o resultado
        Console.WriteLine("A raíz da equação ({0}X + {1} = 0) é: {2}", a, b, resultado);
    }
}