using System;

class Program{

    static int PopulacaoTotal = 0;
    static double SalarioMedioPopulacao = 0, salario_total = 0;

    static void LerDados(){
        string resp1, resp2;
        double salario1 = 0, salario2 = 0;
        int num_filhos = 0;
        
        Console.WriteLine("É casado(a)? (s/n)");
        resp1 = Console.ReadLine();

        Console.WriteLine("Tem filhos? (s/n)");
        resp2 = Console.ReadLine();

        Console.WriteLine("Insira o seu salário: ");
        salario1 = double.Parse(Console.ReadLine());

        if(resp1.ToUpper() == "S"){
            PopulacaoTotal++;
            Console.WriteLine("Insira o salário da sua esposa ou do seu marido: ");
            salario2 = double.Parse(Console.ReadLine());
        }

        if(resp2.ToUpper() == "S"){
            Console.WriteLine("Insira o número de filhos: ");
            num_filhos = int.Parse(Console.ReadLine());
        }

        PopulacaoTotal+=num_filhos;

        salario_total+=(salario1 +salario2);

        Console.WriteLine("Salario total: " + salario_total);
        
        SalarioMedioPopulacao = salario_total / PopulacaoTotal; 
    }

    public static void Main(string[] args){
        int contador = 0;
        string resp;

        Console.WriteLine("Bem vindo(a) ao programa de pesquisa do governo!");

        do{
            contador++;
            PopulacaoTotal++;

            LerDados();

            if(contador == 2){
                Console.WriteLine("Deseja continuar e cadastrar mais 10 vezes? (s/n)");
                resp = Console.ReadLine();
                if(resp.ToUpper() == "S"){
                    contador = 0;
                    continue;
                }else if(resp.ToUpper() == "N"){
                    break;
                }else{
                    Console.WriteLine("Entranda Inválida! Interrompendo o programa ...");
                    break;
                }
            }
        }while(contador < 10);

        Console.WriteLine("\n\n--Resultado da Pesquisa--\n\n");
        Console.WriteLine("Número total de habitantes: " + PopulacaoTotal +
        "\nNúmero da média de salário por habitante: " + SalarioMedioPopulacao);
    }
}