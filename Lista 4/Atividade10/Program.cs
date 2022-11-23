using System;

class Program{

    static void Preencher(ref int[,] matriz){
        Random rdm = new Random();
        for(int x = 0; x < 10;x++){
            for(int y = 0; y < 10; y++){
                matriz[x,y] = rdm.Next(1, 200);
            }
        }
    }

    public static void Main(string[] args){
        int[,] matriz = new int[10,10];

        Preencher(ref matriz);
    }
}