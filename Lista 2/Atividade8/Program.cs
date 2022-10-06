using System;

class Program{

    public static void Main(String[] args){
        int num, a = 0, fib = 1;

        Console.WriteLine("Insira um número: ");
        num = int.Parse(Console.ReadLine());


        for(int i = 0; i < num; i++){
            if(fib > num || a > num){
                i = num;
            }
            if(fib < num || a < num){
                Console.Write(a + " " + fib + " ");
            
                a+=fib;
                fib+=a;
               
            }else{
                i = num;
            }
        }
    }
}