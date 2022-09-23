using System;

class Program{

    public static void Main(String[] args){
        /*
            Fazer um programa para:
            1 - ler um símbolo do teclado;
            2 - identificar com a estrutura SWITCH e mostrar as seguintes mensagens, segundo o
            caso:
                o "SINAL DE MENOR"
                o "SINAL DE MAIOR"
                o "SINAL DE IGUAL"
                o "OUTRO SINAL"
        */

        // Declaração da variável resposta do tipo String
        string resposta;

        // Solicitando a resposta do usuário
        Console.WriteLine("Este é um programa para ler comandos do teclado.");
        Console.WriteLine("Insira um dos respectivos comandos para saber qual é o sinal: ( <, >, =, +)");
        
        // Armazenando a resposta na variável
        resposta = Console.ReadLine();

        // Utiliazndo o switch para verificar a resposta e responder de acordo
        switch(resposta){
            case "<":
                Console.WriteLine("SINAL DE MENOR");
                break;
            case ">":
                Console.WriteLine("SINAL DE MAIOR");
                break;
            case "=":
                Console.WriteLine("SINAL DE IGUAL");
                break;
            default:
                Console.WriteLine("OUTRO SINAL");
                break;
        }
    }
}