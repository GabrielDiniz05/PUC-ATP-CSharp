using System;

class Program{

    static double mediaAprov(double  nota, int alunos, double notaTotal){
        double media = 0;
        Console.WriteLine("Número de alunos: " + alunos);
        Console.WriteLine("Nota Total: " + notaTotal);
        media = notaTotal / alunos;

        return media;
    }

    public static void Main(string[] args){
        bool start = true;
        double nota = 0, media = 0, notaTotal = 0;
        int alunos = 0, cont = 0;
        string resp;

        while(start){
            alunos++;
            cont++;
            Console.WriteLine("Insira a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());

            if(nota >= 6.0){
                notaTotal+=nota;
            }else{
                alunos--;
            }

            media = mediaAprov(nota, alunos, notaTotal);

            if(cont == 10){
                Console.WriteLine("Deseja continuar e inserir mais notas? (s/n)");
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
        Console.WriteLine("A média das notas é: " + media);
    }
}