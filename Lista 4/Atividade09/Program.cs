using System;

class Program{

    static void Preencher(ref int[,] m1, ref int[,] m2){
        Random rdm = new Random();
        for(int x = 0; x < 4; x++){
            for(int y = 0; y < 6; y++){
                m1[x,y] = rdm.Next(0, 40);
            }
        }
        for(int x = 0; x < 4; x++){
            for(int y = 0; y < 6; y++){
                m2[x,y] = rdm.Next(40, 80);
            }
        }
    }

    static int[,] SomaMatriz(int[,] m1, int[,] m2){
        int[,] matrizSoma = new int[m1.Length, m2.Length];

        for(int x = 0; x < m1.Length; x++){
            for(int y = 0; y < m2.Length; y++){
                if(x < 4){
                    if(y < 6){
                        //if(m1[x,y] != m2[x,y]){
                            matrizSoma[x, y] = m1[x,y];
                        //}
                    }
                }
                if(x > 3){
                    if(y > 5){
                        //if(m1[x,y] != m2[x,y]){
                            matrizSoma[x,y] = m2[x - 4, y - 6];
                        //}
                    }
                }
            }
        }
        return matrizSoma;
    }

    static int[,] DifMatriz(int[,] m1, int[,] m2){
        int[,] matrizDif = new int[m1.Length, m2.Length];

        for(int x = 0; x < m1.Length; x++){
            for(int y = 0; y < m2.Length; y++){
                if(m1[x,y] != m2[x,y]){
                    if(x < 4 && y < 6){
                        matrizDif[x, y] = m1[x,y];
                    }
                    if(x > 3 && y > 5){
                        matrizDif[x,y] = m2[x - 4, y - 6];
                    }
                }
            }
        }
        return matrizDif;
    }

    public static void Main(string[] args){
        int[,] matriz1 = new int[4,6], matriz2 = new int[4,6];

        Preencher(ref matriz1, ref matriz2);
        Console.WriteLine("A soma das matrizes é: {0} \nA diferença entre as matrizes é: {1}", SomaMatriz(matriz1, matriz2)/*, DifMatriz(matriz1, matriz2)*/);
    }
}