using System;

class Program{

    static int[] primeiroVetor = new int[10];

    static int tVetor = 0;

    static void preencherVetor(int[] vetor){
        Random rnd = new Random();
        for(int i = 0; i < vetor.Length; i++){
            vetor[i] = rnd.Next(-100, 100);
        }
    }

    static int[] filVetor(int[] vetor){
        
        for(int i = 0; i < vetor.Length; i++){
            if(vetor[i] < 0){
                tVetor++;
            }
        }
        int[] vetorNegativo = new int[tVetor];
        int cont1 = 0;
        int cont2 = 0;
        while(cont1 < vetor.Length){
            if(vetor[cont1] <  0){
                vetorNegativo[cont2] = vetor[cont1];
                cont2++;
            }
            cont1++;
        }
        return vetorNegativo;
    }

    static void imprimir(int[] vetor){
        for(int i = 0; i < vetor.Length;  i++){
            Console.WriteLine(vetor[i]);
        } 
    }

    public static void Main(string[] args){
        preencherVetor(primeiroVetor);
        
        imprimir(filVetor(primeiroVetor));
    }
}