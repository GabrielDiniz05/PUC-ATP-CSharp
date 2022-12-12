using System;

class Program{

    static int ContarEspBranco(string frase){
        int espacoBranco = 0;
        for(int i = 0; i < frase.Length; i++){
            if(frase[i] == ' '){
                espacoBranco++;
            }
        }
        return espacoBranco;
    }

    public static void Main(string[] args){

        Console.WriteLine("Insira uma frase para saber a quantidade de espaços em branco: ");

        string frase = Console.ReadLine();

        Console.WriteLine("Quantidade de espaçoes em branco: " + ContarEspBranco(frase));
    }   
}