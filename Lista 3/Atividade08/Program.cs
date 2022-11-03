using System;

class Program{

    static double calc(int num){
        double s = 0;
        for(int i = 1; i < num; i++){
            double arg1 = (Math.Pow(i,2) + 1);
            double arg2 = (i+3);

            s = arg1/arg2;
            
            // Console.WriteLine("{0} / {1} = {2}", arg1, arg2, s);
                  
        }
        return s;
    }

    public static void Main(string[] args){
        int num;
        Console.WriteLine("Insira um número: ");
        num = int.Parse(Console.ReadLine());

        Console.WriteLine("O resultado é: " + calc(num));
    }
}