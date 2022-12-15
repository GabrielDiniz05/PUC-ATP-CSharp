using System;

class Program{

    public static void Main(string[] args){

        string caminho = @".\ler.txt";
        int qnt = 0;
        string letras =  "";
        int totalVogais = 0;
        int vA = 0, vE = 0, vI = 0, vO = 0, vU = 0;
        string linha;


        StreamWriter sw = new StreamWriter(caminho);

        Console.WriteLine("Insira a quantidade de letras que deseja inserir: ");
        qnt = int.Parse(Console.ReadLine());

        for(int i = 0; i < qnt; i++){
            Console.WriteLine("Insira a letra: ");
            letras = Console.ReadLine();
            sw.WriteLine(letras);
        }

    
        sw.Close();       

        StreamReader sr = new StreamReader(caminho);

        linha = sr.ReadLine();        

        while(linha != null){
            for(int i = 0; i <  linha.Length; i++){
                if(linha[i] == 'a'){
                    vA++;
                    totalVogais++;
                }
                if(linha[i] == 'e'){
                    vE++;
                    totalVogais++;
                }
                if(linha[i] == 'i'){
                    vI++;
                    totalVogais++;
                }
                if(linha[i] == 'o'){
                    vO++;
                    totalVogais++;
                }
                if(linha[i] == 'u'){
                    vU++;
                    totalVogais++;
                }
            }
            linha = sr.ReadLine();
        }

        Console.WriteLine("O total de vogais foi de: " + totalVogais +
                          "\nO total de letras A: " + vA +
                          "\nO total de letras E: " + vE +
                          "\nO total de letras I: " + vI +
                          "\nO total de letras O: " + vO +
                          "\nO total de letras U: " + vU);


    }
}