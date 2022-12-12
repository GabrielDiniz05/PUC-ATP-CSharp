using System;
using System.Text;

class Program{

    public static void Main(string[] args){

        Random rm = new Random();

        String caminho = @"C:\Users\gabri\OneDrive\Área de Trabalho\Sistemas da Informação\Algoritmos\Atividades\Lista 5\Atividade10\ler.txt";

        StreamWriter sw = new StreamWriter(caminho);

        for(int i = 0; i < 100; i++){
            sw.Write(rm.Next(0, 100) + " ");
        }

        sw.Close();
       

        StreamReader sr = new StreamReader(caminho);
        String linha = sr.ReadLine();
        int max_number = 0;
        int min_number = 0;
        int med = 0;
        int[] num_linha = new int[linha.Length];

        Console.WriteLine("Linha: " + linha);
        for(int i = 0; i < linha.Length; i++){
            
            
            Console.Write("[Num: " + (char)num_linha[i] + "] ");

            // med += (int)linha[i];
            // if((int)linha[i] > (int)linha[i-1]){
            //     max_number = (int)linha[i];
            // }
            // if((int)linha[i] < (int)linha[i-1]){
            //     min_number = (int)linha[i];
            // }
            // med /= linha.Length;
            sr.ReadLine();
        }

        Console.WriteLine("\n\nMaior número: " + max_number);
        Console.WriteLine("Menor número: " + min_number);
        Console.WriteLine("Média: " + med);
    }
}