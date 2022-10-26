using System;

class Program{

    static void LerConjunto(int num1, int num2, int num3){
        if((num1 > num2 && num1 > num3) || (num1 == num2 && num1 > num3) || (num1 > num2 && num1 == num3) || (num1 == num2 && num1 == num3)){
            if(num2 > num3){
                Console.WriteLine("Ordem Crescente: [{0}], [{1}], [{2}]", num3, num2, num1);
            }else{
                Console.WriteLine("Ordem Crescente: [{0}], [{1}], [{2}]", num2, num3, num1);
            }
        }else if(num2 > num1 && num2 > num3 || (num2 == num1 && num2 > num3) || (num2 > num1 && num2 == num3) || (num2 == num1 && num2 == num3)){
            if(num1 > num3){
                Console.WriteLine("Ordem Crescente: [{0}], [{1}], [{2}]", num3, num1, num2);
            }else{
                Console.WriteLine("Ordem Crescente: [{0}], [{1}], [{2}]", num1, num3, num2);
            }
        }else if(num3 > num1 && num3 > num2 || (num3 == num1 && num3 > num2) || (num3 > num1 && num3 == num2) || (num3 == num1 && num3 == num2)){
            if(num1 > num2){
                Console.WriteLine("Ordem Crescente: [{0}], [{1}], [{2}]", num2, num1, num3);
            }else{
                Console.WriteLine("Ordem Crescente: [{0}], [{1}], [{2}]", num1, num2, num3);
            }
        }
    }

    public static void Main(string[] args){
        int qntConjuntos = 0;
        int num1 = 0, num2 = 0, num3 = 0;

        Console.WriteLine("Insira a quantidade de conjuntos de valores que vão ser inseridos: ");
        qntConjuntos = int.Parse(Console.ReadLine());

        for(int i = 0; i < qntConjuntos; i++){
            Console.WriteLine("Insira o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número: ");
            num3 = int.Parse(Console.ReadLine());

            LerConjunto(num1, num2, num3);
        }
    }
}