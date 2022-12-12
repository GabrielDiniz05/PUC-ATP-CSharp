using System;
using System.Text;

class Program{

    public static void Main(string[] args){
        String caminho = @"C:\Users\gabri\OneDrive\Área de Trabalho\Sistemas da Informação\Algoritmos\Atividades\Lista 5\Atividade04\ler.txt";

        StreamReader sr = new StreamReader(caminho);

        String linha = sr.ReadLine();

        int cont = 0;

        while(linha != null){
            for(int i = 0; i < linha.Length; i++){
                if(linha[i] == 'a'){
                    cont++;
                }
            }
            Console.WriteLine("Linha: " + linha);
            linha = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine("Contador: " + cont);
    }
}