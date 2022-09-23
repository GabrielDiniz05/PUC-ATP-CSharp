using System;

public class Program{

    public static void Main(String[] args){
        /*
            Faça um algoritmo que leia 2 números inteiros e faça sua adição. Se o resultado for maior 
            ou  igual  a  10,  some  5  a  este  número.  Caso  contrário  some  7  a  ele.  Imprima  o  resultado 
            final.
        */

        // Declarando as variáveis num1, num2 e resultado do tipo inteiro
        int num1, num2, resultado;

        // Solicitando a entrada de dados do usuário
        Console.WriteLine("Insira o primeiro número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        num2 = int.Parse(Console.ReadLine());

        // Adição do número1 com o número2, posteriormente armazenando na variável resultado
        resultado = num1 + num2;

        // Imprimindo o resultado da adição
        Console.WriteLine("Número1: {0} + Número2: {1} = {2}", num1, num2, resultado);

        // Estrutura condicional para verificar se o resultado é maior ou igual a 10, caso SIM adicionar mais 5 ao resultado
        if(resultado >= 10){
            resultado+=5;
        }
        // Caso o valor seja menor que 10, adicionar mais 7 ao resultado
        else{
            resultado+=7;
        }

        // Imprimindo o resultado após a estrutura condicional
        Console.WriteLine("Resultado após a estrutura condicional: " + resultado);
    }
}