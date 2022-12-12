using System;

class Program{

    static void ConverterFrase(string frase){
        char[] vogais = new char[] { 'a', 'e', 'i', 'o', 'u'};
        string[] conjFrases = frase.Split(vogais);
        foreach (string i in conjFrases) {
            Console.Write(i);
        }
    }

    public static void Main(string[] args){

        Console.WriteLine("Insira uma frase para receber sem vogal: ");

        string frase = Console.ReadLine();

        ConverterFrase(frase);
    }
}