using System;

class Program{

    public static void Main(string[] args){
        string caminho = @".\ler.txt";

        StreamReader sr = new StreamReader(caminho);

        string linha = sr.ReadLine();

        int contL = 0;

        while(linha != null){
            for(int i = 0; i < linha.Length; i++){
                Console.Write(linha[i]);
            }
            Console.WriteLine();
            linha = sr.ReadLine();
            contL++;
        }
        sr.Close();
    }
}