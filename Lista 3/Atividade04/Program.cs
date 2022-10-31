using System;

class Program{

    static void VerifTriangulo(){
        double c1, c2, c3;

        Console.WriteLine("Insira o primeiro valor: ");
        c1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor: ");
        c2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Insira o terceiro valor: ");
        c3 = double.Parse(Console.ReadLine());

        if(c1 < (c2 + c3) && c2 < (c1+c3) && c3 < (c1+c2)){
            if(c1 == c2 && c1 == c3 && c2 == c3){
                Console.WriteLine("O triãngulo é equilátero!");
            }else if(c1 == c2 || c2 == c3 || c1 == c3){
                Console.WriteLine("O triãngulo é isósceles!");
            }else if(c1 != c2 && c1 != c3 && c2 != c3){
                Console.WriteLine("O triãngulo é escaleno!");
            }
        }else{
            Console.WriteLine("Não é um trinângulo! Favor inserir os valores novamente: ");
            VerifTriangulo();
        }

    }

    public static void Main(string[] args){
        bool start = true;
        int cont = 0;


        Console.WriteLine("Insira o comprimento dos lados do triãngulo para descobrir o tipo do mesmo!");

        do{
            if(cont < 10){
                VerifTriangulo();
                cont++;
            }else{
                string resp;
                Console.WriteLine("Deseja verificar mais triângulos? (s/n)");
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
        }while(start);
    }
}