using System;

public class Program{

    public static void Main(String[] args){

        int numero = 0;
        int contador1 = 0, contador2 = 0, contador3 = 0;

        for(int i = 0; i < 10; i++){
            
            Console.WriteLine("Insira um número: ");
            numero = int.Parse(Console.ReadLine());

            if(numero%3 == 0 && numero%9 ==0){
                contador1++;
            }else{
                Console.WriteLine("Número não divisível por 3 e 9!");
            }

            if(numero%2 == 0){
                contador2++;
            }else{
                Console.WriteLine("Número não divisível por 2!");
            }

            if(numero%5 == 0){
                contador3++;
            }else{
                Console.WriteLine("Número não divisível por 5!");
            }
        }
        Console.WriteLine("Números divisíveis por 3 e 9: {0} \nNúmeros divisíveis por 2: {1} \nNúmeros divisíveis por 5: {2}", contador1, contador2, contador3);
    }
}