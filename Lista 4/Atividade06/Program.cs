using System;

class Program{

    public static void Main(string[] args){
        int[] vetor = new int[32];
        int menorTemp = 30, maiorTemp = 0, mediaTemp = 0, maxTemp = 0, abaixoMdTemp = 0; 
        Random rdm = new Random();
    
        for(int i = 0; i < vetor.Length; i++){
            vetor[i] = rdm.Next(15, 40);
        }

        for(int i = 0; i < vetor.Length; i++){
            if(vetor[i] < menorTemp){
                menorTemp = vetor[i];
            }
            if(vetor[i]  > maiorTemp){
                maiorTemp = vetor[i];
            }
            maxTemp += vetor[i];
        }
        mediaTemp = maxTemp / vetor.Length;

        for(int i = 0; i <  vetor.Length; i++){
            if(vetor[i] < mediaTemp){
                abaixoMdTemp++;
            }
        }

        Console.WriteLine("A menor temperatura foi: {0} \nA maior temperatura foi: {1} \nA média de temperaturas foi: {2} \nO número de dias em que a temperatura foi inferior a média é: {3}", menorTemp, maiorTemp, mediaTemp, abaixoMdTemp);
    }
}