using System;

class  Program{

    public static void Main(String[] args){

        /*
            Em uma eleição presidencial existem quatro candidatos. Os votos são informados através
            de códigos. Os dados utilizados para a contagem dos votos obedecem à seguinte
            codificação:
            1,2,3,4 = voto para os respectivos candidatos;
            5 = voto nulo;
            6 = voto em branco;
            Elabore um algoritmo que leia o código do candidado em um voto. Calcule e escreva:
            - total de votos para cada candidato;
            - total de votos nulos;
            - total de votos em branco.

            Como finalizador do conjunto de votos, tem-se o valor 0
        */

        // Declaração de variáveis
        int numero_candidato = 1, cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, nulo = 0, branco = 0;

        string resposta;
        
        // Laço de repetição para o programa rodar enquanto o numero do canditado for maior que 0
        while(numero_candidato > 0){
            // Solicitando a entrada de dados
            Console.WriteLine("Insira o número do canditato em que deseja votar: (1 / 2 / 3 / 4 / 5 / 6");
            numero_candidato = int.Parse(Console.ReadLine());

            // Estrutura para verificar qual candidato recebeu voto 
            switch(numero_candidato){
                case 1:
                    cand1++;

                    break;
                case 2:
                    cand2++;
                    break;
                case 3:
                    cand3++;
                    break;
                case 4:
                    cand4++;
                    break;
                case 5:
                    nulo++;
                    break;
                case 6:
                    branco++;
                    break;
                default:
                    nulo++;
                    break;
            }

            // Verificando se o usuário deseja continuar a inserir votos
            Console.WriteLine("Deseja inserir mais um voto? (s/n)");

            resposta = Console.ReadLine();

            if(resposta.ToUpper() == "S"){
                continue;
            }else if(resposta.ToUpper() == "N"){
                numero_candidato = 0;
            }else{
                Console.WriteLine("Entrada de dados inválida! Finalizando programa...");
                numero_candidato = 0;
            }
        }
        // Imprimindo o resultado final
        Console.WriteLine("Total de votos: \nCandidato 1: {0} \nCandidato 2: {1} \nCandidato 3: {2} \nCandidato 4: {3} \nNulo: {4} \nBranco: {5}", cand1, cand2, cand3, cand4, nulo, branco);
    }
}