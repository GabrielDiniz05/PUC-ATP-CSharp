using System;

class Program{
    public static void Main(String[] args){
        /*
            Fazer um programa leia uma sequência de valores inteiros fornecida pelo usuário em uma
            linha de entrada e conte o número de valores positivos, negativos e zeros.
        */

        // Declarando as variáveis do tipo int, string e booleana
        int num_usuario, positivos = 0, negativos = 0, zeros = 0, contador = 0;
        string resposta_usuario, resp_contador;
        bool start;

        // Solicitando a entrada de dados
        Console.WriteLine("Este é um programa que recebe números e devolve informações sobre eles.");
        Console.WriteLine("Deseja iniciar o programa? (s/n)");

        resposta_usuario = Console.ReadLine();

        // Verificando a resposta do usuário, caso sim entrar na condição
        if(resposta_usuario.ToUpper() == "S"){
            // Atribuindo o valor TRUE a variável -start-
            start = true;
            // Enquanto a variável -start- for igual a TRUE o programa continuara rodando
            while(true){
                // Adicionando 1 a variável -contador-
                contador++;
                
                // Solicitando a entrada dos números
                Console.WriteLine("Insira um número: ");
                
                num_usuario = int.Parse(Console.ReadLine());
                
                // Verificando se os números serão positivos, negativos ou zeros e somando 1 a suas respectivas variáveis
                if(num_usuario > 0)
                    positivos++;
                else if(num_usuario == 0)
                    zeros++;
                else
                    negativos++;
                
                // Verificando se o valor da variável -contador- é 5, caso sim, entrar na condição
                if(contador == 5){
                    // Solicitando resposta do usuário
                    Console.WriteLine("Deseja continuar a inserir mais 5 números? (s/n)");
                    
                    resp_contador = Console.ReadLine();

                    // Verificando resposta do usupario. Caso sim, valor da variável -contador- vira 0 e o while "reinicia" para que mais números possam ser inseridos
                    if(resp_contador.ToUpper() == "S")
                        contador = 0;
                    // Caso não, valor FALSE atribuído a variável start, para que o loop possa ser interrompido
                    else if(resp_contador.ToUpper() == "N")
                        break;// start = false;
                    // Caso nenhuma das condições anteriores seja atingida, significa que há uma entrada inválida, sendo assim, mandar mensagem para o usuário e finalizar o loop
                    else
                        Console.WriteLine("Entrada Inválida, suspendendo programa. Favor reiniciar!");
                        start = false;
                }
            }
            // Imprimindo as informações sobre os números digitados
            Console.WriteLine("O resultado dos números registrados é: \nPositivos: {0} \nNegativos: {1} \nZeros: {2}", positivos, negativos, zeros);
        }
        // Caso o usuário escolha não iniciar o programa, mandar mensagem e finalizar
        else if(resposta_usuario.ToUpper() == "N"){
            Console.WriteLine("Volte sempre!");
        }
        // Caso nenhuma das condições anteriores seja atiginda, significa uma entra inválida, mandar mensagem ao usuário e finalizar programa
        else{
            Console.WriteLine("Entrada inválida! Reinicie o programa");
        }
    }
}