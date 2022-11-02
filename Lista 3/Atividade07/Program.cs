using System;

class Program{

    static void lerMedia(int media){
        if(media <= 39){
            Console.WriteLine("Nota: F");
        }else if(media <= 59){
            Console.WriteLine("Nota: E");
        }else if(media <= 69){
            Console.WriteLine("Nota: D");
        }else if(media <= 79){
            Console.WriteLine("Nota: C");
        }else if(media <= 89){
            Console.WriteLine("Nota: B");
        }else{
            Console.WriteLine("Nota: A");
        }
    }

    public static void Main(string[] args){
        bool start = true;
        int media, cont = 0;
        string resp;


        while(start){
            cont++;
            Console.WriteLine("Insira a média: ");
            media = int.Parse(Console.ReadLine());

            lerMedia(media);
            if(cont == 10){
                Console.WriteLine("Deseja verificar mais médias? ");
                resp = Console.ReadLine();
                if(resp.ToUpper() == "S"){
                    cont = 0;
                }else if(resp.ToUpper() == "N"){
                    break;
                }else{
                    Console.WriteLine("Comando inválido. Interrompendo o programa...");
                    break;
                }
            }
        }
    }
}