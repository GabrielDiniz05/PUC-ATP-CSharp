using System;

class Program{

    public static void Main(string[] args){
        int[,] vetor = new int[4,4];
        Random rdm = new Random();
        int soma = 0;

        for(int x = 0; x < 4; x++){
            for(int y = 0; y < 4; y++){
                vetor[x,y] = rdm.Next(1,10);
            }
        }

        for(int x = 0; x < 4; x++){
            for(int y = 0; y < 4; y++){
                Console.WriteLine("[{0}] [{1}] = [{2}]", x, y, vetor[x, y]);
                if(x == y){
                    Console.WriteLine("{0} é um elemento da diagonal principal", vetor[x,y]);
                    int i = 0;
                    while(i < 4){
                        if(i+1 != 4){
                            Console.WriteLine("Soma: "+ soma);
                            soma+=vetor[x, i+1];
                        }else{
                            break;
                        }
                        i++;
                    }
                }
            }
        }
        Console.WriteLine("A soma dos elementos abaixo da diagonal principal é: " + soma);
    }
}