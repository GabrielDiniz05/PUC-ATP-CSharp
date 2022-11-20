using System;

class Program{

    static void PreencherVetor(ref int[] vetor1, ref int[] vetor2){
        Random rdm = new Random();

        for(int i = 0; i < 10; i++){
            vetor1[i] = rdm.Next(1, 100);
            vetor2[i] = rdm.Next(-100, 1);
        }
    }

    static void FusaoVetor(int[] vetor1, int[] vetor2){
        int tamanhoTotal = vetor1.Length + vetor2.Length;
        
        int[] vetorFinal = new int[tamanhoTotal];
        
        for(int i = 0; i < tamanhoTotal; i++){
            if(i < 10){
                if(i%2 == 0){
                    vetorFinal[i] = vetor1[i];
                }else{
                    vetorFinal[i] = vetor2[i];
                }
            }else{
                if(i%2 == 1){
                    vetorFinal[i] = vetor2[i - 10];
                }else{
                    vetorFinal[i] = vetor1[i - 10];
                }
            }
        }
        for(int i = 0; i < vetorFinal.Length; i++){
            Console.WriteLine(vetorFinal[i]);
        }
        
    }

    public static void Main(string[] args){
        int[] vetorP = new int[10], vetorN = new int[10];

        PreencherVetor(ref vetorP, ref vetorN);

        FusaoVetor(vetorP, vetorN);
        
    }
}