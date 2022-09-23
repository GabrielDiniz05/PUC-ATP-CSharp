using System;

public class Program{

    public static void Main(String[] args){
        /*
            Faça um algoritmo que segundo uma nota informada pelo usuário, verifique em qual faixa 
            a  mesma  se  encaixa  e  imprima  para  o  usuário  a  mensagem  correspondente  conforme  a 
            tabela abaixo:

            |_______________________________________|
            |Faixa das notas        |   Mensagem    |
            |-----------------------|---------------|
            |Nota >= 8 e Nota <= 10 |     Ótimo     |
            |Nota >= 7 e Nota < 8   |      Bom      |
            |Nota >= 5 e Nota < 7   |     Regular   |
            |Nota < 5               | Insatisfatório|
            |---------------------------------------|
        */

        // Declarando a variável nota do tipo inteiro
        int nota;

        // Solicitando a entrada de dados
        Console.WriteLine("Insira a nota da sua prova: ");
        nota = int.Parse(Console.ReadLine());

        // Verificando se a nota é menor ou igual a 10 e maior ou igual a 8
        if((nota <= 10) && (nota >= 8)){
            Console.WriteLine("Ótimo!");
        }
        // Verificando se a nota é menor que 8 e maior ou igual a 7
        else if((nota < 8) && (nota >= 7)){
            Console.WriteLine("Bom.");
        }
        // Verificando se a nota é menor que 7 e maior ou igual a 5
        else if((nota < 7) && (nota >= 5)){
            Console.WriteLine("Regular.");
        }
        // Verificando se a nota não corresponde a nenhuma das verificações anteriores
        else{
            Console.WriteLine("Insatisfatório!");
        }
    }
}