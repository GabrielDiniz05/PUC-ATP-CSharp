using System;

class Program{

    static int mdc(int num1, int num2){
        int mdc = 1, divisor = 1;
        
        while(num1 > 1 || num2 > 1){
            if(num1%divisor == 0 || num2%divisor == 0){
                int aux1 = 0, aux2 = 0;

                Console.WriteLine("N1: " + num1 + "\nN2: " + num2);

                if(num1 == 1){
                    num1 = 1;
                }
                if(num2 == 1){
                    num2 = 1;
                }

                aux1 = num1 / divisor;
                aux2 = num2 / divisor;
                
                if(num1%divisor == 0){
                    num1 = aux1;
                }
                if(num2%divisor == 0){
                    num2 = aux2;
                }
                if(divisor == 1){
                    divisor++;
                }
            }else{
                divisor++;
            }
            if(num1%divisor == 0 && num2%divisor == 0){
                    mdc*=divisor;
            }
        }
        return mdc;
    }

    public static void Main(string[] args){
        int n1, n2;

        Console.WriteLine("Insira o primeir número: ");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo número: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("O MDC de {0} e {1} é: {2}", n1, n2, mdc(n1, n2));

    }
}