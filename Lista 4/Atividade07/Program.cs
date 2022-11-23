using System;

class Program{
    static void Preencher(ref int[,] vetor){
        Random rdm = new Random();

        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                vetor[x,y] = rdm.Next(0, 100);
            }
        }
    }

    static int SomaLinQuatro(int[,] vetor){
        int soma = 0;
        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                if(x == 4){
                    soma+=vetor[x,y];
                }
            }
        }
        return soma;
    }

    static int SomaColDois(int[,] vetor){
        int soma = 0;
        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                if(y == 2){
                    soma+=vetor[x,y];
                }
            }
        }
        return soma;
    }

    static int SomaDiagPrincipal(int[,] vetor){
        int soma = 0;
        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                if(x == y){
                    soma+=vetor[x,y];
                }
            }
        }
        return soma;
    }

    static int SomaDiagSecundaria(int[,] vetor){
        int soma = 0;
        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                if(x == 0 && y == 4)
                    soma+=vetor[x,y];
                if(x == 1 && y == 3)
                    soma+=vetor[x,y];
                if(x == 2 && y == 2)
                    soma+=vetor[x,y];
                if(x == 3 && y == 1)
                    soma+=vetor[x,y];
                if(x == 4 && y == 0)
                    soma+=vetor[x,y];
            }
        }
        return soma;
    }
    static int SomaVetor(int[,] vetor){
        int soma = 0;
        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                soma+=vetor[x,y];
            }
        }
        return soma;
    }

    static void ImprimirVetor(int[,] vetor, int sm1, int sm2, int sm3, int sm4, int sm5){
        for(int x = 0; x < 5; x++){
            for(int y = 0; y < 5; y++){
                Console.Write("[" + x + "] [" + y  + "] = [" + vetor[x,y] + "] \n");
            }
        }
        Console.WriteLine("Soma da Linha 4: " + sm1);
        Console.WriteLine("Soma da Coluna 2: " + sm2);
        Console.WriteLine("Soma da diagonal principal: " + sm3);
        Console.WriteLine("Soma da diagonal secundária: " + sm4);
        Console.WriteLine("Soma de todo o vetor: " + sm5);
    }

    public static void Main(string[] args){
        int[,] vetor = new int[5,5];

        Preencher(ref vetor);

        ImprimirVetor(vetor, SomaLinQuatro(vetor), SomaColDois(vetor), SomaDiagPrincipal(vetor), SomaDiagSecundaria(vetor), SomaVetor(vetor));        
    }
}