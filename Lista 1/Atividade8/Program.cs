using System;

class Program{

    public static void Main(String[] args){
        /*
            Construa um programa que lê uma opção conforme abaixo (usar estrutura SWITCH) e o
            salário atual do funcionário, calcula e exibe o novo salário:

                A = aumento de 8% no salário;
                B = aumento de 11% no salário;
                C = aumento fixo no salário
                (de R$ 350,00 se o salário atual for até R$ 1000 e de R$ 200,00 se o salário atual for
                maior que R$ 1000).
        */

        // Declarando as variáveis salario e resposta respectivamente do tipo double e string
        double salario;
        string resposta;

        // Solicitando os dados do usuário
        Console.WriteLine("Insira o valor do seu salário: ");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira (A) para incrementar em 8% seu salario, (B) para um aumento de 11% e (C) para um aumento fixo: ");
        resposta = Console.ReadLine();

        // Transformando a resposta do usuário em maiusculo, posteriormente verificando a resposta e de acordo com a resposta realizando calculo e imprimindo o resultado 
        switch(resposta.ToUpper()){
            case "A":
                // Caso a escolha seja A o salario vai ganhar um aumento de 8% (0.08)
                salario = (salario * 0.08) + salario;
                Console.WriteLine("Seu novo salário é: " + salario);
                break;
            case "B":
                // Caso a escolha seja A o salario vai ganhar um aumento de 11% (0.11)
                salario = (salario * 0.11) + salario;
                Console.WriteLine("Seu novo salário é: " + salario);
                break;
            case "C":
                // Realizando uma verificação para saber se o salario é menor ou igual a 1000 ou maior, e respectivamente realizando as operações
                if(salario <= 1000){
                    salario+=350;
                }else{
                    salario+=200;
                }
                Console.WriteLine("Seu novo salário é: " + salario);
                break;
            default:
                // Caso a resposta não caia no switch, ela é considerada inválida
                Console.WriteLine("Comando Inválido.");
                break;
        }
    }
}