using System;

class  Program{

    public static void Main(String[] args){

        int numero_candidato = 1, cand1 = 0, cand2 = 0, cand3 = 0, cand4 = 0, nulo = 0, branco = 0;

        string resposta;
        
        while(numero_candidato > 0){
            Console.WriteLine("Insira o número do canditato em que deseja votar: (1 / 2 / 3 / 4 / 5 / 6");
            numero_candidato = int.Parse(Console.ReadLine());

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
        Console.WriteLine("Total de votos: \nCandidato 1: {0} \nCandidato 2: {1} \nCandidato 3: {2} \nCandidato 4: {3} \nNulo: {4} \nBranco: {5}", cand1, cand2, cand3, cand4, nulo, branco);
    }
}