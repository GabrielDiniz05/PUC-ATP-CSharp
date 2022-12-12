using System;

class Program{

    static void CifraDeCesar(int posicoes, string frase){
        int[] fraseParaInt = new int[frase.Length];
        string intParaFrase = "";
        for(int i = 0; i<  frase.Length; i++){
            fraseParaInt[i] = Convert.ToInt32(frase[i]);
        }
        int[] novaCifra = new int[fraseParaInt.Length];
        for(int i = 0; i < fraseParaInt.Length; i++){
            novaCifra[i] = fraseParaInt[i] + posicoes;
            
            while(novaCifra[i] > 122){
                novaCifra[i] = 96 + (novaCifra[i] - 122);
            }
            
            if(novaCifra[i] - posicoes == 32){
                novaCifra[i] = 0;
            }
            if(novaCifra[i] - posicoes == 44){
                novaCifra[i] = 0;
            }
            if(novaCifra[i] - posicoes == 46){
                novaCifra[i] = 0;
            }
            intParaFrase += ((char)novaCifra[i]).ToString();
        }
        Console.WriteLine("\nFrase criptografada na cifra de césar: " + intParaFrase);
    }

    public static void Main(string[] args){

        Console.WriteLine("Insira o número de posições (0 a 25) que deseja na cifra de césar: ");
        int posicoes = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira a frase para criptografar: ");
        string frase = Console.ReadLine();

        CifraDeCesar(posicoes, frase.ToLower());
    }
}