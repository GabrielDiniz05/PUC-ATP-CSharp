using System;

class Program{

    static bool verificar(int num){
        if(num > 0){
            return true;
        }else if(num < 0){
            return false;
        }
        return true;
    }

    public static void Main(string[] args){
        bool start = true;
        int num = 0;
        int cont = 0;
        string resp;

        while(start){
            cont++;
            Console.WriteLine("Insira o número: ");
            num = int.Parse(Console.ReadLine());

            if(verificar(num) == true){
                Console.WriteLine("O número é positivo!");
            }else if(verificar(num) == false){
                Console.WriteLine("O número é negativo!");
            }
            if(cont == 10){
                Console.WriteLine("Deseja verificar mais números? (s/n)");
                resp = Console.ReadLine();

                if(resp.ToUpper() == "S"){
                    cont = 0;
                }else if(resp.ToUpper() == "N"){
                    break;
                }else{
                    Console.WriteLine("Comando inválido! Interrompendo o programa...");
                    break;
                }
            }
        }
    }
}